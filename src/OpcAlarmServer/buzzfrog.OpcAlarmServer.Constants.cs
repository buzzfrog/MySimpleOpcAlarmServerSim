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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace buzzfrog.OpcAlarmServer
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Disable Method.
        /// </summary>
        public const uint TankType_TankLevelCondition_Disable = 15140;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Enable Method.
        /// </summary>
        public const uint TankType_TankLevelCondition_Enable = 15141;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_AddComment Method.
        /// </summary>
        public const uint TankType_TankLevelCondition_AddComment = 15142;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Disable Method.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Disable = 15218;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Enable Method.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Enable = 15219;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_AddComment Method.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_AddComment = 15220;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Disable Method.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Disable = 15255;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Enable Method.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Enable = 15256;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_AddComment Method.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_AddComment = 15257;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Disable Method.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Disable = 15320;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Enable Method.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Enable = 15321;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_AddComment Method.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_AddComment = 15322;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the TankType_TankLevelCondition Object.
        /// </summary>
        public const uint TankType_TankLevelCondition = 15107;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker Object.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker = 15005;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn Object.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn = 15024;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff Object.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff = 15068;

        /// <summary>
        /// The identifier for the CarBlinkersType_RightBlinker Object.
        /// </summary>
        public const uint CarBlinkersType_RightBlinker = 15006;

        /// <summary>
        /// The identifier for the CarType_Blinkers Object.
        /// </summary>
        public const uint CarType_Blinkers = 15007;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker Object.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker = 15008;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn Object.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn = 15035;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff Object.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff = 15079;

        /// <summary>
        /// The identifier for the CarType_Blinkers_RightBlinker Object.
        /// </summary>
        public const uint CarType_Blinkers_RightBlinker = 15009;

        /// <summary>
        /// The identifier for the CarType_Tank Object.
        /// </summary>
        public const uint CarType_Tank = 15103;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition Object.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition = 15185;

        /// <summary>
        /// The identifier for the Car1 Object.
        /// </summary>
        public const uint Car1 = 15002;

        /// <summary>
        /// The identifier for the Car1_Blinkers Object.
        /// </summary>
        public const uint Car1_Blinkers = 15010;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker Object.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker = 15011;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn Object.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn = 15046;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff Object.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff = 15090;

        /// <summary>
        /// The identifier for the Car1_Blinkers_RightBlinker Object.
        /// </summary>
        public const uint Car1_Blinkers_RightBlinker = 15012;

        /// <summary>
        /// The identifier for the Car1_Tank Object.
        /// </summary>
        public const uint Car1_Tank = 15105;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition Object.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition = 15222;

        /// <summary>
        /// The identifier for the Car2 Object.
        /// </summary>
        public const uint Car2 = 15259;

        /// <summary>
        /// The identifier for the Car2_Blinkers Object.
        /// </summary>
        public const uint Car2_Blinkers = 15260;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker Object.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker = 15261;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn Object.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn = 15262;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff Object.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff = 15273;

        /// <summary>
        /// The identifier for the Car2_Blinkers_RightBlinker Object.
        /// </summary>
        public const uint Car2_Blinkers_RightBlinker = 15284;

        /// <summary>
        /// The identifier for the Car2_Tank Object.
        /// </summary>
        public const uint Car2_Tank = 15285;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition Object.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition = 15287;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the TankType ObjectType.
        /// </summary>
        public const uint TankType = 15101;

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType ObjectType.
        /// </summary>
        public const uint LessThan5LiterInTankConditionType = 15144;

        /// <summary>
        /// The identifier for the BlinkersOnEventType ObjectType.
        /// </summary>
        public const uint BlinkersOnEventType = 15013;

        /// <summary>
        /// The identifier for the BlinkersOffEventType ObjectType.
        /// </summary>
        public const uint BlinkersOffEventType = 15057;

        /// <summary>
        /// The identifier for the CarBlinkerType ObjectType.
        /// </summary>
        public const uint CarBlinkerType = 15003;

        /// <summary>
        /// The identifier for the CarBlinkersType ObjectType.
        /// </summary>
        public const uint CarBlinkersType = 15004;

        /// <summary>
        /// The identifier for the CarType ObjectType.
        /// </summary>
        public const uint CarType = 15001;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the TankType_TankLevel Variable.
        /// </summary>
        public const uint TankType_TankLevel = 15102;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_EventId Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_EventId = 15108;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_EventType Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_EventType = 15109;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_SourceNode Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_SourceNode = 15110;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_SourceName Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_SourceName = 15111;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Time Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_Time = 15112;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ReceiveTime Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_ReceiveTime = 15113;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Message Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_Message = 15115;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Severity Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_Severity = 15116;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ConditionClassId Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_ConditionClassId = 15117;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ConditionClassName Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_ConditionClassName = 15118;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ConditionName Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_ConditionName = 15121;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_BranchId Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_BranchId = 15122;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Retain Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_Retain = 15123;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_EnabledState Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_EnabledState = 15124;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_EnabledState_Id Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_EnabledState_Id = 15125;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Quality Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_Quality = 15133;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_Quality_SourceTimestamp = 15134;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_LastSeverity Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_LastSeverity = 15135;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_LastSeverity_SourceTimestamp = 15136;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Comment Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_Comment = 15137;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_Comment_SourceTimestamp = 15138;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ClientUserId Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_ClientUserId = 15139;

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_AddComment_InputArguments Variable.
        /// </summary>
        public const uint TankType_TankLevelCondition_AddComment_InputArguments = 15143;

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_EnabledState_Id Variable.
        /// </summary>
        public const uint LessThan5LiterInTankConditionType_EnabledState_Id = 15162;

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint LessThan5LiterInTankConditionType_Quality_SourceTimestamp = 15171;

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint LessThan5LiterInTankConditionType_LastSeverity_SourceTimestamp = 15173;

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint LessThan5LiterInTankConditionType_Comment_SourceTimestamp = 15175;

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public const uint LessThan5LiterInTankConditionType_AddComment_InputArguments = 15180;

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public const uint LessThan5LiterInTankConditionType_ConditionRefresh_InputArguments = 15182;

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public const uint LessThan5LiterInTankConditionType_ConditionRefresh2_InputArguments = 15184;

        /// <summary>
        /// The identifier for the BlinkersOnEventType_PositionOfBlinker Variable.
        /// </summary>
        public const uint BlinkersOnEventType_PositionOfBlinker = 15023;

        /// <summary>
        /// The identifier for the BlinkersOffEventType_PositionOfBlinker Variable.
        /// </summary>
        public const uint BlinkersOffEventType_PositionOfBlinker = 15067;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventId Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventId = 15025;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventType Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventType = 15026;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceNode Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceNode = 15027;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceName Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceName = 15028;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_Time Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_Time = 15029;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_ReceiveTime Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_ReceiveTime = 15030;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_Message Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_Message = 15032;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_Severity Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_Severity = 15033;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_PositionOfBlinker Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOn_PositionOfBlinker = 15034;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventId Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventId = 15069;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventType Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventType = 15070;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceNode Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceNode = 15071;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceName Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceName = 15072;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_Time Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_Time = 15073;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_ReceiveTime Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_ReceiveTime = 15074;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_Message Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_Message = 15076;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_Severity Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_Severity = 15077;

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_PositionOfBlinker Variable.
        /// </summary>
        public const uint CarBlinkersType_LeftBlinker_LeftBlinkersOff_PositionOfBlinker = 15078;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventId Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventId = 15036;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventType Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventType = 15037;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode = 15038;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName = 15039;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Time Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Time = 15040;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime = 15041;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Message Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Message = 15043;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Severity Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Severity = 15044;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker = 15045;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventId Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventId = 15080;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventType Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventType = 15081;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode = 15082;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName = 15083;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Time Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Time = 15084;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime = 15085;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Message Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Message = 15087;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Severity Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Severity = 15088;

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker Variable.
        /// </summary>
        public const uint CarType_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker = 15089;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevel Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevel = 15104;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_EventId Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_EventId = 15186;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_EventType Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_EventType = 15187;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_SourceNode Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_SourceNode = 15188;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_SourceName Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_SourceName = 15189;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Time Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Time = 15190;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ReceiveTime Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_ReceiveTime = 15191;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Message Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Message = 15193;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Severity Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Severity = 15194;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ConditionClassId Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_ConditionClassId = 15195;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ConditionClassName Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_ConditionClassName = 15196;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ConditionName Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_ConditionName = 15199;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_BranchId Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_BranchId = 15200;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Retain Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Retain = 15201;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_EnabledState Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_EnabledState = 15202;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_EnabledState_Id Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_EnabledState_Id = 15203;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Quality Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Quality = 15211;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Quality_SourceTimestamp = 15212;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_LastSeverity Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_LastSeverity = 15213;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_LastSeverity_SourceTimestamp = 15214;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Comment Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Comment = 15215;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_Comment_SourceTimestamp = 15216;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ClientUserId Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_ClientUserId = 15217;

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_AddComment_InputArguments Variable.
        /// </summary>
        public const uint CarType_Tank_TankLevelCondition_AddComment_InputArguments = 15221;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventId Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventId = 15047;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventType Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventType = 15048;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode = 15049;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName = 15050;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Time Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Time = 15051;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime = 15052;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Message Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Message = 15054;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Severity Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Severity = 15055;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker = 15056;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventId Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventId = 15091;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventType Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventType = 15092;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode = 15093;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName = 15094;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Time Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Time = 15095;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime = 15096;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Message Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Message = 15098;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Severity Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Severity = 15099;

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker Variable.
        /// </summary>
        public const uint Car1_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker = 15100;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevel Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevel = 15106;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_EventId Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_EventId = 15223;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_EventType Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_EventType = 15224;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_SourceNode Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_SourceNode = 15225;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_SourceName Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_SourceName = 15226;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Time Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Time = 15227;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ReceiveTime Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_ReceiveTime = 15228;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Message Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Message = 15230;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Severity Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Severity = 15231;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ConditionClassId Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_ConditionClassId = 15232;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ConditionClassName Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_ConditionClassName = 15233;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ConditionName Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_ConditionName = 15236;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_BranchId Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_BranchId = 15237;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Retain Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Retain = 15238;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_EnabledState Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_EnabledState = 15239;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_EnabledState_Id Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_EnabledState_Id = 15240;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Quality Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Quality = 15248;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Quality_SourceTimestamp = 15249;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_LastSeverity Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_LastSeverity = 15250;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_LastSeverity_SourceTimestamp = 15251;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Comment Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Comment = 15252;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_Comment_SourceTimestamp = 15253;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ClientUserId Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_ClientUserId = 15254;

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Car1_Tank_TankLevelCondition_AddComment_InputArguments = 15258;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventId Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventId = 15263;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventType Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventType = 15264;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode = 15265;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName = 15266;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Time Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Time = 15267;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime = 15268;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Message Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Message = 15270;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Severity Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Severity = 15271;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker = 15272;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventId Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventId = 15274;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventType Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventType = 15275;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode = 15276;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName = 15277;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Time Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Time = 15278;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime = 15279;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Message Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Message = 15281;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Severity Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Severity = 15282;

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker Variable.
        /// </summary>
        public const uint Car2_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker = 15283;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevel Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevel = 15286;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_EventId Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_EventId = 15288;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_EventType Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_EventType = 15289;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_SourceNode Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_SourceNode = 15290;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_SourceName Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_SourceName = 15291;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Time Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Time = 15292;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ReceiveTime Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_ReceiveTime = 15293;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Message Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Message = 15295;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Severity Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Severity = 15296;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ConditionClassId Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_ConditionClassId = 15297;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ConditionClassName Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_ConditionClassName = 15298;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ConditionName Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_ConditionName = 15301;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_BranchId Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_BranchId = 15302;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Retain Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Retain = 15303;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_EnabledState Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_EnabledState = 15304;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_EnabledState_Id Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_EnabledState_Id = 15305;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Quality Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Quality = 15313;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Quality_SourceTimestamp = 15314;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_LastSeverity Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_LastSeverity = 15315;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_LastSeverity_SourceTimestamp = 15316;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Comment Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Comment = 15317;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_Comment_SourceTimestamp = 15318;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ClientUserId Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_ClientUserId = 15319;

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Car2_Tank_TankLevelCondition_AddComment_InputArguments = 15323;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Disable = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.TankType_TankLevelCondition_Disable, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Enable = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.TankType_TankLevelCondition_Enable, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_AddComment = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.TankType_TankLevelCondition_AddComment, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Disable = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.CarType_Tank_TankLevelCondition_Disable, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Enable = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.CarType_Tank_TankLevelCondition_Enable, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_AddComment = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.CarType_Tank_TankLevelCondition_AddComment, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Disable = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.Car1_Tank_TankLevelCondition_Disable, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Enable = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.Car1_Tank_TankLevelCondition_Enable, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_AddComment = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.Car1_Tank_TankLevelCondition_AddComment, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Disable = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.Car2_Tank_TankLevelCondition_Disable, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Enable = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.Car2_Tank_TankLevelCondition_Enable, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_AddComment = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Methods.Car2_Tank_TankLevelCondition_AddComment, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the TankType_TankLevelCondition Object.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.TankType_TankLevelCondition, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker Object.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarBlinkersType_LeftBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn Object.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarBlinkersType_LeftBlinker_LeftBlinkersOn, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff Object.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarBlinkersType_LeftBlinker_LeftBlinkersOff, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_RightBlinker Object.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_RightBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarBlinkersType_RightBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers Object.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarType_Blinkers, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker Object.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarType_Blinkers_LeftBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn Object.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarType_Blinkers_LeftBlinker_LeftBlinkersOn, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff Object.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarType_Blinkers_LeftBlinker_LeftBlinkersOff, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_RightBlinker Object.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_RightBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarType_Blinkers_RightBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank Object.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarType_Tank, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition Object.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.CarType_Tank_TankLevelCondition, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Car1 = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car1, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers Object.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car1_Blinkers, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker Object.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car1_Blinkers_LeftBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn Object.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car1_Blinkers_LeftBlinker_LeftBlinkersOn, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff Object.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car1_Blinkers_LeftBlinker_LeftBlinkersOff, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_RightBlinker Object.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_RightBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car1_Blinkers_RightBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank Object.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car1_Tank, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition Object.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car1_Tank_TankLevelCondition, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2 Object.
        /// </summary>
        public static readonly ExpandedNodeId Car2 = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car2, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers Object.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car2_Blinkers, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker Object.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car2_Blinkers_LeftBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn Object.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car2_Blinkers_LeftBlinker_LeftBlinkersOn, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff Object.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car2_Blinkers_LeftBlinker_LeftBlinkersOff, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_RightBlinker Object.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_RightBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car2_Blinkers_RightBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank Object.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car2_Tank, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition Object.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Objects.Car2_Tank_TankLevelCondition, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the TankType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TankType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.ObjectTypes.TankType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LessThan5LiterInTankConditionType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.ObjectTypes.LessThan5LiterInTankConditionType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the BlinkersOnEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BlinkersOnEventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.ObjectTypes.BlinkersOnEventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the BlinkersOffEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BlinkersOffEventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.ObjectTypes.BlinkersOffEventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkerType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.ObjectTypes.CarBlinkerType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.ObjectTypes.CarBlinkersType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CarType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.ObjectTypes.CarType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the TankType_TankLevel Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevel = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevel, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_ConditionClassId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_ConditionClassId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_ConditionClassName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_ConditionClassName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_ConditionName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_ConditionName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_BranchId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_BranchId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Retain = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_Retain, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_EnabledState = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_EnabledState, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_EnabledState_Id = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_EnabledState_Id, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Quality = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_Quality, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Quality_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_Quality_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_LastSeverity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_LastSeverity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_LastSeverity_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_LastSeverity_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Comment = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_Comment, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_Comment_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_Comment_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_ClientUserId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_ClientUserId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the TankType_TankLevelCondition_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TankType_TankLevelCondition_AddComment_InputArguments = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.TankType_TankLevelCondition_AddComment_InputArguments, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId LessThan5LiterInTankConditionType_EnabledState_Id = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.LessThan5LiterInTankConditionType_EnabledState_Id, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId LessThan5LiterInTankConditionType_Quality_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.LessThan5LiterInTankConditionType_Quality_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId LessThan5LiterInTankConditionType_LastSeverity_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.LessThan5LiterInTankConditionType_LastSeverity_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId LessThan5LiterInTankConditionType_Comment_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.LessThan5LiterInTankConditionType_Comment_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LessThan5LiterInTankConditionType_AddComment_InputArguments = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.LessThan5LiterInTankConditionType_AddComment_InputArguments, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_ConditionRefresh_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LessThan5LiterInTankConditionType_ConditionRefresh_InputArguments = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.LessThan5LiterInTankConditionType_ConditionRefresh_InputArguments, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the LessThan5LiterInTankConditionType_ConditionRefresh2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId LessThan5LiterInTankConditionType_ConditionRefresh2_InputArguments = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.LessThan5LiterInTankConditionType_ConditionRefresh2_InputArguments, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the BlinkersOnEventType_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlinkersOnEventType_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.BlinkersOnEventType_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the BlinkersOffEventType_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId BlinkersOffEventType_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.BlinkersOffEventType_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOn_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOn_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOn_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarBlinkersType_LeftBlinker_LeftBlinkersOff_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarBlinkersType_LeftBlinker_LeftBlinkersOff_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarBlinkersType_LeftBlinker_LeftBlinkersOff_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevel Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevel = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevel, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_ConditionClassId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_ConditionClassId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_ConditionClassName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_ConditionClassName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_ConditionName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_ConditionName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_BranchId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_BranchId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Retain = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_Retain, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_EnabledState = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_EnabledState, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_EnabledState_Id = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_EnabledState_Id, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Quality = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_Quality, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Quality_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_Quality_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_LastSeverity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_LastSeverity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_LastSeverity_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_LastSeverity_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Comment = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_Comment, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_Comment_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_Comment_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_ClientUserId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_ClientUserId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the CarType_Tank_TankLevelCondition_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId CarType_Tank_TankLevelCondition_AddComment_InputArguments = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.CarType_Tank_TankLevelCondition_AddComment_InputArguments, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevel Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevel = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevel, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_ConditionClassId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_ConditionClassId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_ConditionClassName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_ConditionClassName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_ConditionName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_ConditionName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_BranchId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_BranchId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Retain = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_Retain, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_EnabledState = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_EnabledState, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_EnabledState_Id = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_EnabledState_Id, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Quality = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_Quality, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Quality_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_Quality_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_LastSeverity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_LastSeverity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_LastSeverity_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_LastSeverity_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Comment = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_Comment, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_Comment_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_Comment_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_ClientUserId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_ClientUserId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car1_Tank_TankLevelCondition_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car1_Tank_TankLevelCondition_AddComment_InputArguments = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car1_Tank_TankLevelCondition_AddComment_InputArguments, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOn_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Blinkers_LeftBlinker_LeftBlinkersOff_PositionOfBlinker, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevel Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevel = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevel, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_EventId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_EventId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_EventType = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_EventType, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_SourceNode = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_SourceNode, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_SourceName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_SourceName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Time = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_Time, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_ReceiveTime = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_ReceiveTime, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Message = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_Message, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Severity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_Severity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_ConditionClassId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_ConditionClassId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_ConditionClassName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_ConditionClassName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_ConditionName = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_ConditionName, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_BranchId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_BranchId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Retain = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_Retain, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_EnabledState = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_EnabledState, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_EnabledState_Id = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_EnabledState_Id, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Quality = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_Quality, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Quality_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_Quality_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_LastSeverity = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_LastSeverity, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_LastSeverity_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_LastSeverity_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Comment = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_Comment, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_Comment_SourceTimestamp = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_Comment_SourceTimestamp, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_ClientUserId = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_ClientUserId, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);

        /// <summary>
        /// The identifier for the Car2_Tank_TankLevelCondition_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Car2_Tank_TankLevelCondition_AddComment_InputArguments = new ExpandedNodeId(buzzfrog.OpcAlarmServer.Variables.Car2_Tank_TankLevelCondition_AddComment_InputArguments, buzzfrog.OpcAlarmServer.Namespaces.OpcAlarmServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the Blinkers component.
        /// </summary>
        public const string Blinkers = "Blinkers";

        /// <summary>
        /// The BrowseName for the BlinkersOffEventType component.
        /// </summary>
        public const string BlinkersOffEventType = "BlinkersOffEventType";

        /// <summary>
        /// The BrowseName for the BlinkersOnEventType component.
        /// </summary>
        public const string BlinkersOnEventType = "BlinkersOnEventType";

        /// <summary>
        /// The BrowseName for the Car1 component.
        /// </summary>
        public const string Car1 = "Car #1";

        /// <summary>
        /// The BrowseName for the Car2 component.
        /// </summary>
        public const string Car2 = "Car #2";

        /// <summary>
        /// The BrowseName for the CarBlinkersType component.
        /// </summary>
        public const string CarBlinkersType = "CarBlinkersType";

        /// <summary>
        /// The BrowseName for the CarBlinkerType component.
        /// </summary>
        public const string CarBlinkerType = "CarBlinkerType";

        /// <summary>
        /// The BrowseName for the CarType component.
        /// </summary>
        public const string CarType = "CarType";

        /// <summary>
        /// The BrowseName for the LeftBlinker component.
        /// </summary>
        public const string LeftBlinker = "Left Blinker";

        /// <summary>
        /// The BrowseName for the LessThan5LiterInTankConditionType component.
        /// </summary>
        public const string LessThan5LiterInTankConditionType = "LessThan5LiterInTankConditionType";

        /// <summary>
        /// The BrowseName for the PositionOfBlinker component.
        /// </summary>
        public const string PositionOfBlinker = "PositionOfBlinker";

        /// <summary>
        /// The BrowseName for the RightBlinker component.
        /// </summary>
        public const string RightBlinker = "Right Blinker";

        /// <summary>
        /// The BrowseName for the Tank component.
        /// </summary>
        public const string Tank = "Tank";

        /// <summary>
        /// The BrowseName for the TankLevel component.
        /// </summary>
        public const string TankLevel = "TankLevel";

        /// <summary>
        /// The BrowseName for the TankLevelCondition component.
        /// </summary>
        public const string TankLevelCondition = "TankLevelCondition";

        /// <summary>
        /// The BrowseName for the TankType component.
        /// </summary>
        public const string TankType = "TankType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the OpcAlarmServer namespace (.NET code namespace is 'buzzfrog.OpcAlarmServer').
        /// </summary>
        public const string OpcAlarmServer = "http://buzzfrog.se/OpcAlarmServer";
    }
    #endregion
}