namespace ScootAceHT {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchIssue2File", typeof(ScootAceHT.SchIssue2File))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchIssueResponse", typeof(ScootAceHT.SchIssueResponse))]
    public sealed class MapApplyResponse : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://ScootAceHT.SchIssueResponse"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/PolicyForm"" />
  </xsl:template>
  <xsl:template match=""/PolicyForm"">
    <xsl:variable name=""var:v1"" select=""&quot;1&quot;"" />
    <xsl:variable name=""var:v2"" select=""&quot;Success&quot;"" />
    <xsl:variable name=""var:v3"" select=""&quot;成功&quot;"" />
    <ns0:IssueResponse>
      <ns0:IssueResponseCode>
        <xsl:value-of select=""$var:v1"" />
      </ns0:IssueResponseCode>
      <ns0:IssueResponseEN>
        <xsl:value-of select=""$var:v2"" />
      </ns0:IssueResponseEN>
      <ns0:IssueResponseCN>
        <xsl:value-of select=""$var:v3"" />
      </ns0:IssueResponseCN>
      <ns0:IssuePolicyNo>
        <xsl:value-of select=""General/PolicyNo/text()"" />
      </ns0:IssuePolicyNo>
      <ns0:IssuePdfURL>
        <xsl:value-of select=""General/PdfUrl/text()"" />
      </ns0:IssuePdfURL>
      <xsl:value-of select=""./text()"" />
    </ns0:IssueResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ScootAceHT.SchIssue2File";
        
        private const string _strTrgSchemasList0 = @"ScootAceHT.SchIssueResponse";
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"ScootAceHT.SchIssue2File";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ScootAceHT.SchIssueResponse";
                return _TrgSchemas;
            }
        }
    }
}
