/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace buzzfrog.OpcAlarmServer
{
    #region TankState Class
    #if (!OPCUA_EXCLUDE_TankState)
    /// <summary>
    /// Stores an instance of the TankType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TankState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TankState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(buzzfrog.OpcAlarmServer.ObjectTypes.TankType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vYnV6emZyb2cuc2UvT3BjQWxhcm1TZXJ2ZXL/////BGCAAgEAAAABABAAAABU" +
           "YW5rVHlwZUluc3RhbmNlAQH9OgEB/Tr9OgAA/////wIAAAAVYIkKAgAAAAEACQAAAFRhbmtMZXZlbAEB" +
           "/joALwA//joAAAAL/////wEB/////wAAAAAEYIAKAQAAAAEAEgAAAFRhbmtMZXZlbENvbmRpdGlvbgEB" +
           "AzsALwEBKDsDOwAA/////xUAAAAVYIkKAgAAAAAABwAAAEV2ZW50SWQBAQQ7AC4ARAQ7AAAAD/////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUBAQU7AC4ARAU7AAAAEf////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQEGOwAuAEQGOwAAABH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAKAAAAU291cmNlTmFtZQEBBzsALgBEBzsAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRp" +
           "bWUBAQg7AC4ARAg7AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQEJ" +
           "OwAuAEQJOwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQELOwAuAEQLOwAA" +
           "ABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAQw7AC4ARAw7AAAABf////8BAf//" +
           "//8AAAAAFWCJCgIAAAAAABAAAABDb25kaXRpb25DbGFzc0lkAQENOwAuAEQNOwAAABH/////AQH/////" +
           "AAAAABVgiQoCAAAAAAASAAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQEOOwAuAEQOOwAAABX/////AQH/////" +
           "AAAAABVgiQoCAAAAAAANAAAAQ29uZGl0aW9uTmFtZQEBETsALgBEETsAAAAM/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACAAAAEJyYW5jaElkAQESOwAuAEQSOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAG" +
           "AAAAUmV0YWluAQETOwAuAEQTOwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0" +
           "YXRlAQEUOwAvAQAjIxQ7AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBFTsALgBEFTsA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAR07AC8BACojHTsAAAAT/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBHjsALgBEHjsAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAMAAAATGFzdFNldmVyaXR5AQEfOwAvAQAqIx87AAAABf////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3RhbXABASA7AC4ARCA7AAABACYB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAENvbW1lbnQBASE7AC8BACojITsAAAAV/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBIjsALgBEIjsAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAAQ2xpZW50VXNlcklkAQEjOwAuAEQjOwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAA" +
           "RGlzYWJsZQEBJDsALwEARCMkOwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxl" +
           "AQElOwAvAQBDIyU7AAABAQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQEm" +
           "OwAvAQBFIyY7AAABAQEAAAABAPkLAAEADQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEB" +
           "JzsALgBEJzsAAJYCAAAAAQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlk" +
           "ZW50aWZpZXIgZm9yIHRoZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////" +
           "AAAAAAMAAAAAJAAAAFRoZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAA" +
           "AAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<double> TankLevel
        {
            get
            {
                return m_tankLevel;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tankLevel, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tankLevel = value;
            }
        }

        /// <remarks />
        public LessThan5LiterInTankConditionState TankLevelCondition
        {
            get
            {
                return m_tankLevelCondition;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tankLevelCondition, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tankLevelCondition = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_tankLevel != null)
            {
                children.Add(m_tankLevel);
            }

            if (m_tankLevelCondition != null)
            {
                children.Add(m_tankLevelCondition);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case buzzfrog.OpcAlarmServer.BrowseNames.TankLevel:
                {
                    if (createOrReplace)
                    {
                        if (TankLevel == null)
                        {
                            if (replacement == null)
                            {
                                TankLevel = new BaseDataVariableState<double>(this);
                            }
                            else
                            {
                                TankLevel = (BaseDataVariableState<double>)replacement;
                            }
                        }
                    }

                    instance = TankLevel;
                    break;
                }

                case buzzfrog.OpcAlarmServer.BrowseNames.TankLevelCondition:
                {
                    if (createOrReplace)
                    {
                        if (TankLevelCondition == null)
                        {
                            if (replacement == null)
                            {
                                TankLevelCondition = new LessThan5LiterInTankConditionState(this);
                            }
                            else
                            {
                                TankLevelCondition = (LessThan5LiterInTankConditionState)replacement;
                            }
                        }
                    }

                    instance = TankLevelCondition;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<double> m_tankLevel;
        private LessThan5LiterInTankConditionState m_tankLevelCondition;
        #endregion
    }
    #endif
    #endregion

    #region LessThan5LiterInTankConditionState Class
    #if (!OPCUA_EXCLUDE_LessThan5LiterInTankConditionState)
    /// <summary>
    /// Stores an instance of the LessThan5LiterInTankConditionType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LessThan5LiterInTankConditionState : ConditionState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LessThan5LiterInTankConditionState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(buzzfrog.OpcAlarmServer.ObjectTypes.LessThan5LiterInTankConditionType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vYnV6emZyb2cuc2UvT3BjQWxhcm1TZXJ2ZXL/////BGCAAgEAAAABACkAAABM" +
           "ZXNzVGhhbjVMaXRlckluVGFua0NvbmRpdGlvblR5cGVJbnN0YW5jZQEBKDsBASg7KDsAAP////8VAAAA" +
           "FWCJCgIAAAAAAAcAAABFdmVudElkAQEpOwAuAEQpOwAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJ" +
           "AAAARXZlbnRUeXBlAQEqOwAuAEQqOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNl" +
           "Tm9kZQEBKzsALgBEKzsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBASw7" +
           "AC4ARCw7AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQEtOwAuAEQtOwAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEBLjsALgBELjsAAAEAJgH/////AQH/" +
           "////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEBMDsALgBEMDsAAAAV/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAACAAAAFNldmVyaXR5AQExOwAuAEQxOwAAAAX/////AQH/////AAAAABVgiQoCAAAAAAAQAAAA" +
           "Q29uZGl0aW9uQ2xhc3NJZAEBMjsALgBEMjsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAAEgAAAENv" +
           "bmRpdGlvbkNsYXNzTmFtZQEBMzsALgBEMzsAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAADQAAAENv" +
           "bmRpdGlvbk5hbWUBATY7AC4ARDY7AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABCcmFuY2hJ" +
           "ZAEBNzsALgBENzsAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAABgAAAFJldGFpbgEBODsALgBEODsA" +
           "AAAB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAEVuYWJsZWRTdGF0ZQEBOTsALwEAIyM5OwAAABX/" +
           "////AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBATo7AC4ARDo7AAAAAf////8BAf////8AAAAAFWCJ" +
           "CgIAAAAAAAcAAABRdWFsaXR5AQFCOwAvAQAqI0I7AAAAE/////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAUM7AC4AREM7AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAA" +
           "AExhc3RTZXZlcml0eQEBRDsALwEAKiNEOwAAAAX/////AQH/////AQAAABVgiQoCAAAAAAAPAAAAU291" +
           "cmNlVGltZXN0YW1wAQFFOwAuAERFOwAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAcAAABDb21t" +
           "ZW50AQFGOwAvAQAqI0Y7AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAA8AAABTb3VyY2VUaW1lc3Rh" +
           "bXABAUc7AC4AREc7AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAADAAAAENsaWVudFVzZXJJZAEB" +
           "SDsALgBESDsAAAAM/////wEB/////wAAAAAEYYIKBAAAAAAABwAAAERpc2FibGUBAUk7AC8BAEQjSTsA" +
           "AAEBAQAAAAEA+QsAAQDzCgAAAAAEYYIKBAAAAAAABgAAAEVuYWJsZQEBSjsALwEAQyNKOwAAAQEBAAAA" +
           "AQD5CwABAPMKAAAAAARhggoEAAAAAAAKAAAAQWRkQ29tbWVudAEBSzsALwEARSNLOwAAAQEBAAAAAQD5" +
           "CwABAA0LAQAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAUw7AC4AREw7AACWAgAAAAEAKgEB" +
           "RgAAAAcAAABFdmVudElkAA//////AAAAAAMAAAAAKAAAAFRoZSBpZGVudGlmaWVyIGZvciB0aGUgZXZl" +
           "bnQgdG8gY29tbWVudC4BACoBAUIAAAAHAAAAQ29tbWVudAAV/////wAAAAADAAAAACQAAABUaGUgY29t" +
           "bWVudCB0byBhZGQgdG8gdGhlIGNvbmRpdGlvbi4BACgBAQAAAAEAAAAAAAAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region BlinkersOnEventState Class
    #if (!OPCUA_EXCLUDE_BlinkersOnEventState)
    /// <summary>
    /// Stores an instance of the BlinkersOnEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BlinkersOnEventState : BaseEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BlinkersOnEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(buzzfrog.OpcAlarmServer.ObjectTypes.BlinkersOnEventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vYnV6emZyb2cuc2UvT3BjQWxhcm1TZXJ2ZXL/////BGCAAgEAAAABABsAAABC" +
           "bGlua2Vyc09uRXZlbnRUeXBlSW5zdGFuY2UBAaU6AQGlOqU6AAD/////CQAAABVgiQoCAAAAAAAHAAAA" +
           "RXZlbnRJZAEBpjoALgBEpjoAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlwZQEB" +
           "pzoALgBEpzoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAag6AC4ARKg6" +
           "AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQGpOgAuAESpOgAAAAz/////" +
           "AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBqjoALgBEqjoAAAEAJgH/////AQH/////AAAAABVg" +
           "iQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAas6AC4ARKs6AAABACYB/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAABwAAAE1lc3NhZ2UBAa06AC4ARK06AAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABTZXZl" +
           "cml0eQEBrjoALgBErjoAAAAF/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAFBvc2l0aW9uT2ZCbGlu" +
           "a2VyAQGvOgAuAESvOgAAAAz/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> PositionOfBlinker
        {
            get
            {
                return m_positionOfBlinker;
            }

            set
            {
                if (!Object.ReferenceEquals(m_positionOfBlinker, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_positionOfBlinker = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_positionOfBlinker != null)
            {
                children.Add(m_positionOfBlinker);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case buzzfrog.OpcAlarmServer.BrowseNames.PositionOfBlinker:
                {
                    if (createOrReplace)
                    {
                        if (PositionOfBlinker == null)
                        {
                            if (replacement == null)
                            {
                                PositionOfBlinker = new PropertyState<string>(this);
                            }
                            else
                            {
                                PositionOfBlinker = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = PositionOfBlinker;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_positionOfBlinker;
        #endregion
    }
    #endif
    #endregion

    #region BlinkersOffEventState Class
    #if (!OPCUA_EXCLUDE_BlinkersOffEventState)
    /// <summary>
    /// Stores an instance of the BlinkersOffEventType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BlinkersOffEventState : BaseEventState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BlinkersOffEventState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(buzzfrog.OpcAlarmServer.ObjectTypes.BlinkersOffEventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vYnV6emZyb2cuc2UvT3BjQWxhcm1TZXJ2ZXL/////BGCAAgEAAAABABwAAABC" +
           "bGlua2Vyc09mZkV2ZW50VHlwZUluc3RhbmNlAQHROgEB0TrROgAA/////wkAAAAVYIkKAgAAAAAABwAA" +
           "AEV2ZW50SWQBAdI6AC4ARNI6AAAAD/////8BAf////8AAAAAFWCJCgIAAAAAAAkAAABFdmVudFR5cGUB" +
           "AdM6AC4ARNM6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOb2RlAQHUOgAuAETU" +
           "OgAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFtZQEB1ToALgBE1ToAAAAM////" +
           "/wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAdY6AC4ARNY6AAABACYB/////wEB/////wAAAAAV" +
           "YIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQHXOgAuAETXOgAAAQAmAf////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAcAAABNZXNzYWdlAQHZOgAuAETZOgAAABX/////AQH/////AAAAABVgiQoCAAAAAAAIAAAAU2V2" +
           "ZXJpdHkBAdo6AC4ARNo6AAAABf////8BAf////8AAAAAFWCJCgIAAAABABEAAABQb3NpdGlvbk9mQmxp" +
           "bmtlcgEB2zoALgBE2zoAAAAM/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> PositionOfBlinker
        {
            get
            {
                return m_positionOfBlinker;
            }

            set
            {
                if (!Object.ReferenceEquals(m_positionOfBlinker, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_positionOfBlinker = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_positionOfBlinker != null)
            {
                children.Add(m_positionOfBlinker);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case buzzfrog.OpcAlarmServer.BrowseNames.PositionOfBlinker:
                {
                    if (createOrReplace)
                    {
                        if (PositionOfBlinker == null)
                        {
                            if (replacement == null)
                            {
                                PositionOfBlinker = new PropertyState<string>(this);
                            }
                            else
                            {
                                PositionOfBlinker = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = PositionOfBlinker;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState<string> m_positionOfBlinker;
        #endregion
    }
    #endif
    #endregion

    #region CarBlinkerState Class
    #if (!OPCUA_EXCLUDE_CarBlinkerState)
    /// <summary>
    /// Stores an instance of the CarBlinkerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CarBlinkerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CarBlinkerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(buzzfrog.OpcAlarmServer.ObjectTypes.CarBlinkerType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vYnV6emZyb2cuc2UvT3BjQWxhcm1TZXJ2ZXL/////BGCAAgEAAAABABYAAABD" +
           "YXJCbGlua2VyVHlwZUluc3RhbmNlAQGbOgEBmzqbOgAA/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region CarBlinkersState Class
    #if (!OPCUA_EXCLUDE_CarBlinkersState)
    /// <summary>
    /// Stores an instance of the CarBlinkersType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CarBlinkersState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CarBlinkersState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(buzzfrog.OpcAlarmServer.ObjectTypes.CarBlinkersType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vYnV6emZyb2cuc2UvT3BjQWxhcm1TZXJ2ZXL/////BGCAAgEAAAABABcAAABD" +
           "YXJCbGlua2Vyc1R5cGVJbnN0YW5jZQEBnDoBAZw6nDoAAP////8CAAAAhGDACgEAAAALAAAATGVmdEJs" +
           "aW5rZXIBAAwAAABMZWZ0IEJsaW5rZXIBAZ06AC8BAZs6nToAAAH/////AgAAAARggAoBAAAAAQAOAAAA" +
           "TGVmdEJsaW5rZXJzT24BAbA6AC8BAaU6sDoAAP////8JAAAAFWCJCgIAAAAAAAcAAABFdmVudElkAQGx" +
           "OgAuAESxOgAAAA//////AQH/////AAAAABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQGyOgAuAESyOgAA" +
           "ABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTm9kZQEBszoALgBEszoAAAAR/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5hbWUBAbQ6AC4ARLQ6AAAADP////8BAf////8AAAAA" +
           "FWCJCgIAAAAAAAQAAABUaW1lAQG1OgAuAES1OgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAsA" +
           "AABSZWNlaXZlVGltZQEBtjoALgBEtjoAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVz" +
           "c2FnZQEBuDoALgBEuDoAAAAV/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5AQG5OgAu" +
           "AES5OgAAAAX/////AQH/////AAAAABVgiQoCAAAAAQARAAAAUG9zaXRpb25PZkJsaW5rZXIBAbo6AC4A" +
           "RLo6AAAADP////8BAf////8AAAAABGCACgEAAAABAA8AAABMZWZ0QmxpbmtlcnNPZmYBAdw6AC8BAdE6" +
           "3DoAAP////8JAAAAFWCJCgIAAAAAAAcAAABFdmVudElkAQHdOgAuAETdOgAAAA//////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAJAAAARXZlbnRUeXBlAQHeOgAuAETeOgAAABH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAKAAAAU291cmNlTm9kZQEB3zoALgBE3zoAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNv" +
           "dXJjZU5hbWUBAeA6AC4AROA6AAAADP////8BAf////8AAAAAFWCJCgIAAAAAAAQAAABUaW1lAQHhOgAu" +
           "AEThOgAAAQAmAf////8BAf////8AAAAAFWCJCgIAAAAAAAsAAABSZWNlaXZlVGltZQEB4joALgBE4joA" +
           "AAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAHAAAATWVzc2FnZQEB5DoALgBE5DoAAAAV/////wEB" +
           "/////wAAAAAVYIkKAgAAAAAACAAAAFNldmVyaXR5AQHlOgAuAETlOgAAAAX/////AQH/////AAAAABVg" +
           "iQoCAAAAAQARAAAAUG9zaXRpb25PZkJsaW5rZXIBAeY6AC4AROY6AAAADP////8BAf////8AAAAAhGDA" +
           "CgEAAAAMAAAAUmlnaHRCbGlua2VyAQANAAAAUmlnaHQgQmxpbmtlcgEBnjoALwEBmzqeOgAAAf////8A" +
           "AAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CarBlinkerState LeftBlinker
        {
            get
            {
                return m_leftBlinker;
            }

            set
            {
                if (!Object.ReferenceEquals(m_leftBlinker, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_leftBlinker = value;
            }
        }

        /// <remarks />
        public CarBlinkerState RightBlinker
        {
            get
            {
                return m_rightBlinker;
            }

            set
            {
                if (!Object.ReferenceEquals(m_rightBlinker, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_rightBlinker = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_leftBlinker != null)
            {
                children.Add(m_leftBlinker);
            }

            if (m_rightBlinker != null)
            {
                children.Add(m_rightBlinker);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case buzzfrog.OpcAlarmServer.BrowseNames.LeftBlinker:
                {
                    if (createOrReplace)
                    {
                        if (LeftBlinker == null)
                        {
                            if (replacement == null)
                            {
                                LeftBlinker = new CarBlinkerState(this);
                            }
                            else
                            {
                                LeftBlinker = (CarBlinkerState)replacement;
                            }
                        }
                    }

                    instance = LeftBlinker;
                    break;
                }

                case buzzfrog.OpcAlarmServer.BrowseNames.RightBlinker:
                {
                    if (createOrReplace)
                    {
                        if (RightBlinker == null)
                        {
                            if (replacement == null)
                            {
                                RightBlinker = new CarBlinkerState(this);
                            }
                            else
                            {
                                RightBlinker = (CarBlinkerState)replacement;
                            }
                        }
                    }

                    instance = RightBlinker;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private CarBlinkerState m_leftBlinker;
        private CarBlinkerState m_rightBlinker;
        #endregion
    }
    #endif
    #endregion

    #region CarState Class
    #if (!OPCUA_EXCLUDE_CarState)
    /// <summary>
    /// Stores an instance of the CarType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CarState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CarState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(buzzfrog.OpcAlarmServer.ObjectTypes.CarType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACEAAABodHRwOi8vYnV6emZyb2cuc2UvT3BjQWxhcm1TZXJ2ZXL/////BGCAAgEAAAABAA8AAABD" +
           "YXJUeXBlSW5zdGFuY2UBAZk6AQGZOpk6AAD/////AgAAAIRggAoBAAAAAQAIAAAAQmxpbmtlcnMBAZ86" +
           "AC8BAZw6nzoAAAH/////AgAAAIRgwAoBAAAACwAAAExlZnRCbGlua2VyAQAMAAAATGVmdCBCbGlua2Vy" +
           "AQGgOgAvAQGbOqA6AAAB/////wIAAAAEYIAKAQAAAAEADgAAAExlZnRCbGlua2Vyc09uAQG7OgAvAQGl" +
           "Ors6AAD/////CQAAABVgiQoCAAAAAAAHAAAARXZlbnRJZAEBvDoALgBEvDoAAAAP/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAACQAAAEV2ZW50VHlwZQEBvToALgBEvToAAAAR/////wEB/////wAAAAAVYIkKAgAA" +
           "AAAACgAAAFNvdXJjZU5vZGUBAb46AC4ARL46AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABT" +
           "b3VyY2VOYW1lAQG/OgAuAES/OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEBwDoA" +
           "LgBEwDoAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAcE6AC4ARME6" +
           "AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAAAE1lc3NhZ2UBAcM6AC4ARMM6AAAAFf////8B" +
           "Af////8AAAAAFWCJCgIAAAAAAAgAAABTZXZlcml0eQEBxDoALgBExDoAAAAF/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEAEQAAAFBvc2l0aW9uT2ZCbGlua2VyAQHFOgAuAETFOgAAAAz/////AQH/////AAAAAARg" +
           "gAoBAAAAAQAPAAAATGVmdEJsaW5rZXJzT2ZmAQHnOgAvAQHROuc6AAD/////CQAAABVgiQoCAAAAAAAH" +
           "AAAARXZlbnRJZAEB6DoALgBE6DoAAAAP/////wEB/////wAAAAAVYIkKAgAAAAAACQAAAEV2ZW50VHlw" +
           "ZQEB6ToALgBE6ToAAAAR/////wEB/////wAAAAAVYIkKAgAAAAAACgAAAFNvdXJjZU5vZGUBAeo6AC4A" +
           "ROo6AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABTb3VyY2VOYW1lAQHrOgAuAETrOgAAAAz/" +
           "////AQH/////AAAAABVgiQoCAAAAAAAEAAAAVGltZQEB7DoALgBE7DoAAAEAJgH/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAALAAAAUmVjZWl2ZVRpbWUBAe06AC4ARO06AAABACYB/////wEB/////wAAAAAVYIkK" +
           "AgAAAAAABwAAAE1lc3NhZ2UBAe86AC4ARO86AAAAFf////8BAf////8AAAAAFWCJCgIAAAAAAAgAAABT" +
           "ZXZlcml0eQEB8DoALgBE8DoAAAAF/////wEB/////wAAAAAVYIkKAgAAAAEAEQAAAFBvc2l0aW9uT2ZC" +
           "bGlua2VyAQHxOgAuAETxOgAAAAz/////AQH/////AAAAAIRgwAoBAAAADAAAAFJpZ2h0QmxpbmtlcgEA" +
           "DQAAAFJpZ2h0IEJsaW5rZXIBAaE6AC8BAZs6oToAAAH/////AAAAAARggAoBAAAAAQAEAAAAVGFuawEB" +
           "/zoALwEB/Tr/OgAA/////wIAAAAVYIkKAgAAAAEACQAAAFRhbmtMZXZlbAEBADsALwA/ADsAAAAL////" +
           "/wEB/////wAAAAAEYIAKAQAAAAEAEgAAAFRhbmtMZXZlbENvbmRpdGlvbgEBUTsALwEBKDtROwAA////" +
           "/xUAAAAVYIkKAgAAAAAABwAAAEV2ZW50SWQBAVI7AC4ARFI7AAAAD/////8BAf////8AAAAAFWCJCgIA" +
           "AAAAAAkAAABFdmVudFR5cGUBAVM7AC4ARFM7AAAAEf////8BAf////8AAAAAFWCJCgIAAAAAAAoAAABT" +
           "b3VyY2VOb2RlAQFUOwAuAERUOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAKAAAAU291cmNlTmFt" +
           "ZQEBVTsALgBEVTsAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAABAAAAFRpbWUBAVY7AC4ARFY7AAAB" +
           "ACYB/////wEB/////wAAAAAVYIkKAgAAAAAACwAAAFJlY2VpdmVUaW1lAQFXOwAuAERXOwAAAQAmAf//" +
           "//8BAf////8AAAAAFWCJCgIAAAAAAAcAAABNZXNzYWdlAQFZOwAuAERZOwAAABX/////AQH/////AAAA" +
           "ABVgiQoCAAAAAAAIAAAAU2V2ZXJpdHkBAVo7AC4ARFo7AAAABf////8BAf////8AAAAAFWCJCgIAAAAA" +
           "ABAAAABDb25kaXRpb25DbGFzc0lkAQFbOwAuAERbOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAS" +
           "AAAAQ29uZGl0aW9uQ2xhc3NOYW1lAQFcOwAuAERcOwAAABX/////AQH/////AAAAABVgiQoCAAAAAAAN" +
           "AAAAQ29uZGl0aW9uTmFtZQEBXzsALgBEXzsAAAAM/////wEB/////wAAAAAVYIkKAgAAAAAACAAAAEJy" +
           "YW5jaElkAQFgOwAuAERgOwAAABH/////AQH/////AAAAABVgiQoCAAAAAAAGAAAAUmV0YWluAQFhOwAu" +
           "AERhOwAAAAH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAARW5hYmxlZFN0YXRlAQFiOwAvAQAjI2I7" +
           "AAAAFf////8BAf////8BAAAAFWCJCgIAAAAAAAIAAABJZAEBYzsALgBEYzsAAAAB/////wEB/////wAA" +
           "AAAVYIkKAgAAAAAABwAAAFF1YWxpdHkBAWs7AC8BACojazsAAAAT/////wEB/////wEAAAAVYIkKAgAA" +
           "AAAADwAAAFNvdXJjZVRpbWVzdGFtcAEBbDsALgBEbDsAAAEAJgH/////AQH/////AAAAABVgiQoCAAAA" +
           "AAAMAAAATGFzdFNldmVyaXR5AQFtOwAvAQAqI207AAAABf////8BAf////8BAAAAFWCJCgIAAAAAAA8A" +
           "AABTb3VyY2VUaW1lc3RhbXABAW47AC4ARG47AAABACYB/////wEB/////wAAAAAVYIkKAgAAAAAABwAA" +
           "AENvbW1lbnQBAW87AC8BACojbzsAAAAV/////wEB/////wEAAAAVYIkKAgAAAAAADwAAAFNvdXJjZVRp" +
           "bWVzdGFtcAEBcDsALgBEcDsAAAEAJgH/////AQH/////AAAAABVgiQoCAAAAAAAMAAAAQ2xpZW50VXNl" +
           "cklkAQFxOwAuAERxOwAAAAz/////AQH/////AAAAAARhggoEAAAAAAAHAAAARGlzYWJsZQEBcjsALwEA" +
           "RCNyOwAAAQEBAAAAAQD5CwABAPMKAAAAAARhggoEAAAAAAAGAAAARW5hYmxlAQFzOwAvAQBDI3M7AAAB" +
           "AQEAAAABAPkLAAEA8woAAAAABGGCCgQAAAAAAAoAAABBZGRDb21tZW50AQF0OwAvAQBFI3Q7AAABAQEA" +
           "AAABAPkLAAEADQsBAAAAF2CpCgIAAAAAAA4AAABJbnB1dEFyZ3VtZW50cwEBdTsALgBEdTsAAJYCAAAA" +
           "AQAqAQFGAAAABwAAAEV2ZW50SWQAD/////8AAAAAAwAAAAAoAAAAVGhlIGlkZW50aWZpZXIgZm9yIHRo" +
           "ZSBldmVudCB0byBjb21tZW50LgEAKgEBQgAAAAcAAABDb21tZW50ABX/////AAAAAAMAAAAAJAAAAFRo" +
           "ZSBjb21tZW50IHRvIGFkZCB0byB0aGUgY29uZGl0aW9uLgEAKAEBAAAAAQAAAAAAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public CarBlinkersState Blinkers
        {
            get
            {
                return m_blinkers;
            }

            set
            {
                if (!Object.ReferenceEquals(m_blinkers, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_blinkers = value;
            }
        }

        /// <remarks />
        public TankState Tank
        {
            get
            {
                return m_tank;
            }

            set
            {
                if (!Object.ReferenceEquals(m_tank, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_tank = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_blinkers != null)
            {
                children.Add(m_blinkers);
            }

            if (m_tank != null)
            {
                children.Add(m_tank);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case buzzfrog.OpcAlarmServer.BrowseNames.Blinkers:
                {
                    if (createOrReplace)
                    {
                        if (Blinkers == null)
                        {
                            if (replacement == null)
                            {
                                Blinkers = new CarBlinkersState(this);
                            }
                            else
                            {
                                Blinkers = (CarBlinkersState)replacement;
                            }
                        }
                    }

                    instance = Blinkers;
                    break;
                }

                case buzzfrog.OpcAlarmServer.BrowseNames.Tank:
                {
                    if (createOrReplace)
                    {
                        if (Tank == null)
                        {
                            if (replacement == null)
                            {
                                Tank = new TankState(this);
                            }
                            else
                            {
                                Tank = (TankState)replacement;
                            }
                        }
                    }

                    instance = Tank;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private CarBlinkersState m_blinkers;
        private TankState m_tank;
        #endregion
    }
    #endif
    #endregion
}