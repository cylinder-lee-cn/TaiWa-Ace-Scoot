namespace ScootAceHT {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchSurrenderIn", typeof(ScootAceHT.SchSurrenderIn))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchSurrenderIn", typeof(ScootAceHT.SchSurrenderIn))]
    public sealed class MapSurrenderGetPlyNo : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://ScootAceHT.SchSurrenderIn"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:SurrenderForm"" />
  </xsl:template>
  <xsl:template match=""/ns0:SurrenderForm"">
    <ns0:SurrenderForm>
      <ns0:General>
        <ns0:SurrenderTime>
          <xsl:value-of select=""ns0:General/ns0:SurrenderTime/text()"" />
        </ns0:SurrenderTime>
        <xsl:variable name=""var:v1"" select=""userCSharp:GetPlyNo(string(ns0:General/ns0:AceNo/text()))"" />
        <ns0:PolicyNo>
          <xsl:value-of select=""$var:v1"" />
        </ns0:PolicyNo>
        <ns0:AceNo>
          <xsl:value-of select=""ns0:General/ns0:AceNo/text()"" />
        </ns0:AceNo>
        <xsl:value-of select=""ns0:General/text()"" />
      </ns0:General>
      <ns0:SaleInfo>
        <ns0:UserName>
          <xsl:value-of select=""ns0:SaleInfo/ns0:UserName/text()"" />
        </ns0:UserName>
        <ns0:Password>
          <xsl:value-of select=""ns0:SaleInfo/ns0:Password/text()"" />
        </ns0:Password>
        <xsl:value-of select=""ns0:SaleInfo/text()"" />
      </ns0:SaleInfo>
      <ns0:Applicant>
        <ns0:ApplicantEmail>
          <xsl:value-of select=""ns0:Applicant/ns0:ApplicantEmail/text()"" />
        </ns0:ApplicantEmail>
        <xsl:value-of select=""ns0:Applicant/text()"" />
      </ns0:Applicant>
    </ns0:SurrenderForm>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string GetPlyNo(string AceNo)
{
    string PlyNo=@""PlyNO Not Found!"";
    string XmlFilePath=@""F:\WWW\ScootXMLFile\localuser\scoot\Issue\"";
    //string XmlFilePath=@""\\10.1.1.118\htscoot\Scoot\Issue\"";
    XmlFilePath=XmlFilePath+AceNo+"".xml"";
    if (System.IO.File.Exists(XmlFilePath))
   {
        System.Xml.XmlDocument xmlSurrender= new XmlDocument();   
        xmlSurrender.Load(XmlFilePath);
        System.Xml.XmlNode nodePlyNO = xmlSurrender.SelectSingleNode(""/PolicyForm/General/PolicyNo"");
        PlyNo=nodePlyNO.InnerText;
    }
  
        return PlyNo;

}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ScootAceHT.SchSurrenderIn";
        
        private const string _strTrgSchemasList0 = @"ScootAceHT.SchSurrenderIn";
        
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
                _TrgSchemas[0] = @"ScootAceHT.SchSurrenderIn";
                return _TrgSchemas;
            }
        }
    }
}
