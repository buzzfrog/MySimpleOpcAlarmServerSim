using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpcAlarmServer
{
    class MyServer : StandardServer
    {
        private DateTime _lastEventTime { get; set; }
        private Task _status { get; set; }
        private int _serverRunTime { get; set; } = Timeout.Infinite;
        private ICertificateValidator _certificateValidator;

        internal void Run()
        {
            try
            {
                InitializeAsync().Wait();
                Console.WriteLine("Server started. Press Ctrl-C to exit...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
                return;
            }

            ManualResetEvent quitEvent = new ManualResetEvent(false);
            try
            {
                Console.CancelKeyPress += (sender, eArgs) =>
                {
                    quitEvent.Set();
                    eArgs.Cancel = true;
                };
            }
            catch
            {
            }

            // wait for timeout or Ctrl-C
            quitEvent.WaitOne(_serverRunTime);

            Console.WriteLine("Server stopped. Waiting for exit...");

            CurrentInstance.SessionManager.SessionActivated -= EventStatus;
            CurrentInstance.SessionManager.SessionClosing -= EventStatus;
            CurrentInstance.SessionManager.SessionCreated -= EventStatus;

            // Stop status thread
            _status.Wait();

            // Stop server and dispose
            Stop();
        }

        /// <summary>
        /// Initializes the server before it starts up.
        /// </summary>
        /// <remarks>
        /// This method is called before any startup processing occurs. The sub-class may update the 
        /// configuration object or do any other application specific startup tasks.
        /// </remarks>
        protected override void OnServerStarting(ApplicationConfiguration configuration)
        {
            Console.WriteLine("The server is starting.");

            base.OnServerStarting(configuration);

            // it is up to the application to decide how to validate user identity tokens.
            // this function creates validator for X509 identity tokens.
            CreateUserIdentityValidators(configuration);
        }

        /// <summary>
        /// Called after the server has been started.
        /// </summary>
        protected override void OnServerStarted(IServerInternal server)
        {
            base.OnServerStarted(server);

            // request notifications when the user identity is changed. all valid users are accepted by default.
            //server.SessionManager.ImpersonateUser += new ImpersonateEventHandler(SessionManager_ImpersonateUser);
        }

        /// <summary>
        /// Cleans up before the server shuts down.
        /// </summary>
        /// <remarks>
        /// This method is called before any shutdown processing occurs.
        /// </remarks>
        protected override void OnServerStopping()
        {
            Console.WriteLine("The Server is stopping.");

            base.OnServerStopping();
        }

        /// <summary>
        /// Creates the node managers for the server.
        /// </summary>
        /// <remarks>
        /// This method allows the sub-class create any additional node managers which it uses. The SDK
        /// always creates a CoreNodeManager which handles the built-in nodes defined by the specification.
        /// Any additional NodeManagers are expected to handle application specific nodes.
        /// 
        /// Applications with small address spaces do not need to create their own NodeManagers and can add any
        /// application specific nodes to the CoreNodeManager. Applications should use custom NodeManagers when
        /// the structure of the address space is stored in another system or when the address space is too large
        /// to keep in memory.
        /// </remarks>
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Console.WriteLine("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>
            {
                // create the custom node managers
                new OpcAlarmServerNodeManager(server, configuration)
            };

            // create master node manager
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        /// <summary>
        /// Loads the non-configurable properties for the application.
        /// </summary>
        /// <remarks>
        /// These properties are exposed by the server but cannot be changed by administrators.
        /// </remarks>
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties
            {
                ManufacturerName = "Buzzfrog",
                ProductName = "OpcAlarmServer",
                ProductUri = "http://buzzfrog.se/OpcAlarmServer",
                SoftwareVersion = Utils.GetAssemblySoftwareVersion(),
                BuildNumber = Utils.GetAssemblyBuildNumber(),
                BuildDate = Utils.GetAssemblyTimestamp()
            };

            return properties;
        }

        private async Task InitializeAsync()
        {
            ApplicationInstance application = new ApplicationInstance();

            application.ApplicationName = "UA Core Sample Server";
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "Opc.Ua.MyServer";

            ApplicationConfiguration config = await application.LoadApplicationConfiguration(false);

            bool haveAppCertificate = await application.CheckApplicationInstanceCertificate(false, 0);
            if (!haveAppCertificate)
            {
                throw new Exception("Application instance certificate invalid!");
            }

            if (!config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                config.CertificateValidator.CertificateValidation += new CertificateValidationEventHandler(CertificateValidator_CertificateValidation);
            }

            await application.Start(this);

            Console.WriteLine("Server Endpoints:");
            var endpoints = GetEndpoints().Select(e => e.EndpointUrl).Distinct();
            foreach (var endpoint in endpoints)
            {
                Console.WriteLine(endpoint);
            }

            _status = Task.Run(new Action(StatusThread));

            CurrentInstance.SessionManager.SessionActivated += EventStatus;
            CurrentInstance.SessionManager.SessionClosing += EventStatus;
            CurrentInstance.SessionManager.SessionCreated += EventStatus;
        }

        private void EventStatus(Session session, SessionEventReason reason)
        {
            _lastEventTime = DateTime.UtcNow;
            PrintSessionStatus(session, reason.ToString());
        }

        private async void StatusThread()
        {
            if (DateTime.UtcNow - _lastEventTime > TimeSpan.FromMilliseconds(6000))
            {
                IList<Session> sessions = CurrentInstance.SessionManager.GetSessions();
                for (int ii = 0; ii < sessions.Count; ii++)
                {
                    Session session = sessions[ii];
                    PrintSessionStatus(session, "-Status-", true);
                }
                _lastEventTime = DateTime.UtcNow;
            }
            await Task.Delay(1000);
        }

        private void PrintSessionStatus(Session session, string reason, bool lastContact = false)
        {
            lock (session.DiagnosticsLock)
            {
                string item = String.Format("{0,9}:{1,20}:", reason, session.SessionDiagnostics.SessionName);
                if (lastContact)
                {
                    item += String.Format("Last Event:{0:HH:mm:ss}", session.SessionDiagnostics.ClientLastContactTime.ToLocalTime());
                }
                else
                {
                    if (session.Identity != null)
                    {
                        item += String.Format(":{0,20}", session.Identity.DisplayName);
                    }
                    item += String.Format(":{0}", session.Id);
                }
                Console.WriteLine(item);
            }
        }

        private void CreateUserIdentityValidators(ApplicationConfiguration configuration)
        {
            for (int ii = 0; ii < configuration.ServerConfiguration.UserTokenPolicies.Count; ii++)
            {
                UserTokenPolicy policy = configuration.ServerConfiguration.UserTokenPolicies[ii];

                // create a validator for a certificate token policy.
                if (policy.TokenType == UserTokenType.Certificate)
                {
                    // check if user certificate trust lists are specified in configuration.
                    if (configuration.SecurityConfiguration.TrustedUserCertificates != null &&
                        configuration.SecurityConfiguration.UserIssuerCertificates != null)
                    {
                        CertificateValidator certificateValidator = new CertificateValidator();
                        certificateValidator.Update(configuration.SecurityConfiguration).Wait();
                        certificateValidator.Update(configuration.SecurityConfiguration.UserIssuerCertificates,
                            configuration.SecurityConfiguration.TrustedUserCertificates,
                            configuration.SecurityConfiguration.RejectedCertificateStore);

                        // set custom validator for user certificates.
                        _certificateValidator = certificateValidator.GetChannelValidator();
                    }
                }
            }
        }

        private void CertificateValidator_CertificateValidation(CertificateValidator validator, CertificateValidationEventArgs e)
        {
            if (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted)
            {
                Console.WriteLine("Accepted Certificate: {0}", e.Certificate.Subject);
            }
        }
    }
}
