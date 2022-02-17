namespace ScootAceHT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ScootAceHT.SchSurrenderResponse",@"SurrenderResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SurrenderResponse"})]
    public sealed class SchSurrenderResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://ScootAceHT.SchSurrenderResponse"" elementFormDefault=""qualified"" targetNamespace=""http://ScootAceHT.SchSurrenderResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SurrenderResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""SurrenderResponseCode"" type=""xs:string"" />
        <xs:element name=""SurrenderResponseEN"" type=""xs:string"" />
        <xs:element name=""SurrenderResponseCN"" type=""xs:string"" />
        <xs:element name=""SurrenderPolicyNo"" type=""xs:string"" />
        <xs:element name=""SurrenderAceNo"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SchSurrenderResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SurrenderResponse";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
