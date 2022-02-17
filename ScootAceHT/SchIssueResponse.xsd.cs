namespace ScootAceHT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ScootAceHT.SchIssueResponse",@"IssueResponse")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"IssueResponse"})]
    public sealed class SchIssueResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://ScootAceHT.SchIssueResponse"" elementFormDefault=""qualified"" targetNamespace=""http://ScootAceHT.SchIssueResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""IssueResponse"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""IssueResponseCode"" type=""xs:string"" />
        <xs:element name=""IssueResponseEN"" type=""xs:string"" />
        <xs:element name=""IssueResponseCN"" type=""xs:string"" />
        <xs:element name=""IssuePolicyNo"" type=""xs:string"" />
        <xs:element name=""IssuePdfURL"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SchIssueResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "IssueResponse";
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
