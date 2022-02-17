namespace ScootAceHT {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchIssueIn", typeof(ScootAceHT.SchIssueIn))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchIssue2File", typeof(ScootAceHT.SchIssue2File))]
    public sealed class MapApplyIn2File : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://ScootAceHT.SchIssueIn.eTaiWa"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ApplyForm"" />
  </xsl:template>
  <xsl:template match=""/s0:ApplyForm"">
    <xsl:variable name=""var:v2"" select=""string(s0:General/s0:AceNo/text())"" />
    <xsl:variable name=""var:v4"" select=""count(/s0:ApplyForm/s0:InsuredList/s0:Insured)"" />
    <PolicyForm>
      <General>
        <ApplyTime>
          <xsl:value-of select=""s0:General/s0:ApplyTime/text()"" />
        </ApplyTime>
        <InsuranceCode>
          <xsl:value-of select=""s0:General/s0:InsuranceCode/text()"" />
        </InsuranceCode>
        <InsuranceName>
          <xsl:value-of select=""s0:General/s0:InsuranceName/text()"" />
        </InsuranceName>
        <InsurancePlan>
          <xsl:value-of select=""s0:General/s0:InsurancePlan/text()"" />
        </InsurancePlan>
        <AgentCode>
          <xsl:value-of select=""s0:General/s0:AgentCode/text()"" />
        </AgentCode>
        <DepartmentCode>
          <xsl:value-of select=""s0:General/s0:DepartmentCode/text()"" />
        </DepartmentCode>
        <EffectiveTime>
          <xsl:value-of select=""s0:General/s0:EffectiveTime/text()"" />
        </EffectiveTime>
        <TerminalTime>
          <xsl:value-of select=""s0:General/s0:TerminalTime/text()"" />
        </TerminalTime>
        <Copy>
          <xsl:value-of select=""s0:General/s0:Copy/text()"" />
        </Copy>
        <Currency>
          <xsl:value-of select=""s0:General/s0:Currency/text()"" />
        </Currency>
        <Premium>
          <xsl:value-of select=""s0:General/s0:Premium/text()"" />
        </Premium>
        <TotalPremium>
          <xsl:value-of select=""s0:General/s0:TotalPremium/text()"" />
        </TotalPremium>
        <xsl:variable name=""var:v1"" select=""userCSharp:plyNo(string(s0:General/s0:AceNo/text()))"" />
        <PolicyNo>
          <xsl:value-of select=""$var:v1"" />
        </PolicyNo>
        <xsl:variable name=""var:v3"" select=""userCSharp:pdfURL(string(s0:SaleInfo/s0:UserName/text()) , string(s0:SaleInfo/s0:Password/text()) , string(s0:General/s0:InsuranceCode/text()) , $var:v2)"" />
        <PdfUrl>
          <xsl:value-of select=""$var:v3"" />
        </PdfUrl>
        <AceNo>
          <xsl:value-of select=""s0:General/s0:AceNo/text()"" />
        </AceNo>
        <xsl:value-of select=""s0:General/text()"" />
      </General>
      <SaleInfo>
        <UserName>
          <xsl:value-of select=""s0:SaleInfo/s0:UserName/text()"" />
        </UserName>
        <Password>
          <xsl:value-of select=""s0:SaleInfo/s0:Password/text()"" />
        </Password>
        <xsl:value-of select=""s0:SaleInfo/text()"" />
      </SaleInfo>
      <Applicant>
        <ApplicantFirstname>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantFirstname/text()"" />
        </ApplicantFirstname>
        <ApplicantLastname>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantLastname/text()"" />
        </ApplicantLastname>
        <ApplicantGender>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantGender/text()"" />
        </ApplicantGender>
        <ApplicantBirthday>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantBirthday/text()"" />
        </ApplicantBirthday>
        <ApplicantIDType>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantIDType/text()"" />
        </ApplicantIDType>
        <ApplicantID>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantID/text()"" />
        </ApplicantID>
        <ApplicantPhone>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantPhone/text()"" />
        </ApplicantPhone>
        <ApplicantCell>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantCell/text()"" />
        </ApplicantCell>
        <ApplicantZip>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantZip/text()"" />
        </ApplicantZip>
        <ApplicantAddress>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantAddress/text()"" />
        </ApplicantAddress>
        <ApplicantEmail>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantEmail/text()"" />
        </ApplicantEmail>
        <xsl:value-of select=""s0:Applicant/text()"" />
      </Applicant>
      <InsuredList>
        <xsl:attribute name=""InsuredCount"">
          <xsl:value-of select=""$var:v4"" />
        </xsl:attribute>
        <xsl:for-each select=""s0:InsuredList/s0:Insured"">
          <Insured>
            <InsuredFirstname>
              <xsl:value-of select=""s0:InsuredFirstname/text()"" />
            </InsuredFirstname>
            <InsuredLastname>
              <xsl:value-of select=""s0:InsuredLastname/text()"" />
            </InsuredLastname>
            <InsuredGender>
              <xsl:value-of select=""s0:InsuredGender/text()"" />
            </InsuredGender>
            <InsuredBirthday>
              <xsl:value-of select=""s0:InsuredBirthday/text()"" />
            </InsuredBirthday>
            <InsuredIDType>
              <xsl:value-of select=""s0:InsuredIDType/text()"" />
            </InsuredIDType>
            <InsuredID>
              <xsl:value-of select=""s0:InsuredID/text()"" />
            </InsuredID>
            <InsuredPhone>
              <xsl:value-of select=""s0:InsuredPhone/text()"" />
            </InsuredPhone>
            <InsuredCell>
              <xsl:value-of select=""s0:InsuredCell/text()"" />
            </InsuredCell>
            <InsuredZip>
              <xsl:value-of select=""s0:InsuredZip/text()"" />
            </InsuredZip>
            <InsuredAddress>
              <xsl:value-of select=""s0:InsuredAddress/text()"" />
            </InsuredAddress>
            <InsuredEmail>
              <xsl:value-of select=""s0:InsuredEmail/text()"" />
            </InsuredEmail>
            <xsl:value-of select=""./text()"" />
          </Insured>
        </xsl:for-each>
        <xsl:value-of select=""s0:InsuredList/text()"" />
      </InsuredList>
      <Coverage>
        <xsl:for-each select=""s0:Coverage/s0:CoverageItem"">
          <CoverageItem>
            <CoverageCode>
              <xsl:value-of select=""s0:CoverageCode/text()"" />
            </CoverageCode>
            <CoverageDetail>
              <xsl:value-of select=""s0:CoverageDetail/text()"" />
            </CoverageDetail>
            <CoverageCurrency>
              <xsl:value-of select=""s0:CoverageCurrency/text()"" />
            </CoverageCurrency>
            <CoverageSumInsured>
              <xsl:value-of select=""s0:CoverageSumInsured/text()"" />
            </CoverageSumInsured>
            <CoverageMemo>
              <xsl:value-of select=""s0:CoverageMemo/text()"" />
            </CoverageMemo>
            <xsl:value-of select=""./text()"" />
          </CoverageItem>
        </xsl:for-each>
        <xsl:value-of select=""s0:Coverage/text()"" />
      </Coverage>
      <Addons>
        <Route>
          <xsl:value-of select=""s0:Addons/s0:Route/text()"" />
        </Route>
        <Departure>
          <xsl:value-of select=""s0:Addons/s0:Departure/text()"" />
        </Departure>
        <Destination>
          <xsl:value-of select=""s0:Addons/s0:Destination/text()"" />
        </Destination>
        <Traffic>
          <xsl:value-of select=""s0:Addons/s0:Traffic/text()"" />
        </Traffic>
        <Ticket>
          <xsl:value-of select=""s0:Addons/s0:Ticket/text()"" />
        </Ticket>
        <IMPK>
          <xsl:value-of select=""s0:Addons/s0:IMPK/text()"" />
        </IMPK>
        <xsl:value-of select=""s0:Addons/text()"" />
      </Addons>
      <xsl:value-of select=""./text()"" />
    </PolicyForm>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string plyNo(string AceNo)
{
	string strPlyNo=""SAH"";
	string XmlFilePath=@""F:\WWW\ScootXMLFile\localuser\scoot\Issue\"";
                //string XmlFilePath=@""\\10.1.1.118\htscoot\Scoot\Issue\"";
	XmlFilePath=XmlFilePath+AceNo+"".xml"";
	if (System.IO.File.Exists(XmlFilePath))
   	{
        System.Xml.XmlDocument xmlSurrender= new XmlDocument();   
        xmlSurrender.Load(XmlFilePath);
        System.Xml.XmlNode nodePlyNO = xmlSurrender.SelectSingleNode(""/PolicyForm/General/PolicyNo"");
        strPlyNo=nodePlyNO.InnerText;
    }
    else
    {
	    //strPlyNo=strPlyNo+System.DateTime.Now.ToString(""yyMMddHHmmssffff"");
                    strPlyNo=strPlyNo+System.DateTime.Now.ToString(""yyMMdd"")+AceNo.Remove(0,AceNo.Length-10);
    }
    return strPlyNo;
   
}

string str_BaseUrl = @""http://219.141.242.33/ACETHT/getpdf.aspx?paras="";
//string str_BaseUrl = @""http://202.108.103.130/ACETHT/getpdf.aspx?paras="";
public string pdfURL(string str_Usr, string str_Pwd, string str_InsCde ,string str_PlyNo)
{
    string str_Paras = str_Usr + ""|"" + str_Pwd + ""|"" + str_InsCde + ""|"" + str_PlyNo;
    //Base64 encoding
    byte[] byteString = System.Text.Encoding.GetEncoding(""UTF-8"").GetBytes(str_Paras);
    str_Paras = Convert.ToBase64String(byteString);

    string str_pdfUrl = str_BaseUrl + str_Paras;
    return str_pdfUrl;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"ScootAceHT.SchIssueIn";
        
        private const string _strTrgSchemasList0 = @"ScootAceHT.SchIssue2File";
        
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
                _SrcSchemas[0] = @"ScootAceHT.SchIssueIn";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"ScootAceHT.SchIssue2File";
                return _TrgSchemas;
            }
        }
    }
}
