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

        void PrintSessionStatus(Session session, string reason, bool lastContact = false)
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
    }
}
