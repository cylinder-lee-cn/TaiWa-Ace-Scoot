namespace ScootAceHT {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchSurrenderIn", typeof(ScootAceHT.SchSurrenderIn))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchSurrenderResponse", typeof(ScootAceHT.SchSurrenderResponse))]
    public sealed class MapSurrenderResponse : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://ScootAceHT.SchSurrenderResponse"" xmlns:s0=""http://ScootAceHT.SchSurrenderIn"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:SurrenderForm"" />
  </xsl:template>
  <xsl:template match=""/s0:SurrenderForm"">
    <xsl:variable name=""var:v1"" select=""&quot;1&quot;"" />
    <xsl:variable name=""var:v2"" select=""&quot;Success&quot;"" />
    <xsl:variable name=""var:v3"" select=""&quot;成功&quot;"" />
    <ns0:SurrenderResponse>
      <ns0:SurrenderResponseCode>
        <xsl:value-of select=""$var:v1"" />
      </ns0:SurrenderResponseCode>
      <ns0:SurrenderResponseEN>
        <xsl:value-of select=""$var:v2"" />
      </ns0:SurrenderResponseEN>
      <ns0:SurrenderResponseCN>
        <xsl:value-of select=""$var:v3"" />
      </ns0:SurrenderResponseCN>
      <ns0:SurrenderPolicyNo>
        <xsl:value-of select=""s0:General/s0:PolicyNo/text()"" />
      </ns0:SurrenderPolicyNo>
      <ns0:SurrenderAceNo>
        <xsl:value-of select=""s0:General/s0:AceNo/text()"" />
      </ns0:SurrenderAceNo>
    </ns0:SurrenderResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ScootAceHT.SchSurrenderIn";
        
        private const string _strTrgSchemasList0 = @"ScootAceHT.SchSurrenderResponse";
        
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
                _SrcSchemas[0] = @"ScootAceHT.SchSurrenderIn";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ScootAceHT.SchSurrenderResponse";
                return _TrgSchemas;
            }
        }
    }
}
