namespace ScootAceHT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ScootAceHT.SchSurrenderIn",@"SurrenderForm")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SaleInfo.UserName", XPath = @"/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='SaleInfo' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='UserName' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "SaleInfo.Password", XPath = @"/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='SaleInfo' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='Password' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "General.PolicyNo", XPath = @"/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='General' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='PolicyNo' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "General.AceNo", XPath = @"/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='General' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='AceNo' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "Applicant.ApplicantEmail", XPath = @"/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='Applicant' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='ApplicantEmail' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SurrenderForm"})]
    public sealed class SchSurrenderIn : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://ScootAceHT.SchSurrenderIn"" elementFormDefault=""qualified"" targetNamespace=""http://ScootAceHT.SchSurrenderIn"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""SurrenderForm"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='SaleInfo' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='UserName' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='SaleInfo' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='Password' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='General' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='PolicyNo' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='General' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='AceNo' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='SurrenderForm' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='Applicant' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']/*[local-name()='ApplicantEmail' and namespace-uri()='http://ScootAceHT.SchSurrenderIn']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element form=""qualified"" name=""General"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SurrenderTime"" type=""xs:dateTime"" />
              <xs:element name=""PolicyNo"" type=""xs:string"" />
              <xs:element name=""AceNo"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:minLength value=""1"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element form=""qualified"" name=""SaleInfo"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""UserName"" type=""xs:string"" />
              <xs:element name=""Password"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element form=""qualified"" name=""Applicant"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ApplicantEmail"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:minLength value=""1"" />
                    <xs:maxLength value=""100"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SchSurrenderIn() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "SurrenderForm";
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
