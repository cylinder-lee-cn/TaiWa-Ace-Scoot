namespace ScootAceHT {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchIssueIn", typeof(ScootAceHT.SchIssueIn))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.SchIssue2File", typeof(ScootAceHT.SchIssue2File))]
    public sealed class MapApplyIn2File : Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://ScootAceHT.SchIssueIn.eTaiWa"" xmlns:ns0=""http://ScootAceHT.SchIssue2File.eTaiWa"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:ApplyForm"" />
  </xsl:template>
  <xsl:template match=""/s0:ApplyForm"">
    <xsl:variable name=""var:v2"" select=""&quot;http://myurl.com/a.pdf&quot;"" />
    <ns0:ApplyForm>
      <ns0:General>
        <ns0:ApplyTime>
          <xsl:value-of select=""s0:General/s0:ApplyTime/text()"" />
        </ns0:ApplyTime>
        <xsl:for-each select=""s0:General/s0:InsuranceCode"">
          <ns0:InsuranceCode>
            <xsl:value-of select=""./text()"" />
          </ns0:InsuranceCode>
        </xsl:for-each>
        <xsl:for-each select=""s0:General/s0:InsuranceName"">
          <ns0:InsuranceName>
            <xsl:value-of select=""./text()"" />
          </ns0:InsuranceName>
        </xsl:for-each>
        <xsl:for-each select=""s0:General/s0:InsurancePlan"">
          <ns0:InsurancePlan>
            <xsl:value-of select=""./text()"" />
          </ns0:InsurancePlan>
        </xsl:for-each>
        <ns0:DepartmentCode>
          <xsl:value-of select=""s0:General/s0:DepartmentCode/text()"" />
        </ns0:DepartmentCode>
        <ns0:EffectiveTime>
          <xsl:value-of select=""s0:General/s0:EffectiveTime/text()"" />
        </ns0:EffectiveTime>
        <ns0:TerminalTime>
          <xsl:value-of select=""s0:General/s0:TerminalTime/text()"" />
        </ns0:TerminalTime>
        <ns0:Copy>
          <xsl:value-of select=""s0:General/s0:Copy/text()"" />
        </ns0:Copy>
        <ns0:Currency>
          <xsl:value-of select=""s0:General/s0:Currency/text()"" />
        </ns0:Currency>
        <ns0:Premium>
          <xsl:value-of select=""s0:General/s0:Premium/text()"" />
        </ns0:Premium>
        <ns0:TotalPremium>
          <xsl:value-of select=""s0:General/s0:TotalPremium/text()"" />
        </ns0:TotalPremium>
        <xsl:variable name=""var:v1"" select=""userCSharp:aNewGuid()"" />
        <ns0:PolicyNo>
          <xsl:value-of select=""$var:v1"" />
        </ns0:PolicyNo>
        <ns0:PdfUrl>
          <xsl:value-of select=""$var:v2"" />
        </ns0:PdfUrl>
        <xsl:value-of select=""s0:General/text()"" />
      </ns0:General>
      <ns0:SaleInfo>
        <ns0:UserName>
          <xsl:value-of select=""s0:SaleInfo/s0:UserName/text()"" />
        </ns0:UserName>
        <ns0:Password>
          <xsl:value-of select=""s0:SaleInfo/s0:Password/text()"" />
        </ns0:Password>
        <xsl:value-of select=""s0:SaleInfo/text()"" />
      </ns0:SaleInfo>
      <ns0:Applicant>
        <ns0:ApplicantFirstname>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantFirstname/text()"" />
        </ns0:ApplicantFirstname>
        <ns0:ApplicantLastname>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantLastname/text()"" />
        </ns0:ApplicantLastname>
        <ns0:ApplicantGender>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantGender/text()"" />
        </ns0:ApplicantGender>
        <ns0:ApplicantBirthday>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantBirthday/text()"" />
        </ns0:ApplicantBirthday>
        <ns0:ApplicantIDType>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantIDType/text()"" />
        </ns0:ApplicantIDType>
        <ns0:ApplicantID>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantID/text()"" />
        </ns0:ApplicantID>
        <ns0:ApplicantPhone>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantPhone/text()"" />
        </ns0:ApplicantPhone>
        <ns0:ApplicantCell>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantCell/text()"" />
        </ns0:ApplicantCell>
        <ns0:ApplicantZip>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantZip/text()"" />
        </ns0:ApplicantZip>
        <ns0:ApplicantAddress>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantAddress/text()"" />
        </ns0:ApplicantAddress>
        <ns0:ApplicantEmail>
          <xsl:value-of select=""s0:Applicant/s0:ApplicantEmail/text()"" />
        </ns0:ApplicantEmail>
        <xsl:value-of select=""s0:Applicant/text()"" />
      </ns0:Applicant>
      <xsl:for-each select=""s0:InsuredList"">
        <ns0:InsuredList>
          <ns0:InsuredFirstname>
            <xsl:value-of select=""s0:InsuredFirstname/text()"" />
          </ns0:InsuredFirstname>
          <ns0:InsuredLastname>
            <xsl:value-of select=""s0:InsuredLastname/text()"" />
          </ns0:InsuredLastname>
          <ns0:InsuredGender>
            <xsl:value-of select=""s0:InsuredGender/text()"" />
          </ns0:InsuredGender>
          <ns0:InsuredBirthday>
            <xsl:value-of select=""s0:InsuredBirthday/text()"" />
          </ns0:InsuredBirthday>
          <ns0:InsuredIDType>
            <xsl:value-of select=""s0:InsuredIDType/text()"" />
          </ns0:InsuredIDType>
          <ns0:InsuredID>
            <xsl:value-of select=""s0:InsuredID/text()"" />
          </ns0:InsuredID>
          <ns0:InsuredPhone>
            <xsl:value-of select=""s0:InsuredPhone/text()"" />
          </ns0:InsuredPhone>
          <ns0:InsuredCell>
            <xsl:value-of select=""s0:InsuredCell/text()"" />
          </ns0:InsuredCell>
          <ns0:InsuredZip>
            <xsl:value-of select=""s0:InsuredZip/text()"" />
          </ns0:InsuredZip>
          <ns0:InsuredAddress>
            <xsl:value-of select=""s0:InsuredAddress/text()"" />
          </ns0:InsuredAddress>
          <ns0:InsuredEmail>
            <xsl:value-of select=""s0:InsuredEmail/text()"" />
          </ns0:InsuredEmail>
          <xsl:value-of select=""./text()"" />
        </ns0:InsuredList>
      </xsl:for-each>
      <ns0:Coverage>
        <xsl:for-each select=""s0:Coverage/s0:CoverageItem"">
          <ns0:CoverageItem>
            <ns0:CoverageCode>
              <xsl:value-of select=""s0:CoverageCode/text()"" />
            </ns0:CoverageCode>
            <ns0:CoverageDetail>
              <xsl:value-of select=""s0:CoverageDetail/text()"" />
            </ns0:CoverageDetail>
            <ns0:CoverageCurrency>
              <xsl:value-of select=""s0:CoverageCurrency/text()"" />
            </ns0:CoverageCurrency>
            <ns0:CoverageSumInsured>
              <xsl:value-of select=""s0:CoverageSumInsured/text()"" />
            </ns0:CoverageSumInsured>
            <ns0:CoverageMemo>
              <xsl:value-of select=""s0:CoverageMemo/text()"" />
            </ns0:CoverageMemo>
            <xsl:value-of select=""./text()"" />
          </ns0:CoverageItem>
        </xsl:for-each>
        <xsl:value-of select=""s0:Coverage/text()"" />
      </ns0:Coverage>
      <xsl:for-each select=""s0:Addons"">
        <ns0:Addons>
          <ns0:Route>
            <xsl:value-of select=""s0:Route/text()"" />
          </ns0:Route>
          <ns0:Departure>
            <xsl:value-of select=""s0:Departure/text()"" />
          </ns0:Departure>
          <ns0:Destination>
            <xsl:value-of select=""s0:Destination/text()"" />
          </ns0:Destination>
          <ns0:Traffic>
            <xsl:value-of select=""s0:Traffic/text()"" />
          </ns0:Traffic>
          <ns0:Ticket>
            <xsl:value-of select=""s0:Ticket/text()"" />
          </ns0:Ticket>
          <ns0:IMPK>
            <xsl:value-of select=""s0:IMPK/text()"" />
          </ns0:IMPK>
          <xsl:value-of select=""./text()"" />
        </ns0:Addons>
      </xsl:for-each>
      <xsl:for-each select=""s0:DataExtensions"">
        <ns0:DataExtensions>
          <xsl:for-each select=""s0:DataItem"">
            <ns0:DataItem>
              <xsl:attribute name=""ns0:ItemKey"">
                <xsl:value-of select=""@s0:ItemKey"" />
              </xsl:attribute>
              <xsl:attribute name=""ns0:ItemType"">
                <xsl:value-of select=""@s0:ItemType"" />
              </xsl:attribute>
              <xsl:value-of select=""./text()"" />
            </ns0:DataItem>
          </xsl:for-each>
          <xsl:value-of select=""./text()"" />
        </ns0:DataExtensions>
      </xsl:for-each>
    </ns0:ApplyForm>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

//public string MyConcat(string param1, string param2)
//{
//	return param1+param2;
//}

public string aNewGuid()
{
     return System.Guid.NewGuid().ToString(""N"");
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
