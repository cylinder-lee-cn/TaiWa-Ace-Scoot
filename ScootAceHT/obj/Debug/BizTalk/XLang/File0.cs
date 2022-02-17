
#pragma warning disable 162

namespace ScootAceHT
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SaveXMLFile",
        new System.Type[]{
            typeof(ScootAceHT.__messagetype_ScootAceHT_SchIssue2File)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_2File : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_2File(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_2File(PortType_2File p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_2File p = new PortType_2File(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SaveXMLFile = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SaveXMLFile",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_2File),
            typeof(__messagetype_ScootAceHT_SchIssue2File),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SaveXMLFile" ] = SaveXMLFile;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __ScootAceHT_SchIssueIn__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ScootAceHT.SchIssueIn _schema = new ScootAceHT.SchIssueIn();

        public __ScootAceHT_SchIssueIn__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ScootAceHT.SchIssueIn",
        new System.Type[]{
            typeof(ScootAceHT.SchIssueIn)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ScootAceHT_SchIssueIn__)
        },
        0,
        @"http://ScootAceHT.SchIssueIn.eTaiWa#ApplyForm"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ScootAceHT_SchIssueIn : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ScootAceHT_SchIssueIn__ part;

        private void __CreatePartWrappers()
        {
            part = new __ScootAceHT_SchIssueIn__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ScootAceHT_SchIssueIn(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __ScootAceHT_SchIssueResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ScootAceHT.SchIssueResponse _schema = new ScootAceHT.SchIssueResponse();

        public __ScootAceHT_SchIssueResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ScootAceHT.SchIssueResponse",
        new System.Type[]{
            typeof(ScootAceHT.SchIssueResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ScootAceHT_SchIssueResponse__)
        },
        0,
        @"http://ScootAceHT.SchIssueResponse#IssueResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ScootAceHT_SchIssueResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ScootAceHT_SchIssueResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __ScootAceHT_SchIssueResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ScootAceHT_SchIssueResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __ScootAceHT_SchSurrenderIn__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ScootAceHT.SchSurrenderIn _schema = new ScootAceHT.SchSurrenderIn();

        public __ScootAceHT_SchSurrenderIn__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ScootAceHT.SchSurrenderIn",
        new System.Type[]{
            typeof(ScootAceHT.SchSurrenderIn)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ScootAceHT_SchSurrenderIn__)
        },
        0,
        @"http://ScootAceHT.SchSurrenderIn#SurrenderForm"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ScootAceHT_SchSurrenderIn : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ScootAceHT_SchSurrenderIn__ part;

        private void __CreatePartWrappers()
        {
            part = new __ScootAceHT_SchSurrenderIn__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ScootAceHT_SchSurrenderIn(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __ScootAceHT_SchSurrenderResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ScootAceHT.SchSurrenderResponse _schema = new ScootAceHT.SchSurrenderResponse();

        public __ScootAceHT_SchSurrenderResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ScootAceHT.SchSurrenderResponse",
        new System.Type[]{
            typeof(ScootAceHT.SchSurrenderResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ScootAceHT_SchSurrenderResponse__)
        },
        0,
        @"http://ScootAceHT.SchSurrenderResponse#SurrenderResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ScootAceHT_SchSurrenderResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ScootAceHT_SchSurrenderResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __ScootAceHT_SchSurrenderResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ScootAceHT_SchSurrenderResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SendEmail",
        new System.Type[]{
            typeof(ScootAceHT.__messagetype_ScootAceHT_SchIssue2File)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_Email : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Email(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Email(PortType_Email p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Email p = new PortType_Email(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SendEmail = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SendEmail",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Email),
            typeof(__messagetype_ScootAceHT_SchIssue2File),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SendEmail" ] = SendEmail;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Apply",
        new System.Type[]{
            typeof(ScootAceHT.__messagetype_ScootAceHT_SchIssueIn), 
            typeof(ScootAceHT.__messagetype_ScootAceHT_SchIssueResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_Apply : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Apply(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Apply(PortType_Apply p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Apply p = new PortType_Apply(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Apply = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Apply",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Apply),
            typeof(__messagetype_ScootAceHT_SchIssueIn),
            typeof(__messagetype_ScootAceHT_SchIssueResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Apply" ] = Apply;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SaveXML",
        new System.Type[]{
            typeof(ScootAceHT.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_XmlFile : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_XmlFile(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_XmlFile(PortType_XmlFile p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_XmlFile p = new PortType_XmlFile(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SaveXML = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SaveXML",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_XmlFile),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SaveXML" ] = SaveXML;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Surrender",
        new System.Type[]{
            typeof(ScootAceHT.__messagetype_ScootAceHT_SchSurrenderIn)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SurrenderIn : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SurrenderIn(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SurrenderIn(PortType_SurrenderIn p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SurrenderIn p = new PortType_SurrenderIn(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Surrender = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Surrender",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SurrenderIn),
            typeof(__messagetype_ScootAceHT_SchSurrenderIn),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Surrender" ] = Surrender;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Surrender",
        new System.Type[]{
            typeof(ScootAceHT.__messagetype_ScootAceHT_SchSurrenderIn), 
            typeof(ScootAceHT.__messagetype_ScootAceHT_SchSurrenderResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_Surrender : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Surrender(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Surrender(PortType_Surrender p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Surrender p = new PortType_Surrender(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Surrender = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Surrender",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Surrender),
            typeof(__messagetype_ScootAceHT_SchSurrenderIn),
            typeof(__messagetype_ScootAceHT_SchSurrenderResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Surrender" ] = Surrender;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SurrenderFile",
        new System.Type[]{
            typeof(ScootAceHT.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SurrenderFile : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SurrenderFile(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SurrenderFile(PortType_SurrenderFile p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SurrenderFile p = new PortType_SurrenderFile(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SurrenderFile = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SurrenderFile",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SurrenderFile),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SurrenderFile" ] = SurrenderFile;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SurrenderEmail",
        new System.Type[]{
            typeof(ScootAceHT.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_SurrenderEmail : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SurrenderEmail(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SurrenderEmail(PortType_SurrenderEmail p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SurrenderEmail p = new PortType_SurrenderEmail(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SurrenderEmail = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SurrenderEmail",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_SurrenderEmail),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SurrenderEmail" ] = SurrenderEmail;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 412 "F:\Bts Projects\ScootAceHT\ScootAceHT\OrchApply.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_Apply", "Apply", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        },
        new System.Type[] {
            typeof(ScootAceHT.PortType_Apply),
            typeof(ScootAceHT.PortType_XmlFile),
            typeof(ScootAceHT.PortType_Email)
        },
        new System.String[] {
            "Port_Apply",
            "Port_XmlFile",
            "Port_Email"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class OrchApply : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(OrchApply));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static OrchApply()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 1;
            _rootContext = new __OrchApply_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public OrchApply(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "OrchApply", tracker)
        {
            ConstructorHelper();
        }

        public OrchApply(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "OrchApply")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>4ef6c3c5-dca0-497d-924a-0e8dbf683782</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>c76d0301-3435-4cbe-9d3e-b19dc48bad12</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_Apply</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>9eb8ceb2-b9b5-4fb5-af39-2e2e6d785c27</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>ConstructMessage_Apply</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>7fb2c34d-d567-4e9f-ad83-93e5afbb8dcc</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_Apply</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>7aa6a1e6-5210-474f-b876-0c27ae78c7dd</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3f26b13b-0757-46bc-a5c8-bdaea4c285a0</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f6db818a-8aac-4305-b673-b807ea2f5392</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>27502a83-7953-4681-8149-80d54b78f269</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_ChkUsrPwd</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>9e0f2a7f-ed94-440d-980b-607ec2435246</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_OK</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>4c526cb1-a015-4079-86db-541a25e275b3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_toFile</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>126854d6-e971-486f-9ce9-8b086f6d1dda</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_toFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>a665ff6c-562f-4a6f-bfe1-f1b1ca907999</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>2938c1ba-dd0f-4a17-bda2-07b136440724</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_2File</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ba7abf50-cd63-44db-9bed-a62dbcb8ef42</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_Email</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>7bec3624-aee2-486f-b9c4-9a2db096e029</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_Email</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>7e96fbf8-4e42-4c17-8443-4bfc8a010d44</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>43798253-e664-4540-9ccd-3eed3ce50b5a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_Email</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>2b9a1195-b66f-4612-9ae6-1174a61ecea6</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_IssueResponse</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>98025a8b-647b-4ae1-abe7-1a9d38dae5cd</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_IssueResponse</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>c23d48f6-0e66-4e37-8db7-43876956598b</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5d074134-46eb-4a26-bec7-48f916b2fa19</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>14b53f75-5d05-489d-bf82-ea62e188e603</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>3cd4a7d2-753f-4119-ac72-d37faf22099c</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>59c1455d-4dae-46da-a352-447cc24b2097</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_ApplyError</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>801b7cac-ce83-49c1-b95d-e6759ad23ca3</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_ApplyError</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a012e0df-b380-4f07-a5ed-eb96cf931806</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>0263e4cd-fed2-451e-b9d2-4d06a2e27e0b</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>c045fb2b-bafb-4f0d-960e-118e44b27a29</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7640d259-7815-4478-9d36-15ccaf678a2b</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_Out</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'OrchApply'</ActionName><IsAtomic>0</IsAtomic><Line>412</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>430</Line><Position>22</Position><ShapeID>'c76d0301-3435-4cbe-9d3e-b19dc48bad12'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_ApplyIn</name><part>part</part><schema>ScootAceHT.SchIssueIn</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>434</Line><Position>13</Position><ShapeID>'9eb8ceb2-b9b5-4fb5-af39-2e2e6d785c27'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_ApplyTrans</name><part>part</part><schema>ScootAceHT.SchIssue2File</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_ApplyIn</name><part>part</part><schema>ScootAceHT.SchIssueIn</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>440</Line><Position>13</Position><ShapeID>'27502a83-7953-4681-8149-80d54b78f269'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>444</Line><Position>17</Position><ShapeID>'4c526cb1-a015-4079-86db-541a25e275b3'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_XmlFile</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>465</Line><Position>17</Position><ShapeID>'2938c1ba-dd0f-4a17-bda2-07b136440724'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_XmlFile</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>467</Line><Position>17</Position><ShapeID>'ba7abf50-cd63-44db-9bed-a62dbcb8ef42'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_Email</name><part>part</part><schema>ScootAceHT.SchIssue2File</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>531</Line><Position>17</Position><ShapeID>'43798253-e664-4540-9ccd-3eed3ce50b5a'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_Email</name><part>part</part><schema>ScootAceHT.SchIssue2File</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>533</Line><Position>17</Position><ShapeID>'2b9a1195-b66f-4612-9ae6-1174a61ecea6'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_IssueResponse</name><part>part</part><schema>ScootAceHT.SchIssueResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_ApplyTrans</name><part>part</part><schema>ScootAceHT.SchIssue2File</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>542</Line><Position>17</Position><ShapeID>'59c1455d-4dae-46da-a352-447cc24b2097'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_IssueResponse</name><part>part</part><schema>ScootAceHT.SchIssueResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_ApplyTrans</name><part>part</part><schema>ScootAceHT.SchIssue2File</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>549</Line><Position>13</Position><ShapeID>'7640d259-7815-4478-9d36-15ccaf678a2b'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_IssueResponse</name><part>part</part><schema>ScootAceHT.SchIssueResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='de98c64e-acf7-4653-bc6e-a2cdd23063aa' LowerBound='1.1' HigherBound='174.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='ScootAceHT' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='53412d92-ae10-45ac-b311-ce4a5dd0a523' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_2File' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='3b3dd9b6-8fe0-4a11-879a-b27da1a57dd9' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SaveXMLFile' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='29d9f886-785c-4c38-b122-90cf8143777a' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.26'>
                    <om:Property Name='Ref' Value='ScootAceHT.SchIssue2File' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='7eec358a-fa9c-4fcf-86b0-c887d3843156' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Email' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='2cf2a7c3-5299-47c9-a6f7-9573feaaad0f' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendEmail' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='f7f61397-c443-4d54-9d60-8e808952f278' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.26'>
                    <om:Property Name='Ref' Value='ScootAceHT.SchIssue2File' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='2d389010-ecb7-4c9f-849f-c70fa1728767' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Apply' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='fcf3960e-2f9f-472c-8d0d-4ffe0e38fa74' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Apply' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='a2db5e5c-69ce-47fb-887c-91b42fb8d82d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.23'>
                    <om:Property Name='Ref' Value='ScootAceHT.SchIssueIn' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='e758e7d9-27ea-46c0-a014-220d0306f129' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='22.25' HigherBound='22.41'>
                    <om:Property Name='Ref' Value='ScootAceHT.SchIssueResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='8367cab1-6bb1-4234-aa47-b919b6a2d04d' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_XmlFile' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='28037d2d-e410-4dfa-8efd-04de38c777bc' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SaveXML' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='43b2e6ce-a9a1-4eaa-b176-af198172a413' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='ed593321-2a2a-4ffc-b141-4c54ea25a48c' ParentLink='Module_ServiceDeclaration' LowerBound='32.1' HigherBound='173.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrchApply' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='dafa5fc5-803f-4bec-86e3-b4a631d12887' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='VarEmail' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='e8ea22f9-32e9-4893-bc5a-21466c3106e0' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='47.1' HigherBound='48.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='VarString' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='fa944e45-4ab5-40d0-b787-4004c3a97aa7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='Type' Value='ScootAceHT.SchIssueIn' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_ApplyIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b180241f-4bae-4817-bee4-14254ebe7d4e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='ScootAceHT.SchIssue2File' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_ApplyTrans' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='83a4628d-d2db-42db-a263-de0c38e4ea4b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='ScootAceHT.SchIssue2File' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_Email' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6651dee0-f552-42ed-b088-c2e9c46ecc63' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='ScootAceHT.SchIssueResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_IssueResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c68992b9-a92a-4d2f-81fc-c1eceb4ac786' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_XmlFile' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='4ef6c3c5-dca0-497d-924a-0e8dbf683782' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='c76d0301-3435-4cbe-9d3e-b19dc48bad12' ParentLink='ServiceBody_Statement' LowerBound='50.1' HigherBound='54.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_Apply' />
                    <om:Property Name='MessageName' Value='Msg_ApplyIn' />
                    <om:Property Name='OperationName' Value='Apply' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_Apply' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Construct' OID='9eb8ceb2-b9b5-4fb5-af39-2e2e6d785c27' ParentLink='ServiceBody_Statement' LowerBound='54.1' HigherBound='60.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='ConstructMessage_Apply' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Transform' OID='7fb2c34d-d567-4e9f-ad83-93e5afbb8dcc' ParentLink='ComplexStatement_Statement' LowerBound='57.1' HigherBound='59.1'>
                        <om:Property Name='ClassName' Value='ScootAceHT.MapApplyIn2File' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Transform_Apply' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessagePartRef' OID='7aa6a1e6-5210-474f-b876-0c27ae78c7dd' ParentLink='Transform_InputMessagePartRef' LowerBound='58.74' HigherBound='58.85'>
                            <om:Property Name='MessageRef' Value='Msg_ApplyIn' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_1' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessagePartRef' OID='3f26b13b-0757-46bc-a5c8-bdaea4c285a0' ParentLink='Transform_OutputMessagePartRef' LowerBound='58.28' HigherBound='58.42'>
                            <om:Property Name='MessageRef' Value='Msg_ApplyTrans' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='MessagePartReference_2' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='MessageRef' OID='f6db818a-8aac-4305-b673-b807ea2f5392' ParentLink='Construct_MessageRef' LowerBound='55.23' HigherBound='55.37'>
                        <om:Property Name='Ref' Value='Msg_ApplyTrans' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Signal' Value='False' />
                    </om:Element>
                </om:Element>
                <om:Element Type='Decision' OID='27502a83-7953-4681-8149-80d54b78f269' ParentLink='ServiceBody_Statement' LowerBound='60.1' HigherBound='169.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_ChkUsrPwd' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='9e0f2a7f-ed94-440d-980b-607ec2435246' ParentLink='ReallyComplexStatement_Branch' LowerBound='61.13' HigherBound='160.1'>
                        <om:Property Name='Expression' Value='(Msg_ApplyTrans.SaleInfo.UserName == &quot;aceif&quot; &amp;&amp; Msg_ApplyTrans.SaleInfo.Password==&quot;ace.interface&quot;)&#xD;&#xA;&#xD;&#xA;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_OK' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='4c526cb1-a015-4079-86db-541a25e275b3' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='85.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_toFile' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='126854d6-e971-486f-9ce9-8b086f6d1dda' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='84.1'>
                                <om:Property Name='Expression' Value='//Remove ns0 and namesplace&#xD;&#xA;Msg_XmlFile=Msg_ApplyTrans;&#xD;&#xA;&#xD;&#xA;VarString=Msg_XmlFile.OuterXml;&#xD;&#xA;&#xD;&#xA;VarString= &quot;&lt;?xml version=\&quot;1.0\&quot; encoding=\&quot;UTF-8\&quot;?&gt;&quot; + VarString;&#xD;&#xA;//VarString= VarString.Replace(&quot;&lt;ns0:&quot;,&quot;&lt;&quot;);&#xD;&#xA;//VarString= VarString.Replace(&quot;xmlns:ns0=\&quot;http://ScootAceHT.SchIssue2File.eTaiWa\&quot;&quot;,&quot;&quot;);&#xD;&#xA;//VarString= VarString.Replace(&quot;&lt;/ns0:&quot;,&quot;&lt;/&quot;);&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;Msg_XmlFile.LoadXml(VarString);&#xD;&#xA;&#xD;&#xA;//Define filename as PolicyNo&#xD;&#xA;Msg_XmlFile(FILE.ReceivedFileName)=Msg_ApplyTrans.General.AceNo;&#xD;&#xA;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_toFile' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='a665ff6c-562f-4a6f-bfe1-f1b1ca907999' ParentLink='Construct_MessageRef' LowerBound='65.27' HigherBound='65.38'>
                                <om:Property Name='Ref' Value='Msg_XmlFile' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='2938c1ba-dd0f-4a17-bda2-07b136440724' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='87.1'>
                            <om:Property Name='PortName' Value='Port_XmlFile' />
                            <om:Property Name='MessageName' Value='Msg_XmlFile' />
                            <om:Property Name='OperationName' Value='SaveXML' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_2File' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='ba7abf50-cd63-44db-9bed-a62dbcb8ef42' ParentLink='ComplexStatement_Statement' LowerBound='87.1' HigherBound='151.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_Email' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='7bec3624-aee2-486f-b9c4-9a2db096e029' ParentLink='ComplexStatement_Statement' LowerBound='90.1' HigherBound='150.1'>
                                <om:Property Name='Expression' Value='//&#xD;&#xA;VarEmail =&#xD;&#xA;@&quot;&#xD;&#xA;感谢投保太桦保险。&#xD;&#xA;&#xD;&#xA;您的保单号码为[{0}]，请从以下地址下载电子保单；&#xD;&#xA;{1}&#xD;&#xA;&#xD;&#xA;了解保险详情，请查看保险条款 {2} 。&#xD;&#xA;&#xD;&#xA;如您需要进一步的协助， 请致电我们的客户服务专员热线：&#xD;&#xA;热线号码： 4006095509 （7*24小时）&#xD;&#xA;&#xD;&#xA;感谢您对太桦的信任和支持， 希望在今后能继续为您提供服务。&#xD;&#xA;&#xD;&#xA;请将以下号码存在您的手机上。24 小时紧急援助热线 +86 10 51295700&#xD;&#xA;当您在国外需要紧急援助或救援时并已经购买了太桦境外旅行人身意外伤害保险产品，请拨打此号码。 您可以告诉接线生由太桦支付这个电话费。 &#xD;&#xA;&#xD;&#xA;您真诚的&#xD;&#xA;太桦财产保险有限公司&#xD;&#xA;&#xD;&#xA;这是一个电脑自动生成的信函，请不要直接回复。&#xD;&#xA;&#xD;&#xA;Thank you for insuring with TaiWa.&#xD;&#xA;&#xD;&#xA;Your policy number is [{0}].  Please refer to this link to download the policy certificate: &#xD;&#xA;{1}&#xD;&#xA;&#xD;&#xA;For more information, please see the Policy Wording: {2} .  &#xD;&#xA;&#xD;&#xA;Should you require further assistance, please contact our friendly Customer Relations Officer at &#xD;&#xA;Hotline: 4006095509 (7 days*24-hour)&#xD;&#xA;&#xD;&#xA;Thank you for your trust and support in TaiWa, We look forward to serving you in future.&#xD;&#xA;&#xD;&#xA;Please save this number in your mobile phone.&#xD;&#xA;24 Hours Emergency Hotline: +86 10 51295700&#xD;&#xA;Please call when you are overseas and need assistance under the TaiWa Overseas Travel Insurance Plans.&#xD;&#xA;Please ask the service representative to reverse the overseas charge on the call to TaiWa  &#xD;&#xA;&#xD;&#xA;Yours sincerely,&#xD;&#xA;TaiWa Property &amp; Casualty Insurance Co., Ltd&#xD;&#xA;&#xD;&#xA;This is a computer generated letter and please do not reply directly.&#xD;&#xA;&#xD;&#xA;&quot;;&#xD;&#xA;&#xD;&#xA;VarEmail = System.String.Format(VarEmail,Msg_ApplyTrans.General.PolicyNo,Msg_ApplyTrans.General.PdfUrl,@&quot;http://t.cn/RhsIADh&quot;);&#xD;&#xA;&#xD;&#xA;Msg_Email = Msg_ApplyTrans;&#xD;&#xA;Port_Email(Microsoft.XLANGs.BaseTypes.Address)=@&quot;mailto:&quot;+Msg_ApplyTrans.Applicant.ApplicantEmail;&#xD;&#xA;Msg_Email(SMTP.EmailBodyTextCharset)=&quot;UTF-8&"+
@"quot;;&#xD;&#xA;Msg_Email(SMTP.Subject) = &quot;太桦保险投保确认邮件 TaiWa Insurance new policy information&quot;;&#xD;&#xA;Msg_Email(SMTP.EmailBodyText)=VarEmail;&#xD;&#xA;Msg_Email(SMTP.From) = &quot;pi_ace_commerce@eTaiWa.com&quot;;&#xD;&#xA;Msg_Email(SMTP.SMTPHost) = &quot;local.mail.eTaiWa.com&quot;;&#xD;&#xA;Msg_Email(SMTP.Username) = &quot;pi_ace_commerce&quot;;&#xD;&#xA;Msg_Email(SMTP.Password) = &quot;******&quot;;&#xD;&#xA;Msg_Email(SMTP.SMTPAuthenticate) = 0;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_Email' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='7e96fbf8-4e42-4c17-8443-4bfc8a010d44' ParentLink='Construct_MessageRef' LowerBound='88.27' HigherBound='88.36'>
                                <om:Property Name='Ref' Value='Msg_Email' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='43798253-e664-4540-9ccd-3eed3ce50b5a' ParentLink='ComplexStatement_Statement' LowerBound='151.1' HigherBound='153.1'>
                            <om:Property Name='PortName' Value='Port_Email' />
                            <om:Property Name='MessageName' Value='Msg_Email' />
                            <om:Property Name='OperationName' Value='SendEmail' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_Email' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='2b9a1195-b66f-4612-9ae6-1174a61ecea6' ParentLink='ComplexStatement_Statement' LowerBound='153.1' HigherBound='159.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_IssueResponse' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='98025a8b-647b-4ae1-abe7-1a9d38dae5cd' ParentLink='ComplexStatement_Statement' LowerBound='156.1' HigherBound='158.1'>
                                <om:Property Name='ClassName' Value='ScootAceHT.MapApplyResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_IssueResponse' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='c23d48f6-0e66-4e37-8db7-43876956598b' ParentLink='Transform_InputMessagePartRef' LowerBound='157.82' HigherBound='157.96'>
                                    <om:Property Name='MessageRef' Value='Msg_ApplyTrans' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='5d074134-46eb-4a26-bec7-48f916b2fa19' ParentLink='Transform_OutputMessagePartRef' LowerBound='157.32' HigherBound='157.49'>
                                    <om:Property Name='MessageRef' Value='Msg_IssueResponse' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='14b53f75-5d05-489d-bf82-ea62e188e603' ParentLink='Construct_MessageRef' LowerBound='154.27' HigherBound='154.44'>
                                <om:Property Name='Ref' Value='Msg_IssueResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='3cd4a7d2-753f-4119-ac72-d37faf22099c' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='59c1455d-4dae-46da-a352-447cc24b2097' ParentLink='ComplexStatement_Statement' LowerBound='162.1' HigherBound='168.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_ApplyError' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='801b7cac-ce83-49c1-b95d-e6759ad23ca3' ParentLink='ComplexStatement_Statement' LowerBound='165.1' HigherBound='167.1'>
                                <om:Property Name='ClassName' Value='ScootAceHT.MapApplyError' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_ApplyError' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='a012e0df-b380-4f07-a5ed-eb96cf931806' ParentLink='Transform_InputMessagePartRef' LowerBound='166.79' HigherBound='166.93'>
                                    <om:Property Name='MessageRef' Value='Msg_ApplyTrans' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_5' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='0263e4cd-fed2-451e-b9d2-4d06a2e27e0b' ParentLink='Transform_OutputMessagePartRef' LowerBound='166.32' HigherBound='166.49'>
                                    <om:Property Name='MessageRef' Value='Msg_IssueResponse' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_6' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='c045fb2b-bafb-4f0d-960e-118e44b27a29' ParentLink='Construct_MessageRef' LowerBound='163.27' HigherBound='163.44'>
                                <om:Property Name='Ref' Value='Msg_IssueResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='7640d259-7815-4478-9d36-15ccaf678a2b' ParentLink='ServiceBody_Statement' LowerBound='169.1' HigherBound='171.1'>
                    <om:Property Name='PortName' Value='Port_Apply' />
                    <om:Property Name='MessageName' Value='Msg_IssueResponse' />
                    <om:Property Name='OperationName' Value='Apply' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_Out' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='bc04665a-de8e-4c85-8fda-55d3fb56cb33' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='35.1' HigherBound='37.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='34' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ScootAceHT.PortType_Email' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_Email' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='a2d54d8e-d565-47f9-b21e-098961e13814' ParentLink='PortDeclaration_CLRAttribute' LowerBound='35.1' HigherBound='36.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLTransmit' />
                    <om:Property Name='TransportType' Value='HTTP' />
                    <om:Property Name='URI' Value='http://tempURI' />
                    <om:Property Name='IsDynamic' Value='True' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ff7b0b91-2a43-4ff5-9116-c99ac8b17ed4' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='37.1' HigherBound='39.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='3' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ScootAceHT.PortType_Apply' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_Apply' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='41047c09-95de-4afc-bc31-a7ba924b6e65' ParentLink='PortDeclaration_CLRAttribute' LowerBound='37.1' HigherBound='38.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='6f95cd56-5638-478b-b460-127d132c7bd5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='22' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ScootAceHT.PortType_XmlFile' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_XmlFile' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='0372b509-064d-427f-a7bf-d786020028ef' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __OrchApply_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __OrchApply_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchApply")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                OrchApply __svc__ = (OrchApply)_service;
                __OrchApply_root_0 __ctx0__ = (__OrchApply_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_Apply != null)
                {
                    __svc__.Port_Apply.Close(this, null);
                    __svc__.Port_Apply = null;
                }
                if (__svc__.Port_XmlFile != null)
                {
                    __svc__.Port_XmlFile.Close(this, null);
                    __svc__.Port_XmlFile = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __OrchApply_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __OrchApply_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchApply")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                OrchApply __svc__ = (OrchApply)_service;
                __OrchApply_root_0 __ctx0__ = (__OrchApply_root_0)(__svc__._stateMgrs[0]);
                __OrchApply_1 __ctx1__ = (__OrchApply_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Msg_ApplyIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_ApplyIn);
                    __ctx1__.__Msg_ApplyIn = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_ApplyTrans != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_ApplyTrans);
                    __ctx1__.__Msg_ApplyTrans = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_Email != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_Email);
                    __ctx1__.__Msg_Email = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_IssueResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_IssueResponse);
                    __ctx1__.__Msg_IssueResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_XmlFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_XmlFile);
                    __ctx1__.__Msg_XmlFile = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__VarEmail = null;
                if (__ctx1__ != null)
                    __ctx1__.__VarString = null;
                if (__svc__.Port_Email != null)
                {
                    __svc__.Port_Email.Close(this, null);
                    __svc__.Port_Email = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_ApplyIn")]
            public __messagetype_ScootAceHT_SchIssueIn __Msg_ApplyIn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_ApplyTrans")]
            public __messagetype_ScootAceHT_SchIssue2File __Msg_ApplyTrans;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_Email")]
            public __messagetype_ScootAceHT_SchIssue2File __Msg_Email;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_IssueResponse")]
            public __messagetype_ScootAceHT_SchIssueResponse __Msg_IssueResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_XmlFile")]
            public __messagetype_System_Xml_XmlDocument __Msg_XmlFile;
            [Microsoft.XLANGs.Core.UserVariableAttribute("VarEmail")]
            internal System.String __VarEmail;
            [Microsoft.XLANGs.Core.UserVariableAttribute("VarString")]
            internal System.String __VarString;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_Apply")]
        internal PortType_Apply Port_Apply;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_XmlFile")]
        internal PortType_XmlFile Port_XmlFile;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.XMLTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_Email")]
        internal PortType_Email Port_Email;  // lock index = 0

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Apply.Apply},
                                               typeof(OrchApply).GetField("Port_Apply", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchApply), "Port_Apply"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_XmlFile.SaveXML},
                                               typeof(OrchApply).GetField("Port_XmlFile", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchApply), "Port_XmlFile"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Email.SendEmail},
                                               typeof(OrchApply).GetField("Port_Email", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchApply), "Port_Email"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "c76d0301-3435-4cbe-9d3e-b19dc48bad12", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "c76d0301-3435-4cbe-9d3e-b19dc48bad12", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "9eb8ceb2-b9b5-4fb5-af39-2e2e6d785c27", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "9eb8ceb2-b9b5-4fb5-af39-2e2e6d785c27", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "27502a83-7953-4681-8149-80d54b78f269", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "4c526cb1-a015-4079-86db-541a25e275b3", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "4c526cb1-a015-4079-86db-541a25e275b3", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "2938c1ba-dd0f-4a17-bda2-07b136440724", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "2938c1ba-dd0f-4a17-bda2-07b136440724", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "ba7abf50-cd63-44db-9bed-a62dbcb8ef42", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "ba7abf50-cd63-44db-9bed-a62dbcb8ef42", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "43798253-e664-4540-9ccd-3eed3ce50b5a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "43798253-e664-4540-9ccd-3eed3ce50b5a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "2b9a1195-b66f-4612-9ae6-1174a61ecea6", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "2b9a1195-b66f-4612-9ae6-1174a61ecea6", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "59c1455d-4dae-46da-a352-447cc24b2097", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "59c1455d-4dae-46da-a352-447cc24b2097", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "27502a83-7953-4681-8149-80d54b78f269", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "7640d259-7815-4478-9d36-15ccaf678a2b", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "7640d259-7815-4478-9d36-15ccaf678a2b", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,2,4,4,5,6,6,7,7,8,9,9,9,10,11,11,12,13,13,13,14,15,15,16,6,17,17,18,19,20,20,20,21,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __OrchApply_root_0 __ctx0__ = (__OrchApply_root_0)_stateMgrs[0];
            __OrchApply_1 __ctx1__ = (__OrchApply_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_Email = new PortType_Email(2, this);
                Port_Apply = new PortType_Apply(0, this);
                Port_XmlFile = new PortType_XmlFile(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_Apply, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __OrchApply_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __OrchApply_root_0 __ctx0__ = (__OrchApply_root_0)_stateMgrs[0];
            __OrchApply_1 __ctx1__ = (__OrchApply_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__VarEmail = default(System.String);
                __ctx1__.__VarString = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Port_Apply.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Msg_ApplyIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_ApplyIn);
                __ctx1__.__Msg_ApplyIn = new __messagetype_ScootAceHT_SchIssueIn("Msg_ApplyIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg_ApplyIn);
                Port_Apply.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg_ApplyIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Msg_ApplyIn);
                    __edata.PortName = @"Port_Apply";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__VarEmail = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__VarString = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    __messagetype_ScootAceHT_SchIssue2File __Msg_ApplyTrans = new __messagetype_ScootAceHT_SchIssue2File("Msg_ApplyTrans", __ctx1__);

                    ApplyTransform(typeof(ScootAceHT.MapApplyIn2File), new object[] {__Msg_ApplyTrans.part}, new object[] {__ctx1__.__Msg_ApplyIn.part});

                    if (__ctx1__.__Msg_ApplyTrans != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_ApplyTrans);
                    __ctx1__.__Msg_ApplyTrans = __Msg_ApplyTrans;
                    __ctx1__.RefMessage(__ctx1__.__Msg_ApplyTrans);
                }
                __ctx1__.__Msg_ApplyTrans.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_ApplyTrans);
                    __edata.Messages.Add(__ctx1__.__Msg_ApplyIn);
                    Tracker.FireEvent(__eventLocations[5],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_ApplyIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_ApplyIn);
                    __ctx1__.__Msg_ApplyIn = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                __condition__ = ((System.String)__ctx1__.__Msg_ApplyTrans.part.GetDistinguishedField("SaleInfo.UserName") == "aceif" && (System.String)__ctx1__.__Msg_ApplyTrans.part.GetDistinguishedField("SaleInfo.Password") == "ace.interface");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 30;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                {
                    __messagetype_System_Xml_XmlDocument __Msg_XmlFile = new __messagetype_System_Xml_XmlDocument("Msg_XmlFile", __ctx1__);

                    __Msg_XmlFile.CopyFrom(__ctx1__.__Msg_ApplyTrans);
                    __ctx1__.__VarString = __Msg_XmlFile.part.TypedValue.OuterXml;
                    __ctx1__.__VarString = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" + __ctx1__.__VarString;
                    __Msg_XmlFile.part.TypedValue.LoadXml(__ctx1__.__VarString);
                    __Msg_XmlFile.SetPropertyValue(typeof(FILE.ReceivedFileName), (System.String)__ctx1__.__Msg_ApplyTrans.part.GetDistinguishedField("General.AceNo"));

                    if (__ctx1__.__Msg_XmlFile != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_XmlFile);
                    __ctx1__.__Msg_XmlFile = __Msg_XmlFile;
                    __ctx1__.RefMessage(__ctx1__.__Msg_XmlFile);
                }
                __ctx1__.__Msg_XmlFile.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_XmlFile);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_XmlFile.SendMessage(0, __ctx1__.__Msg_XmlFile, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_XmlFile);
                    __edata.PortName = @"Port_XmlFile";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_XmlFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_XmlFile);
                    __ctx1__.__Msg_XmlFile = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[11],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                {
                    __messagetype_ScootAceHT_SchIssue2File __Msg_Email = new __messagetype_ScootAceHT_SchIssue2File("Msg_Email", __ctx1__);

                    __ctx1__.__VarEmail = @"
                    感谢投保太桦保险。
                    
                    您的保单号码为[{0}]，请从以下地址下载电子保单；
                    {1}
                    
                    了解保险详情，请查看保险条款 {2} 。
                    
                    如您需要进一步的协助， 请致电我们的客户服务专员热线：
                    热线号码： 4006095509 （7*24小时）
                    
                    感谢您对太桦的信任和支持， 希望在今后能继续为您提供服务。
                    
                    请将以下号码存在您的手机上。24 小时紧急援助热线 +86 10 51295700
                    当您在国外需要紧急援助或救援时并已经购买了太桦境外旅行人身意外伤害保险产品，请拨打此号码。 您可以告诉接线生由太桦支付这个电话费。 
                    
                    您真诚的
                    太桦财产保险有限公司
                    
                    这是一个电脑自动生成的信函，请不要直接回复。
                    
                    Thank you for insuring with TaiWa.
                    
                    Your policy number is [{0}].  Please refer to this link to download the policy certificate: 
                    {1}
                    
                    For more information, please see the Policy Wording: {2} .  
                    
                    Should you require further assistance, please contact our friendly Customer Relations Officer at 
                    Hotline: 4006095509 (7 days*24-hour)
                    
                    Thank you for your trust and support in TaiWa, We look forward to serving you in future.
                    
                    Please save this number in your mobile phone.
                    24 Hours Emergency Hotline: +86 10 51295700
                    Please call when you are overseas and need assistance under the TaiWa Overseas Travel Insurance Plans.
                    Please ask the service representative to reverse the overseas charge on the call to TaiWa  
                    
                    Yours sincerely,
                    TaiWa Property & Casualty Insurance Co., Ltd
                    
                    This is a computer generated letter and please do not reply directly.
                    
                    ";
                    __ctx1__.__VarEmail = System.String.Format(__ctx1__.__VarEmail, (System.String)__ctx1__.__Msg_ApplyTrans.part.GetDistinguishedField("General.PolicyNo"), (System.String)__ctx1__.__Msg_ApplyTrans.part.GetDistinguishedField("General.PdfUrl"), @"http://t.cn/RhsIADh");
                    __Msg_Email.CopyFrom(__ctx1__.__Msg_ApplyTrans);
                    Port_Email.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), @"mailto:" + (System.String)__ctx1__.__Msg_ApplyTrans.part.GetDistinguishedField("Applicant.ApplicantEmail"));
                    __Msg_Email.SetPropertyValue(typeof(SMTP.EmailBodyTextCharset), "UTF-8");
                    __Msg_Email.SetPropertyValue(typeof(SMTP.Subject), "太桦保险投保确认邮件 TaiWa Insurance new policy information");
                    __Msg_Email.SetPropertyValue(typeof(SMTP.EmailBodyText), __ctx1__.__VarEmail);
                    __Msg_Email.SetPropertyValue(typeof(SMTP.From), "pi_ace_commerce@eTaiWa.com");
                    __Msg_Email.SetPropertyValue(typeof(SMTP.SMTPHost), "local.mail.eTaiWa.com");
                    __Msg_Email.SetPropertyValue(typeof(SMTP.Username), "pi_ace_commerce");
                    __Msg_Email.SetPropertyValue(typeof(SMTP.Password), "******");
                    __Msg_Email.SetPropertyValue(typeof(SMTP.SMTPAuthenticate), (System.UInt32)(0U));

                    if (__ctx1__.__Msg_Email != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_Email);
                    __ctx1__.__Msg_Email = __Msg_Email;
                    __ctx1__.RefMessage(__ctx1__.__Msg_Email);
                }
                __ctx1__.__Msg_Email.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_Email);
                    Tracker.FireEvent(__eventLocations[12],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[13],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_Email.SendMessage(0, __ctx1__.__Msg_Email, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_Email);
                    __edata.PortName = @"Port_Email";
                    Tracker.FireEvent(__eventLocations[14],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_Email != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_Email);
                    __ctx1__.__Msg_Email = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[15],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                {
                    __messagetype_ScootAceHT_SchIssueResponse __Msg_IssueResponse = new __messagetype_ScootAceHT_SchIssueResponse("Msg_IssueResponse", __ctx1__);

                    ApplyTransform(typeof(ScootAceHT.MapApplyResponse), new object[] {__Msg_IssueResponse.part}, new object[] {__ctx1__.__Msg_ApplyTrans.part});

                    if (__ctx1__.__Msg_IssueResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_IssueResponse);
                    __ctx1__.__Msg_IssueResponse = __Msg_IssueResponse;
                    __ctx1__.RefMessage(__ctx1__.__Msg_IssueResponse);
                }
                __ctx1__.__Msg_IssueResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_IssueResponse);
                    __edata.Messages.Add(__ctx1__.__Msg_ApplyTrans);
                    Tracker.FireEvent(__eventLocations[16],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                {
                    __messagetype_ScootAceHT_SchIssueResponse __Msg_IssueResponse = new __messagetype_ScootAceHT_SchIssueResponse("Msg_IssueResponse", __ctx1__);

                    ApplyTransform(typeof(ScootAceHT.MapApplyError), new object[] {__Msg_IssueResponse.part}, new object[] {__ctx1__.__Msg_ApplyTrans.part});

                    if (__ctx1__.__Msg_IssueResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_IssueResponse);
                    __ctx1__.__Msg_IssueResponse = __Msg_IssueResponse;
                    __ctx1__.RefMessage(__ctx1__.__Msg_IssueResponse);
                }
                __ctx1__.__Msg_IssueResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                if ( !PreProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_IssueResponse);
                    __edata.Messages.Add(__ctx1__.__Msg_ApplyTrans);
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__VarString = null;
                if (__ctx1__ != null)
                    __ctx1__.__VarEmail = null;
                if (__ctx1__ != null && __ctx1__.__Msg_ApplyTrans != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_ApplyTrans);
                    __ctx1__.__Msg_ApplyTrans = null;
                }
                if (Port_XmlFile != null)
                {
                    Port_XmlFile.Close(__ctx1__, __seg__);
                    Port_XmlFile = null;
                }
                if (Port_Email != null)
                {
                    Port_Email.Close(__ctx1__, __seg__);
                    Port_Email = null;
                }
                Tracker.FireEvent(__eventLocations[19],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_Apply.SendMessage(0, __ctx1__.__Msg_IssueResponse, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Port_Apply != null)
                {
                    Port_Apply.Close(__ctx1__, __seg__);
                    Port_Apply = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_IssueResponse);
                    __edata.PortName = @"Port_Apply";
                    Tracker.FireEvent(__eventLocations[21],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_IssueResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_IssueResponse);
                    __ctx1__.__Msg_IssueResponse = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 41;
            case 41:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }
    //#line 450 "F:\Bts Projects\ScootAceHT\ScootAceHT\OrchSurrender.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_Surrender", "Surrender", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        },
        new System.Type[] {
            typeof(ScootAceHT.PortType_Surrender),
            typeof(ScootAceHT.PortType_SurrenderFile),
            typeof(ScootAceHT.PortType_SurrenderEmail)
        },
        new System.String[] {
            "Port_Surrender",
            "Port_SurrenderFile",
            "Port_SurrenderEmail"
        },
        new System.Type[] {
            null,
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class OrchSurrender : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(OrchSurrender));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static OrchSurrender()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 1;
            _rootContext = new __OrchSurrender_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public OrchSurrender(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "OrchSurrender", tracker)
        {
            ConstructorHelper();
        }

        public OrchSurrender(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "OrchSurrender")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>c22ccc7c-f9be-47a8-aa8a-768d8e66e777</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>e1d95b29-20f9-478f-916a-7bf744bf1984</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_SurrenderIn</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>26da2753-dafd-44a9-8426-8075b6aa1f1c</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Decide_ChkUsrPwd</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>8d1638b8-4de3-45cc-aee2-6d5363706ad9</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_OK</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>24cb38ce-9944-438f-aa5e-3aecda880c84</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_GetPlyNo</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>74f5f833-f0f4-4758-99fc-0b9da0ac8e7a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_GetPlyNo</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5d906933-6222-4027-a09a-f17aad631901</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>010b4793-056c-4152-ab7f-f2702e9a96ff</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>17a95c2e-bae1-4209-9221-a3068828f529</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionShape</shapeType>      <ShapeID>ef8e5ba0-de56-4e6d-afc4-40f9e2638729</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Decide_GetPlyNo</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>bb92aaf2-adcd-459a-a1a9-4174ed1a8406</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Rule_GetPlyNo</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>af471a81-effb-4e46-877f-1ea0f8e79ea1</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_SurrenderFile</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>159d8d75-4a9f-4238-a43a-3c7a8d5f7e84</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_SurrenderFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>773b4b1a-5ccf-40ec-b1fa-7e0b89767e0a</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>c0ef235f-5549-4f9b-b7ee-11dadbba185c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_SurrenderFile</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>71b475c9-812f-4d3e-a060-d58a5b0504ae</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_SurrenderEmail</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>3e2a2670-cd25-41e4-8567-20347d45523e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>bc6daa51-abc9-49bc-b6d9-58a7c7825e54</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>aa2b17ad-072a-4eee-b2ef-0192f37789ae</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Send_SurrenderEmail</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>228ecbcc-14e7-44b9-9184-be8cc4e91c90</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_SurrenderOK</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>243855b8-f2a6-474a-a8fb-7cb9139044e2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_SurrenderOK</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>dddb8a83-7e9d-40c0-9fec-4c362c10cb22</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>5162e014-b4b7-4aa7-94d3-ee140f35d2bc</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>92764c0f-2909-47e1-8382-00a1bb820387</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>4f8acc32-756e-4c92-a743-a96e4a71398f</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ef73ffd6-fc71-4af3-a820-5746f44c3373</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_NoPlyNO</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>1b030b97-d043-41b1-a90f-c23fba2c2371</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_NoPlyNO</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>04c5bc90-21e9-40aa-80ed-22b75d01f7c4</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_7</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>40822fa0-a696-4407-aa03-640a4830f173</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_8</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>90b5c06c-d19d-401b-a506-ec8a34aaf413</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DecisionBranchShape</shapeType>      <ShapeID>7917bcd2-b580-467a-b7a3-cf0ce003bc03</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>Else</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ed1c768e-48fc-4be9-be55-df6bd10bd908</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructMessage_SurrenderError</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>085624bf-2e36-4c06-9854-cd67e75c5fbb</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Transform_SurrenderError</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>ddc38ce9-a750-4d88-b01e-92510ec7fa74</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>242e6503-b6f9-4f21-b3ee-2651f5eb1bce</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>54de4384-7db8-4480-99e5-e1ca24ea3b20</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6fd93a67-1eaf-42ab-8932-5cec738b610a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_Surrender</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'OrchSurrender'</ActionName><IsAtomic>0</IsAtomic><Line>450</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>467</Line><Position>22</Position><ShapeID>'e1d95b29-20f9-478f-916a-7bf744bf1984'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderIn</name><part>part</part><schema>ScootAceHT.SchSurrenderIn</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>470</Line><Position>13</Position><ShapeID>'26da2753-dafd-44a9-8426-8075b6aa1f1c'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>473</Line><Position>17</Position><ShapeID>'24cb38ce-9944-438f-aa5e-3aecda880c84'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderGetPlyNo</name><part>part</part><schema>ScootAceHT.SchSurrenderIn</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_SurrenderIn</name><part>part</part><schema>ScootAceHT.SchSurrenderIn</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>479</Line><Position>17</Position><ShapeID>'ef8e5ba0-de56-4e6d-afc4-40f9e2638729'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>482</Line><Position>21</Position><ShapeID>'af471a81-effb-4e46-877f-1ea0f8e79ea1'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderFile</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>494</Line><Position>21</Position><ShapeID>'c0ef235f-5549-4f9b-b7ee-11dadbba185c'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderFile</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>496</Line><Position>21</Position><ShapeID>'71b475c9-812f-4d3e-a060-d58a5b0504ae'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderEmail</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>546</Line><Position>21</Position><ShapeID>'aa2b17ad-072a-4eee-b2ef-0192f37789ae'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderEmail</name><part>part</part><schema>Microsoft.XLANGs.BaseTypes.Any</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>548</Line><Position>21</Position><ShapeID>'228ecbcc-14e7-44b9-9184-be8cc4e91c90'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderResponse</name><part>part</part><schema>ScootAceHT.SchSurrenderResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_SurrenderGetPlyNo</name><part>part</part><schema>ScootAceHT.SchSurrenderIn</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>557</Line><Position>21</Position><ShapeID>'ef73ffd6-fc71-4af3-a820-5746f44c3373'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderResponse</name><part>part</part><schema>ScootAceHT.SchSurrenderResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_SurrenderIn</name><part>part</part><schema>ScootAceHT.SchSurrenderIn</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>567</Line><Position>17</Position><ShapeID>'ed1c768e-48fc-4be9-be55-df6bd10bd908'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderResponse</name><part>part</part><schema>ScootAceHT.SchSurrenderResponse</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>Msg_SurrenderIn</name><part>part</part><schema>ScootAceHT.SchSurrenderIn</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>574</Line><Position>13</Position><ShapeID>'6fd93a67-1eaf-42ab-8932-5cec738b610a'</ShapeID>
<Messages>
	<MsgInfo><name>Msg_SurrenderResponse</name><part>part</part><schema>ScootAceHT.SchSurrenderResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='ed28edcd-bd69-4578-a444-4edb3888a834' LowerBound='1.1' HigherBound='161.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='ScootAceHT' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='502c61a3-5d2e-4544-92b4-d34d521cab87' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SurrenderIn' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='f6ca70b6-b642-49fc-8e27-3588de1ae798' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Surrender' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='25082239-7694-4e3e-bc56-d7d662649f76' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.27'>
                    <om:Property Name='Ref' Value='ScootAceHT.SchSurrenderIn' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='798ed7c6-bebe-4648-8ee9-5fdec857a900' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Surrender' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='e1df884c-ef31-4f2f-821f-36c403733a75' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Surrender' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='e5f3278e-dc34-4dd8-87d5-0486efa26976' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.27'>
                    <om:Property Name='Ref' Value='ScootAceHT.SchSurrenderIn' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='68cfbb82-7a7e-402d-8f67-2eced3498e0b' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.29' HigherBound='15.49'>
                    <om:Property Name='Ref' Value='ScootAceHT.SchSurrenderResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='e5470f9e-bddd-4740-8398-423468e822be' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SurrenderFile' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='aa025b51-1347-48b0-b0b9-d966666477a1' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SurrenderFile' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='1f08a932-199d-4678-bba1-ad97bd61fe74' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='effa8690-95a1-41ed-8059-5b805ed8d8c1' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SurrenderEmail' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='275f173e-9bbe-4fbe-9341-9e400707285a' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SurrenderEmail' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='2299f9f5-30cd-4bf3-89d1-d5157427e195' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='1e4c03a9-4b5b-4a31-89f6-caabedff7731' ParentLink='Module_ServiceDeclaration' LowerBound='32.1' HigherBound='160.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='OrchSurrender' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='6715ab98-ad88-413d-9dd4-7f418d38103a' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='46.1' HigherBound='47.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='VarSurrenderEmail' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='4c43c302-8ece-490b-849a-b9ce9cdad1d3' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='41.1' HigherBound='42.1'>
                <om:Property Name='Type' Value='ScootAceHT.SchSurrenderIn' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_SurrenderIn' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d1bdf67f-bacd-412a-816a-f62f43f23045' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='42.1' HigherBound='43.1'>
                <om:Property Name='Type' Value='ScootAceHT.SchSurrenderResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_SurrenderResponse' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ca4402bb-a206-462e-a34d-c16082213cfd' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='43.1' HigherBound='44.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_SurrenderEmail' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='1f2192fa-fa62-4b9c-a742-60a01719e855' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='44.1' HigherBound='45.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_SurrenderFile' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f2820dd2-85ee-4d7f-b59d-2f76769a763d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='45.1' HigherBound='46.1'>
                <om:Property Name='Type' Value='ScootAceHT.SchSurrenderIn' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Msg_SurrenderGetPlyNo' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='c22ccc7c-f9be-47a8-aa8a-768d8e66e777' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='e1d95b29-20f9-478f-916a-7bf744bf1984' ParentLink='ServiceBody_Statement' LowerBound='49.1' HigherBound='52.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_Surrender' />
                    <om:Property Name='MessageName' Value='Msg_SurrenderIn' />
                    <om:Property Name='OperationName' Value='Surrender' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_SurrenderIn' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Decision' OID='26da2753-dafd-44a9-8426-8075b6aa1f1c' ParentLink='ServiceBody_Statement' LowerBound='52.1' HigherBound='156.1'>
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Decide_ChkUsrPwd' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='DecisionBranch' OID='8d1638b8-4de3-45cc-aee2-6d5363706ad9' ParentLink='ReallyComplexStatement_Branch' LowerBound='53.13' HigherBound='147.1'>
                        <om:Property Name='Expression' Value='(Msg_SurrenderIn.SaleInfo.UserName==&quot;aceif&quot; &amp;&amp; Msg_SurrenderIn.SaleInfo.Password==&quot;ace.interface&quot;)&#xD;&#xA;' />
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Rule_OK' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='24cb38ce-9944-438f-aa5e-3aecda880c84' ParentLink='ComplexStatement_Statement' LowerBound='55.1' HigherBound='61.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_GetPlyNo' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='74f5f833-f0f4-4758-99fc-0b9da0ac8e7a' ParentLink='ComplexStatement_Statement' LowerBound='58.1' HigherBound='60.1'>
                                <om:Property Name='ClassName' Value='ScootAceHT.MapSurrenderGetPlyNo' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_GetPlyNo' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessagePartRef' OID='5d906933-6222-4027-a09a-f17aad631901' ParentLink='Transform_InputMessagePartRef' LowerBound='59.90' HigherBound='59.105'>
                                    <om:Property Name='MessageRef' Value='Msg_SurrenderIn' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_5' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='010b4793-056c-4152-ab7f-f2702e9a96ff' ParentLink='Transform_OutputMessagePartRef' LowerBound='59.32' HigherBound='59.53'>
                                    <om:Property Name='MessageRef' Value='Msg_SurrenderGetPlyNo' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_6' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='17a95c2e-bae1-4209-9221-a3068828f529' ParentLink='Construct_MessageRef' LowerBound='56.27' HigherBound='56.48'>
                                <om:Property Name='Ref' Value='Msg_SurrenderGetPlyNo' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Decision' OID='ef8e5ba0-de56-4e6d-afc4-40f9e2638729' ParentLink='ComplexStatement_Statement' LowerBound='61.1' HigherBound='146.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Decide_GetPlyNo' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='DecisionBranch' OID='bb92aaf2-adcd-459a-a1a9-4174ed1a8406' ParentLink='ReallyComplexStatement_Branch' LowerBound='62.17' HigherBound='137.1'>
                                <om:Property Name='Expression' Value='Msg_SurrenderGetPlyNo.General.PolicyNo!=@&quot;PlyNO Not Found!&quot;' />
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Rule_GetPlyNo' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Construct' OID='af471a81-effb-4e46-877f-1ea0f8e79ea1' ParentLink='ComplexStatement_Statement' LowerBound='64.1' HigherBound='76.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructMessage_SurrenderFile' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageAssignment' OID='159d8d75-4a9f-4238-a43a-3c7a8d5f7e84' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='75.1'>
                                        <om:Property Name='Expression' Value='Msg_SurrenderFile = Msg_SurrenderGetPlyNo;&#xD;&#xA;&#xD;&#xA;//Msg_SurrenderFile(FILE.ReceivedFileName) = Msg_SurrenderIn.General.PolicyNo;&#xD;&#xA;&#xD;&#xA;Msg_SurrenderFile(FILE.ReceivedFileName) = Msg_SurrenderGetPlyNo.General.PolicyNo;&#xD;&#xA;&#xD;&#xA;&#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_SurrenderFile' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='773b4b1a-5ccf-40ec-b1fa-7e0b89767e0a' ParentLink='Construct_MessageRef' LowerBound='65.31' HigherBound='65.48'>
                                        <om:Property Name='Ref' Value='Msg_SurrenderFile' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='c0ef235f-5549-4f9b-b7ee-11dadbba185c' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='78.1'>
                                    <om:Property Name='PortName' Value='Port_SurrenderFile' />
                                    <om:Property Name='MessageName' Value='Msg_SurrenderFile' />
                                    <om:Property Name='OperationName' Value='SurrenderFile' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send_SurrenderFile' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Construct' OID='71b475c9-812f-4d3e-a060-d58a5b0504ae' ParentLink='ComplexStatement_Statement' LowerBound='78.1' HigherBound='128.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructMessage_SurrenderEmail' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='MessageAssignment' OID='3e2a2670-cd25-41e4-8567-20347d45523e' ParentLink='ComplexStatement_Statement' LowerBound='81.1' HigherBound='127.1'>
                                        <om:Property Name='Expression' Value='VarSurrenderEmail =&#xD;&#xA;@&quot;&#xD;&#xA;感谢投保太桦保险&#xD;&#xA;&#xD;&#xA;我们知道您已经取消了保单号码为[{0}]的保单。&#xD;&#xA;&#xD;&#xA;如您需要重新购买你的保险或对你的保单有任何问题，请致电我们的客户服务专员热线：&#xD;&#xA;热线号码： 4006095509 （7*24小时）&#xD;&#xA;&#xD;&#xA;感谢您对太桦的信任和支持,希望在今后能继续为您提供服务。&#xD;&#xA;&#xD;&#xA;您真诚的&#xD;&#xA;太桦财产保险有限公司&#xD;&#xA;&#xD;&#xA;这是一个电脑自动生成的信函，请不要直接回复。&#xD;&#xA;&#xD;&#xA;Thank you for insuring with TaiWa.&#xD;&#xA;&#xD;&#xA;We acknowledged that you have cancelled your policy.  The policy number is [{0}].&#xD;&#xA;&#xD;&#xA;Should you wish to reinstate your policy or if you have further questions regarding your policy, &#xD;&#xA;please contact our Customer Relations Officer at Hotline: 4006095509 (7 days*24-hour)&#xD;&#xA;&#xD;&#xA;Thank you for your trust and support in TaiWa, We look forward to serving you in future.&#xD;&#xA;&#xD;&#xA;Yours sincerely,&#xD;&#xA;TaiWa Property &amp; Casualty Insurance Co., Ltd&#xD;&#xA;&#xD;&#xA;This is a computer generated letter and please do not reply directly.&#xD;&#xA;&#xD;&#xA;&quot;;&#xD;&#xA;&#xD;&#xA;VarSurrenderEmail = System.String.Format(VarSurrenderEmail,Msg_SurrenderGetPlyNo.General.PolicyNo);&#xD;&#xA;&#xD;&#xA;Msg_SurrenderEmail = Msg_SurrenderGetPlyNo;&#xD;&#xA;Port_SurrenderEmail(Microsoft.XLANGs.BaseTypes.Address)=@&quot;mailto:&quot;+Msg_SurrenderGetPlyNo.Applicant.ApplicantEmail;&#xD;&#xA;Msg_SurrenderEmail(SMTP.EmailBodyTextCharset)=&quot;UTF-8&quot;;&#xD;&#xA;Msg_SurrenderEmail(SMTP.Subject) = &quot;太桦保险保单取消通知 TaiWa Insurance policy cancellation confirmation&quot;;&#xD;&#xA;Msg_SurrenderEmail(SMTP.EmailBodyText)=VarSurrenderEmail;&#xD;&#xA;Msg_SurrenderEmail(SMTP.From) = &quot;pi_ace_commerce@eTaiWa.com&quot;;&#xD;&#xA;Msg_SurrenderEmail(SMTP.SMTPHost) = &quot;local.mail.eTaiWa.com&quot;;&#xD;&#xA;Msg_SurrenderEmail(SMTP.Username) = &quot;pi_ace_commerce&quot;;&#xD;&#xA;Msg_SurrenderEmail(SMTP.Password) = &quot;******&quot;;&#xD;&#xA;Msg_SurrenderEmail(SMTP.SMTPAuthenticate) = 0;&#xD;&#xA;&"+
@"#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='MessageAssignment_1' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='bc6daa51-abc9-49bc-b6d9-58a7c7825e54' ParentLink='Construct_MessageRef' LowerBound='79.31' HigherBound='79.49'>
                                        <om:Property Name='Ref' Value='Msg_SurrenderEmail' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='aa2b17ad-072a-4eee-b2ef-0192f37789ae' ParentLink='ComplexStatement_Statement' LowerBound='128.1' HigherBound='130.1'>
                                    <om:Property Name='PortName' Value='Port_SurrenderEmail' />
                                    <om:Property Name='MessageName' Value='Msg_SurrenderEmail' />
                                    <om:Property Name='OperationName' Value='SurrenderEmail' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Send_SurrenderEmail' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Construct' OID='228ecbcc-14e7-44b9-9184-be8cc4e91c90' ParentLink='ComplexStatement_Statement' LowerBound='130.1' HigherBound='136.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructMessage_SurrenderOK' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='243855b8-f2a6-474a-a8fb-7cb9139044e2' ParentLink='ComplexStatement_Statement' LowerBound='133.1' HigherBound='135.1'>
                                        <om:Property Name='ClassName' Value='ScootAceHT.MapSurrenderResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Transform_SurrenderOK' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='dddb8a83-7e9d-40c0-9fec-4c362c10cb22' ParentLink='Transform_OutputMessagePartRef' LowerBound='134.36' HigherBound='134.57'>
                                            <om:Property Name='MessageRef' Value='Msg_SurrenderResponse' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_2' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='5162e014-b4b7-4aa7-94d3-ee140f35d2bc' ParentLink='Transform_InputMessagePartRef' LowerBound='134.94' HigherBound='134.115'>
                                            <om:Property Name='MessageRef' Value='Msg_SurrenderGetPlyNo' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_1' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='92764c0f-2909-47e1-8382-00a1bb820387' ParentLink='Construct_MessageRef' LowerBound='131.31' HigherBound='131.52'>
                                        <om:Property Name='Ref' Value='Msg_SurrenderResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                            <om:Element Type='DecisionBranch' OID='4f8acc32-756e-4c92-a743-a96e4a71398f' ParentLink='ReallyComplexStatement_Branch'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Else' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='Construct' OID='ef73ffd6-fc71-4af3-a820-5746f44c3373' ParentLink='ComplexStatement_Statement' LowerBound='139.1' HigherBound='145.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructMessage_NoPlyNO' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='1b030b97-d043-41b1-a90f-c23fba2c2371' ParentLink='ComplexStatement_Statement' LowerBound='142.1' HigherBound='144.1'>
                                        <om:Property Name='ClassName' Value='ScootAceHT.MapSurrenderNoPlyNo' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='Transform_NoPlyNO' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='MessagePartRef' OID='04c5bc90-21e9-40aa-80ed-22b75d01f7c4' ParentLink='Transform_InputMessagePartRef' LowerBound='143.93' HigherBound='143.108'>
                                            <om:Property Name='MessageRef' Value='Msg_SurrenderIn' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_7' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='40822fa0-a696-4407-aa03-640a4830f173' ParentLink='Transform_OutputMessagePartRef' LowerBound='143.36' HigherBound='143.57'>
                                            <om:Property Name='MessageRef' Value='Msg_SurrenderResponse' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_8' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='90b5c06c-d19d-401b-a506-ec8a34aaf413' ParentLink='Construct_MessageRef' LowerBound='140.31' HigherBound='140.52'>
                                        <om:Property Name='Ref' Value='Msg_SurrenderResponse' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='DecisionBranch' OID='7917bcd2-b580-467a-b7a3-cf0ce003bc03' ParentLink='ReallyComplexStatement_Branch'>
                        <om:Property Name='IsGhostBranch' Value='True' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Else' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='ed1c768e-48fc-4be9-be55-df6bd10bd908' ParentLink='ComplexStatement_Statement' LowerBound='149.1' HigherBound='155.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ConstructMessage_SurrenderError' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Transform' OID='085624bf-2e36-4c06-9854-cd67e75c5fbb' ParentLink='ComplexStatement_Statement' LowerBound='152.1' HigherBound='154.1'>
                                <om:Property Name='ClassName' Value='ScootAceHT.MapSurrenderError' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Transform_SurrenderError' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='MessagePartRef' OID='ddc38ce9-a750-4d88-b01e-92510ec7fa74' ParentLink='Transform_OutputMessagePartRef' LowerBound='153.32' HigherBound='153.53'>
                                    <om:Property Name='MessageRef' Value='Msg_SurrenderResponse' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_4' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessagePartRef' OID='242e6503-b6f9-4f21-b3ee-2651f5eb1bce' ParentLink='Transform_InputMessagePartRef' LowerBound='153.87' HigherBound='153.102'>
                                    <om:Property Name='MessageRef' Value='Msg_SurrenderIn' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='MessagePartReference_3' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='MessageRef' OID='54de4384-7db8-4480-99e5-e1ca24ea3b20' ParentLink='Construct_MessageRef' LowerBound='150.27' HigherBound='150.48'>
                                <om:Property Name='Ref' Value='Msg_SurrenderResponse' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                </om:Element>
                <om:Element Type='Send' OID='6fd93a67-1eaf-42ab-8932-5cec738b610a' ParentLink='ServiceBody_Statement' LowerBound='156.1' HigherBound='158.1'>
                    <om:Property Name='PortName' Value='Port_Surrender' />
                    <om:Property Name='MessageName' Value='Msg_SurrenderResponse' />
                    <om:Property Name='OperationName' Value='Surrender' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_Surrender' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='23269cc3-8c7c-4720-aa65-2ff834ce09d6' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='35.1' HigherBound='37.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='4' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ScootAceHT.PortType_Surrender' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_Surrender' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='0b79282d-fd78-4935-9cb4-6b4bd708fd34' ParentLink='PortDeclaration_CLRAttribute' LowerBound='35.1' HigherBound='36.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a002c86c-687e-4f53-afb2-496f1cc8db63' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='37.1' HigherBound='39.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='15' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ScootAceHT.PortType_SurrenderFile' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_SurrenderFile' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='340f19da-4d47-452d-aa8a-f0395159c0d8' ParentLink='PortDeclaration_CLRAttribute' LowerBound='37.1' HigherBound='38.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='7bae7649-bf3c-4a68-9601-5101f0d8982f' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='24' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='ScootAceHT.PortType_SurrenderEmail' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_SurrenderEmail' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='PhysicalBindingAttribute' OID='5da361ac-7407-47d2-bcd6-189aa45c41ce' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='InPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLReceive' />
                    <om:Property Name='OutPipeline' Value='Microsoft.BizTalk.DefaultPipelines.XMLTransmit' />
                    <om:Property Name='TransportType' Value='HTTP' />
                    <om:Property Name='URI' Value='http://tempURI' />
                    <om:Property Name='IsDynamic' Value='True' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __OrchSurrender_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __OrchSurrender_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchSurrender")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                OrchSurrender __svc__ = (OrchSurrender)_service;
                __OrchSurrender_root_0 __ctx0__ = (__OrchSurrender_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_SurrenderFile != null)
                {
                    __svc__.Port_SurrenderFile.Close(this, null);
                    __svc__.Port_SurrenderFile = null;
                }
                if (__svc__.Port_Surrender != null)
                {
                    __svc__.Port_Surrender.Close(this, null);
                    __svc__.Port_Surrender = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __OrchSurrender_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __OrchSurrender_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "OrchSurrender")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                OrchSurrender __svc__ = (OrchSurrender)_service;
                __OrchSurrender_1 __ctx1__ = (__OrchSurrender_1)(__svc__._stateMgrs[1]);
                __OrchSurrender_root_0 __ctx0__ = (__OrchSurrender_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null)
                    __ctx1__.__VarSurrenderEmail = null;
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderGetPlyNo != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderGetPlyNo);
                    __ctx1__.__Msg_SurrenderGetPlyNo = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderFile);
                    __ctx1__.__Msg_SurrenderFile = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderEmail != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderEmail);
                    __ctx1__.__Msg_SurrenderEmail = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderResponse);
                    __ctx1__.__Msg_SurrenderResponse = null;
                }
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderIn);
                    __ctx1__.__Msg_SurrenderIn = null;
                }
                if (__svc__.Port_SurrenderEmail != null)
                {
                    __svc__.Port_SurrenderEmail.Close(this, null);
                    __svc__.Port_SurrenderEmail = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_SurrenderIn")]
            public __messagetype_ScootAceHT_SchSurrenderIn __Msg_SurrenderIn;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_SurrenderResponse")]
            public __messagetype_ScootAceHT_SchSurrenderResponse __Msg_SurrenderResponse;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_SurrenderEmail")]
            public __messagetype_System_Xml_XmlDocument __Msg_SurrenderEmail;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_SurrenderFile")]
            public __messagetype_System_Xml_XmlDocument __Msg_SurrenderFile;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Msg_SurrenderGetPlyNo")]
            public __messagetype_ScootAceHT_SchSurrenderIn __Msg_SurrenderGetPlyNo;
            [Microsoft.XLANGs.Core.UserVariableAttribute("VarSurrenderEmail")]
            internal System.String __VarSurrenderEmail;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_Surrender")]
        internal PortType_Surrender Port_Surrender;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_SurrenderFile")]
        internal PortType_SurrenderFile Port_SurrenderFile;
        [Microsoft.XLANGs.BaseTypes.PhysicalBindingAttribute(typeof(Microsoft.BizTalk.DefaultPipelines.XMLTransmit))]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eDynamic
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_SurrenderEmail")]
        internal PortType_SurrenderEmail Port_SurrenderEmail;  // lock index = 0

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Surrender.Surrender},
                                               typeof(OrchSurrender).GetField("Port_Surrender", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchSurrender), "Port_Surrender"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SurrenderFile.SurrenderFile},
                                               typeof(OrchSurrender).GetField("Port_SurrenderFile", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchSurrender), "Port_SurrenderFile"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SurrenderEmail.SurrenderEmail},
                                               typeof(OrchSurrender).GetField("Port_SurrenderEmail", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               true,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(OrchSurrender), "Port_SurrenderEmail"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                h[_portInfo[2].Name] = _portInfo[2];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "e1d95b29-20f9-478f-916a-7bf744bf1984", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "e1d95b29-20f9-478f-916a-7bf744bf1984", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "00000000-0000-0000-0000-000000000000", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "26da2753-dafd-44a9-8426-8075b6aa1f1c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "24cb38ce-9944-438f-aa5e-3aecda880c84", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "24cb38ce-9944-438f-aa5e-3aecda880c84", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "ef8e5ba0-de56-4e6d-afc4-40f9e2638729", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "af471a81-effb-4e46-877f-1ea0f8e79ea1", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "af471a81-effb-4e46-877f-1ea0f8e79ea1", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "c0ef235f-5549-4f9b-b7ee-11dadbba185c", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "c0ef235f-5549-4f9b-b7ee-11dadbba185c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "71b475c9-812f-4d3e-a060-d58a5b0504ae", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "71b475c9-812f-4d3e-a060-d58a5b0504ae", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "aa2b17ad-072a-4eee-b2ef-0192f37789ae", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "aa2b17ad-072a-4eee-b2ef-0192f37789ae", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "228ecbcc-14e7-44b9-9184-be8cc4e91c90", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "228ecbcc-14e7-44b9-9184-be8cc4e91c90", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "ef73ffd6-fc71-4af3-a820-5746f44c3373", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "ef73ffd6-fc71-4af3-a820-5746f44c3373", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "ef8e5ba0-de56-4e6d-afc4-40f9e2638729", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "ed1c768e-48fc-4be9-be55-df6bd10bd908", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "ed1c768e-48fc-4be9-be55-df6bd10bd908", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "26da2753-dafd-44a9-8426-8075b6aa1f1c", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "6fd93a67-1eaf-42ab-8932-5cec738b610a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "6fd93a67-1eaf-42ab-8932-5cec738b610a", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.If),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,3,3,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,2,4,4,5,5,6,7,7,8,8,9,10,10,10,11,12,12,13,14,14,14,15,16,16,17,7,18,18,19,20,4,21,21,22,23,24,24,24,25,3,3,3,3,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __OrchSurrender_1 __ctx1__ = (__OrchSurrender_1)_stateMgrs[1];
            __OrchSurrender_root_0 __ctx0__ = (__OrchSurrender_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Port_Surrender = new PortType_Surrender(0, this);
                Port_SurrenderFile = new PortType_SurrenderFile(1, this);
                Port_SurrenderEmail = new PortType_SurrenderEmail(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_Surrender, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __OrchSurrender_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            bool __condition__;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __OrchSurrender_1 __ctx1__ = (__OrchSurrender_1)_stateMgrs[1];
            __OrchSurrender_root_0 __ctx0__ = (__OrchSurrender_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__VarSurrenderEmail = default(System.String);
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Port_Surrender.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Msg_SurrenderIn != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderIn);
                __ctx1__.__Msg_SurrenderIn = new __messagetype_ScootAceHT_SchSurrenderIn("Msg_SurrenderIn", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Msg_SurrenderIn);
                Port_Surrender.ReceiveMessage(0, __msgEnv__, __ctx1__.__Msg_SurrenderIn, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderIn);
                    __edata.PortName = @"Port_Surrender";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                __ctx1__.__VarSurrenderEmail = "";
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[4],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __condition__ = ((System.String)__ctx1__.__Msg_SurrenderIn.part.GetDistinguishedField("SaleInfo.UserName") == "aceif" && (System.String)__ctx1__.__Msg_SurrenderIn.part.GetDistinguishedField("SaleInfo.Password") == "ace.interface");
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 36;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    __messagetype_ScootAceHT_SchSurrenderIn __Msg_SurrenderGetPlyNo = new __messagetype_ScootAceHT_SchSurrenderIn("Msg_SurrenderGetPlyNo", __ctx1__);

                    ApplyTransform(typeof(ScootAceHT.MapSurrenderGetPlyNo), new object[] {__Msg_SurrenderGetPlyNo.part}, new object[] {__ctx1__.__Msg_SurrenderIn.part});

                    if (__ctx1__.__Msg_SurrenderGetPlyNo != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderGetPlyNo);
                    __ctx1__.__Msg_SurrenderGetPlyNo = __Msg_SurrenderGetPlyNo;
                    __ctx1__.RefMessage(__ctx1__.__Msg_SurrenderGetPlyNo);
                }
                __ctx1__.__Msg_SurrenderGetPlyNo.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderGetPlyNo);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderIn);
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __condition__ = (System.String)__ctx1__.__Msg_SurrenderGetPlyNo.part.GetDistinguishedField("General.PolicyNo") != @"PlyNO Not Found!";
                if (!__condition__)
                {
                    if ( !PostProgressInc( __seg__, __ctx__, 31 ) )
                        return Microsoft.XLANGs.Core.StopConditions.Paused;
                    goto case 31;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    __messagetype_System_Xml_XmlDocument __Msg_SurrenderFile = new __messagetype_System_Xml_XmlDocument("Msg_SurrenderFile", __ctx1__);

                    __Msg_SurrenderFile.CopyFrom(__ctx1__.__Msg_SurrenderGetPlyNo);
                    __Msg_SurrenderFile.SetPropertyValue(typeof(FILE.ReceivedFileName), (System.String)__ctx1__.__Msg_SurrenderGetPlyNo.part.GetDistinguishedField("General.PolicyNo"));

                    if (__ctx1__.__Msg_SurrenderFile != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderFile);
                    __ctx1__.__Msg_SurrenderFile = __Msg_SurrenderFile;
                    __ctx1__.RefMessage(__ctx1__.__Msg_SurrenderFile);
                }
                __ctx1__.__Msg_SurrenderFile.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderFile);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_SurrenderFile.SendMessage(0, __ctx1__.__Msg_SurrenderFile, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderFile);
                    __edata.PortName = @"Port_SurrenderFile";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderFile != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderFile);
                    __ctx1__.__Msg_SurrenderFile = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                {
                    __messagetype_System_Xml_XmlDocument __Msg_SurrenderEmail = new __messagetype_System_Xml_XmlDocument("Msg_SurrenderEmail", __ctx1__);

                    __ctx1__.__VarSurrenderEmail = @"
                        感谢投保太桦保险
                        
                        我们知道您已经取消了保单号码为[{0}]的保单。
                        
                        如您需要重新购买你的保险或对你的保单有任何问题，请致电我们的客户服务专员热线：
                        热线号码： 4006095509 （7*24小时）
                        
                        感谢您对太桦的信任和支持,希望在今后能继续为您提供服务。
                        
                        您真诚的
                        太桦财产保险有限公司
                        
                        这是一个电脑自动生成的信函，请不要直接回复。
                        
                        Thank you for insuring with TaiWa.
                        
                        We acknowledged that you have cancelled your policy.  The policy number is [{0}].
                        
                        Should you wish to reinstate your policy or if you have further questions regarding your policy, 
                        please contact our Customer Relations Officer at Hotline: 4006095509 (7 days*24-hour)
                        
                        Thank you for your trust and support in TaiWa, We look forward to serving you in future.
                        
                        Yours sincerely,
                        TaiWa Property & Casualty Insurance Co., Ltd
                        
                        This is a computer generated letter and please do not reply directly.
                        
                        ";
                    __ctx1__.__VarSurrenderEmail = System.String.Format(__ctx1__.__VarSurrenderEmail, (System.String)__ctx1__.__Msg_SurrenderGetPlyNo.part.GetDistinguishedField("General.PolicyNo"));
                    __Msg_SurrenderEmail.CopyFrom(__ctx1__.__Msg_SurrenderGetPlyNo);
                    Port_SurrenderEmail.SetPropertyValue(typeof(Microsoft.XLANGs.BaseTypes.Address), @"mailto:" + (System.String)__ctx1__.__Msg_SurrenderGetPlyNo.part.GetDistinguishedField("Applicant.ApplicantEmail"));
                    __Msg_SurrenderEmail.SetPropertyValue(typeof(SMTP.EmailBodyTextCharset), "UTF-8");
                    __Msg_SurrenderEmail.SetPropertyValue(typeof(SMTP.Subject), "太桦保险保单取消通知 TaiWa Insurance policy cancellation confirmation");
                    __Msg_SurrenderEmail.SetPropertyValue(typeof(SMTP.EmailBodyText), __ctx1__.__VarSurrenderEmail);
                    __Msg_SurrenderEmail.SetPropertyValue(typeof(SMTP.From), "pi_ace_commerce@eTaiWa.com");
                    __Msg_SurrenderEmail.SetPropertyValue(typeof(SMTP.SMTPHost), "local.mail.eTaiWa.com");
                    __Msg_SurrenderEmail.SetPropertyValue(typeof(SMTP.Username), "pi_ace_commerce");
                    __Msg_SurrenderEmail.SetPropertyValue(typeof(SMTP.Password), "******");
                    __Msg_SurrenderEmail.SetPropertyValue(typeof(SMTP.SMTPAuthenticate), (System.UInt32)(0U));

                    if (__ctx1__.__Msg_SurrenderEmail != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderEmail);
                    __ctx1__.__Msg_SurrenderEmail = __Msg_SurrenderEmail;
                    __ctx1__.RefMessage(__ctx1__.__Msg_SurrenderEmail);
                }
                __ctx1__.__Msg_SurrenderEmail.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderEmail);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_SurrenderEmail.SendMessage(0, __ctx1__.__Msg_SurrenderEmail, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderEmail);
                    __edata.PortName = @"Port_SurrenderEmail";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderEmail != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderEmail);
                    __ctx1__.__Msg_SurrenderEmail = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                {
                    __messagetype_ScootAceHT_SchSurrenderResponse __Msg_SurrenderResponse = new __messagetype_ScootAceHT_SchSurrenderResponse("Msg_SurrenderResponse", __ctx1__);

                    ApplyTransform(typeof(ScootAceHT.MapSurrenderResponse), new object[] {__Msg_SurrenderResponse.part}, new object[] {__ctx1__.__Msg_SurrenderGetPlyNo.part});

                    if (__ctx1__.__Msg_SurrenderResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderResponse);
                    __ctx1__.__Msg_SurrenderResponse = __Msg_SurrenderResponse;
                    __ctx1__.RefMessage(__ctx1__.__Msg_SurrenderResponse);
                }
                __ctx1__.__Msg_SurrenderResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderResponse);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderGetPlyNo);
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                {
                    __messagetype_ScootAceHT_SchSurrenderResponse __Msg_SurrenderResponse = new __messagetype_ScootAceHT_SchSurrenderResponse("Msg_SurrenderResponse", __ctx1__);

                    ApplyTransform(typeof(ScootAceHT.MapSurrenderNoPlyNo), new object[] {__Msg_SurrenderResponse.part}, new object[] {__ctx1__.__Msg_SurrenderIn.part});

                    if (__ctx1__.__Msg_SurrenderResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderResponse);
                    __ctx1__.__Msg_SurrenderResponse = __Msg_SurrenderResponse;
                    __ctx1__.RefMessage(__ctx1__.__Msg_SurrenderResponse);
                }
                __ctx1__.__Msg_SurrenderResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderResponse);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderIn);
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderGetPlyNo != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderGetPlyNo);
                    __ctx1__.__Msg_SurrenderGetPlyNo = null;
                }
                Tracker.FireEvent(__eventLocations[20],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                {
                    __messagetype_ScootAceHT_SchSurrenderResponse __Msg_SurrenderResponse = new __messagetype_ScootAceHT_SchSurrenderResponse("Msg_SurrenderResponse", __ctx1__);

                    ApplyTransform(typeof(ScootAceHT.MapSurrenderError), new object[] {__Msg_SurrenderResponse.part}, new object[] {__ctx1__.__Msg_SurrenderIn.part});

                    if (__ctx1__.__Msg_SurrenderResponse != null)
                        __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderResponse);
                    __ctx1__.__Msg_SurrenderResponse = __Msg_SurrenderResponse;
                    __ctx1__.RefMessage(__ctx1__.__Msg_SurrenderResponse);
                }
                __ctx1__.__Msg_SurrenderResponse.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderResponse);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderIn);
                    Tracker.FireEvent(__eventLocations[22],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__VarSurrenderEmail = null;
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderIn != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderIn);
                    __ctx1__.__Msg_SurrenderIn = null;
                }
                if (Port_SurrenderEmail != null)
                {
                    Port_SurrenderEmail.Close(__ctx1__, __seg__);
                    Port_SurrenderEmail = null;
                }
                if (Port_SurrenderFile != null)
                {
                    Port_SurrenderFile.Close(__ctx1__, __seg__);
                    Port_SurrenderFile = null;
                }
                Tracker.FireEvent(__eventLocations[23],__eventData[5],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                if ( !PreProgressInc( __seg__, __ctx__, 41 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[4],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 41;
            case 41:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 42;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_Surrender.SendMessage(0, __ctx1__.__Msg_SurrenderResponse, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Port_Surrender != null)
                {
                    Port_Surrender.Close(__ctx1__, __seg__);
                    Port_Surrender = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Msg_SurrenderResponse);
                    __edata.PortName = @"Port_Surrender";
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Msg_SurrenderResponse != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Msg_SurrenderResponse);
                    __ctx1__.__Msg_SurrenderResponse = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[6],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 47;
            case 47:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __ScootAceHT_SchIssue2File__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static ScootAceHT.SchIssue2File _schema = new ScootAceHT.SchIssue2File();

        public __ScootAceHT_SchIssue2File__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "ScootAceHT.SchIssue2File",
        new System.Type[]{
            typeof(ScootAceHT.SchIssue2File)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__ScootAceHT_SchIssue2File__)
        },
        0,
        @"PolicyForm"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_ScootAceHT_SchIssue2File : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __ScootAceHT_SchIssue2File__ part;

        private void __CreatePartWrappers()
        {
            part = new __ScootAceHT_SchIssue2File__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_ScootAceHT_SchIssue2File(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
