namespace ScootAceHT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://ScootAceHT.SchIssueIn.eTaiWa",@"ApplyForm")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ApplyForm"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"ScootAceHT.PropertySchema.PropertySchema", typeof(ScootAceHT.PropertySchema.PropertySchema))]
    public sealed class SchIssueIn : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns0=""https://ScootAceHT.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns=""http://ScootAceHT.SchIssueIn.eTaiWa"" elementFormDefault=""qualified"" targetNamespace=""http://ScootAceHT.SchIssueIn.eTaiWa"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://ScootAceHT.PropertySchema"" location=""ScootAceHT.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ApplyForm"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""1"" maxOccurs=""1"" form=""qualified"" name=""General"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ApplyTime"" type=""xs:dateTime"" />
              <xs:element name=""InsuranceCode"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:minLength value=""4"" />
                    <xs:maxLength value=""36"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""InsuranceName"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:minLength value=""1"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""InsurancePlan"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:minLength value=""1"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""AgentCode"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:minLength value=""1"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""DepartmentCode"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:minLength value=""3"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""EffectiveTime"" type=""xs:dateTime"" />
              <xs:element name=""TerminalTime"" type=""xs:dateTime"" />
              <xs:element name=""Copy"" type=""xs:int"" />
              <xs:element name=""Currency"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:enumeration value=""ADF"" />
                    <xs:enumeration value=""ADP"" />
                    <xs:enumeration value=""AED"" />
                    <xs:enumeration value=""AFA"" />
                    <xs:enumeration value=""ALL"" />
                    <xs:enumeration value=""ANG"" />
                    <xs:enumeration value=""AON"" />
                    <xs:enumeration value=""ARS"" />
                    <xs:enumeration value=""AUD"" />
                    <xs:enumeration value=""AWG"" />
                    <xs:enumeration value=""BBD"" />
                    <xs:enumeration value=""BDT"" />
                    <xs:enumeration value=""BGN"" />
                    <xs:enumeration value=""BHD"" />
                    <xs:enumeration value=""BIF"" />
                    <xs:enumeration value=""BMD"" />
                    <xs:enumeration value=""BND"" />
                    <xs:enumeration value=""BOB"" />
                    <xs:enumeration value=""BRL"" />
                    <xs:enumeration value=""BSD"" />
                    <xs:enumeration value=""BTN"" />
                    <xs:enumeration value=""BWP"" />
                    <xs:enumeration value=""BZD"" />
                    <xs:enumeration value=""CAD"" />
                    <xs:enumeration value=""CHF"" />
                    <xs:enumeration value=""CLP"" />
                    <xs:enumeration value=""CNY"" />
                    <xs:enumeration value=""COP"" />
                    <xs:enumeration value=""CRC"" />
                    <xs:enumeration value=""CSD"" />
                    <xs:enumeration value=""CUP"" />
                    <xs:enumeration value=""CVE"" />
                    <xs:enumeration value=""CYP"" />
                    <xs:enumeration value=""CZK"" />
                    <xs:enumeration value=""DJF"" />
                    <xs:enumeration value=""DKK"" />
                    <xs:enumeration value=""DOP"" />
                    <xs:enumeration value=""DZD"" />
                    <xs:enumeration value=""ECS"" />
                    <xs:enumeration value=""EEK"" />
                    <xs:enumeration value=""EGP"" />
                    <xs:enumeration value=""ETB"" />
                    <xs:enumeration value=""EUR"" />
                    <xs:enumeration value=""FJD"" />
                    <xs:enumeration value=""FKP"" />
                    <xs:enumeration value=""GBP"" />
                    <xs:enumeration value=""GHC"" />
                    <xs:enumeration value=""GIP"" />
                    <xs:enumeration value=""GMD"" />
                    <xs:enumeration value=""GNF"" />
                    <xs:enumeration value=""GTQ"" />
                    <xs:enumeration value=""GYD"" />
                    <xs:enumeration value=""HKD"" />
                    <xs:enumeration value=""HNL"" />
                    <xs:enumeration value=""HRK"" />
                    <xs:enumeration value=""HTG"" />
                    <xs:enumeration value=""HUF"" />
                    <xs:enumeration value=""IDR"" />
                    <xs:enumeration value=""ILS"" />
                    <xs:enumeration value=""INR"" />
                    <xs:enumeration value=""IQD"" />
                    <xs:enumeration value=""IRR"" />
                    <xs:enumeration value=""ISK"" />
                    <xs:enumeration value=""JMD"" />
                    <xs:enumeration value=""JOD"" />
                    <xs:enumeration value=""JPY"" />
                    <xs:enumeration value=""KES"" />
                    <xs:enumeration value=""KHR"" />
                    <xs:enumeration value=""KMF"" />
                    <xs:enumeration value=""KRW"" />
                    <xs:enumeration value=""KWD"" />
                    <xs:enumeration value=""KYD"" />
                    <xs:enumeration value=""KZT"" />
                    <xs:enumeration value=""LAK"" />
                    <xs:enumeration value=""LBP"" />
                    <xs:enumeration value=""LKR"" />
                    <xs:enumeration value=""LRD"" />
                    <xs:enumeration value=""LSL"" />
                    <xs:enumeration value=""LTL"" />
                    <xs:enumeration value=""LVL"" />
                    <xs:enumeration value=""LYD"" />
                    <xs:enumeration value=""MAD"" />
                    <xs:enumeration value=""MGA"" />
                    <xs:enumeration value=""MGF"" />
                    <xs:enumeration value=""MMK"" />
                    <xs:enumeration value=""MNT"" />
                    <xs:enumeration value=""MOP"" />
                    <xs:enumeration value=""MRO"" />
                    <xs:enumeration value=""MTL"" />
                    <xs:enumeration value=""MUR"" />
                    <xs:enumeration value=""MVR"" />
                    <xs:enumeration value=""MWK"" />
                    <xs:enumeration value=""MXN"" />
                    <xs:enumeration value=""MYR"" />
                    <xs:enumeration value=""MZM"" />
                    <xs:enumeration value=""NAD"" />
                    <xs:enumeration value=""NGN"" />
                    <xs:enumeration value=""NIO"" />
                    <xs:enumeration value=""NOK"" />
                    <xs:enumeration value=""NPR"" />
                    <xs:enumeration value=""NZD"" />
                    <xs:enumeration value=""OMR"" />
                    <xs:enumeration value=""PAB"" />
                    <xs:enumeration value=""PEN"" />
                    <xs:enumeration value=""PGK"" />
                    <xs:enumeration value=""PHP"" />
                    <xs:enumeration value=""PKR"" />
                    <xs:enumeration value=""PLN"" />
                    <xs:enumeration value=""PYG"" />
                    <xs:enumeration value=""QAR"" />
                    <xs:enumeration value=""ROL"" />
                    <xs:enumeration value=""RON"" />
                    <xs:enumeration value=""RUB"" />
                    <xs:enumeration value=""SAR"" />
                    <xs:enumeration value=""SBD"" />
                    <xs:enumeration value=""SCR"" />
                    <xs:enumeration value=""SDD"" />
                    <xs:enumeration value=""SDP"" />
                    <xs:enumeration value=""SEK"" />
                    <xs:enumeration value=""SGD"" />
                    <xs:enumeration value=""SHP"" />
                    <xs:enumeration value=""SIT"" />
                    <xs:enumeration value=""SKK"" />
                    <xs:enumeration value=""SLL"" />
                    <xs:enumeration value=""SOS"" />
                    <xs:enumeration value=""SRD"" />
                    <xs:enumeration value=""SRG"" />
                    <xs:enumeration value=""STD"" />
                    <xs:enumeration value=""SVC"" />
                    <xs:enumeration value=""SYP"" />
                    <xs:enumeration value=""SZL"" />
                    <xs:enumeration value=""THB"" />
                    <xs:enumeration value=""TND"" />
                    <xs:enumeration value=""TOP"" />
                    <xs:enumeration value=""TRL"" />
                    <xs:enumeration value=""TRY"" />
                    <xs:enumeration value=""TTD"" />
                    <xs:enumeration value=""TWD"" />
                    <xs:enumeration value=""TZS"" />
                    <xs:enumeration value=""UAH"" />
                    <xs:enumeration value=""UGS"" />
                    <xs:enumeration value=""USD"" />
                    <xs:enumeration value=""UYP"" />
                    <xs:enumeration value=""VEB"" />
                    <xs:enumeration value=""VND"" />
                    <xs:enumeration value=""VUV"" />
                    <xs:enumeration value=""WST"" />
                    <xs:enumeration value=""YER"" />
                    <xs:enumeration value=""YUN"" />
                    <xs:enumeration value=""ZAR"" />
                    <xs:enumeration value=""ZMK"" />
                    <xs:enumeration value=""ZWD"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""Premium"" type=""xs:decimal"" />
              <xs:element name=""TotalPremium"" type=""xs:decimal"" />
              <xs:element name=""AceNo"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" form=""qualified"" name=""SaleInfo"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""UserName"" type=""xs:string"" />
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Password"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" form=""qualified"" name=""Applicant"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ApplicantFirstname"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""200"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ApplicantLastname"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""200"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ApplicantGender"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:enumeration value=""F"" />
                    <xs:enumeration value=""M"" />
                    <xs:enumeration value=""X"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ApplicantBirthday"" type=""xs:date"" />
              <xs:element name=""ApplicantIDType"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:enumeration value=""01"" />
                    <xs:enumeration value=""02"" />
                    <xs:enumeration value=""03"" />
                    <xs:enumeration value=""04"" />
                    <xs:enumeration value=""05"" />
                    <xs:enumeration value=""06"" />
                    <xs:enumeration value=""07"" />
                    <xs:enumeration value=""08"" />
                    <xs:enumeration value=""20"" />
                    <xs:enumeration value=""96"" />
                    <xs:enumeration value=""97"" />
                    <xs:enumeration value=""98"" />
                    <xs:enumeration value=""99"" />
                    <xs:enumeration value=""9X"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ApplicantID"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""100"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ApplicantPhone"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""50"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ApplicantCell"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""50"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ApplicantZip"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""20"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element name=""ApplicantAddress"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""300"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
              <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ApplicantEmail"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"">
                    <xs:maxLength value=""100"" />
                    <xs:minLength value=""1"" />
                  </xs:restriction>
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" form=""qualified"" name=""InsuredList"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" form=""qualified"" name=""Insured"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""InsuredFirstname"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:maxLength value=""200"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredLastname"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:maxLength value=""200"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredGender"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:enumeration value=""F"" />
                          <xs:enumeration value=""M"" />
                          <xs:enumeration value=""X"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredBirthday"" type=""xs:date"" />
                    <xs:element name=""InsuredIDType"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:enumeration value=""01"" />
                          <xs:enumeration value=""02"" />
                          <xs:enumeration value=""03"" />
                          <xs:enumeration value=""04"" />
                          <xs:enumeration value=""05"" />
                          <xs:enumeration value=""06"" />
                          <xs:enumeration value=""07"" />
                          <xs:enumeration value=""08"" />
                          <xs:enumeration value=""20"" />
                          <xs:enumeration value=""96"" />
                          <xs:enumeration value=""97"" />
                          <xs:enumeration value=""98"" />
                          <xs:enumeration value=""99"" />
                          <xs:enumeration value=""9X"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredID"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:maxLength value=""100"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredPhone"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:maxLength value=""50"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredCell"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:maxLength value=""50"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredZip"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:maxLength value=""20"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredAddress"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:maxLength value=""300"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""InsuredEmail"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
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
        <xs:element minOccurs=""1"" maxOccurs=""1"" form=""qualified"" name=""Coverage"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""CoverageItem"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""CoverageCode"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:length value=""2"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""CoverageDetail"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:whiteSpace value=""preserve"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""CoverageCurrency"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:enumeration value=""ADF"" />
                          <xs:enumeration value=""ADP"" />
                          <xs:enumeration value=""AED"" />
                          <xs:enumeration value=""AFA"" />
                          <xs:enumeration value=""ALL"" />
                          <xs:enumeration value=""ANG"" />
                          <xs:enumeration value=""AON"" />
                          <xs:enumeration value=""ARS"" />
                          <xs:enumeration value=""AUD"" />
                          <xs:enumeration value=""AWG"" />
                          <xs:enumeration value=""BBD"" />
                          <xs:enumeration value=""BDT"" />
                          <xs:enumeration value=""BGN"" />
                          <xs:enumeration value=""BHD"" />
                          <xs:enumeration value=""BIF"" />
                          <xs:enumeration value=""BMD"" />
                          <xs:enumeration value=""BND"" />
                          <xs:enumeration value=""BOB"" />
                          <xs:enumeration value=""BRL"" />
                          <xs:enumeration value=""BSD"" />
                          <xs:enumeration value=""BTN"" />
                          <xs:enumeration value=""BWP"" />
                          <xs:enumeration value=""BZD"" />
                          <xs:enumeration value=""CAD"" />
                          <xs:enumeration value=""CHF"" />
                          <xs:enumeration value=""CLP"" />
                          <xs:enumeration value=""CNY"" />
                          <xs:enumeration value=""COP"" />
                          <xs:enumeration value=""CRC"" />
                          <xs:enumeration value=""CSD"" />
                          <xs:enumeration value=""CUP"" />
                          <xs:enumeration value=""CVE"" />
                          <xs:enumeration value=""CYP"" />
                          <xs:enumeration value=""CZK"" />
                          <xs:enumeration value=""DJF"" />
                          <xs:enumeration value=""DKK"" />
                          <xs:enumeration value=""DOP"" />
                          <xs:enumeration value=""DZD"" />
                          <xs:enumeration value=""ECS"" />
                          <xs:enumeration value=""EEK"" />
                          <xs:enumeration value=""EGP"" />
                          <xs:enumeration value=""ETB"" />
                          <xs:enumeration value=""EUR"" />
                          <xs:enumeration value=""FJD"" />
                          <xs:enumeration value=""FKP"" />
                          <xs:enumeration value=""GBP"" />
                          <xs:enumeration value=""GHC"" />
                          <xs:enumeration value=""GIP"" />
                          <xs:enumeration value=""GMD"" />
                          <xs:enumeration value=""GNF"" />
                          <xs:enumeration value=""GTQ"" />
                          <xs:enumeration value=""GYD"" />
                          <xs:enumeration value=""HKD"" />
                          <xs:enumeration value=""HNL"" />
                          <xs:enumeration value=""HRK"" />
                          <xs:enumeration value=""HTG"" />
                          <xs:enumeration value=""HUF"" />
                          <xs:enumeration value=""IDR"" />
                          <xs:enumeration value=""ILS"" />
                          <xs:enumeration value=""INR"" />
                          <xs:enumeration value=""IQD"" />
                          <xs:enumeration value=""IRR"" />
                          <xs:enumeration value=""ISK"" />
                          <xs:enumeration value=""JMD"" />
                          <xs:enumeration value=""JOD"" />
                          <xs:enumeration value=""JPY"" />
                          <xs:enumeration value=""KES"" />
                          <xs:enumeration value=""KHR"" />
                          <xs:enumeration value=""KMF"" />
                          <xs:enumeration value=""KRW"" />
                          <xs:enumeration value=""KWD"" />
                          <xs:enumeration value=""KYD"" />
                          <xs:enumeration value=""KZT"" />
                          <xs:enumeration value=""LAK"" />
                          <xs:enumeration value=""LBP"" />
                          <xs:enumeration value=""LKR"" />
                          <xs:enumeration value=""LRD"" />
                          <xs:enumeration value=""LSL"" />
                          <xs:enumeration value=""LTL"" />
                          <xs:enumeration value=""LVL"" />
                          <xs:enumeration value=""LYD"" />
                          <xs:enumeration value=""MAD"" />
                          <xs:enumeration value=""MGA"" />
                          <xs:enumeration value=""MGF"" />
                          <xs:enumeration value=""MMK"" />
                          <xs:enumeration value=""MNT"" />
                          <xs:enumeration value=""MOP"" />
                          <xs:enumeration value=""MRO"" />
                          <xs:enumeration value=""MTL"" />
                          <xs:enumeration value=""MUR"" />
                          <xs:enumeration value=""MVR"" />
                          <xs:enumeration value=""MWK"" />
                          <xs:enumeration value=""MXN"" />
                          <xs:enumeration value=""MYR"" />
                          <xs:enumeration value=""MZM"" />
                          <xs:enumeration value=""NAD"" />
                          <xs:enumeration value=""NGN"" />
                          <xs:enumeration value=""NIO"" />
                          <xs:enumeration value=""NOK"" />
                          <xs:enumeration value=""NPR"" />
                          <xs:enumeration value=""NZD"" />
                          <xs:enumeration value=""OMR"" />
                          <xs:enumeration value=""PAB"" />
                          <xs:enumeration value=""PEN"" />
                          <xs:enumeration value=""PGK"" />
                          <xs:enumeration value=""PHP"" />
                          <xs:enumeration value=""PKR"" />
                          <xs:enumeration value=""PLN"" />
                          <xs:enumeration value=""PYG"" />
                          <xs:enumeration value=""QAR"" />
                          <xs:enumeration value=""ROL"" />
                          <xs:enumeration value=""RON"" />
                          <xs:enumeration value=""RUB"" />
                          <xs:enumeration value=""SAR"" />
                          <xs:enumeration value=""SBD"" />
                          <xs:enumeration value=""SCR"" />
                          <xs:enumeration value=""SDD"" />
                          <xs:enumeration value=""SDP"" />
                          <xs:enumeration value=""SEK"" />
                          <xs:enumeration value=""SGD"" />
                          <xs:enumeration value=""SHP"" />
                          <xs:enumeration value=""SIT"" />
                          <xs:enumeration value=""SKK"" />
                          <xs:enumeration value=""SLL"" />
                          <xs:enumeration value=""SOS"" />
                          <xs:enumeration value=""SRD"" />
                          <xs:enumeration value=""SRG"" />
                          <xs:enumeration value=""STD"" />
                          <xs:enumeration value=""SVC"" />
                          <xs:enumeration value=""SYP"" />
                          <xs:enumeration value=""SZL"" />
                          <xs:enumeration value=""THB"" />
                          <xs:enumeration value=""TND"" />
                          <xs:enumeration value=""TOP"" />
                          <xs:enumeration value=""TRL"" />
                          <xs:enumeration value=""TRY"" />
                          <xs:enumeration value=""TTD"" />
                          <xs:enumeration value=""TWD"" />
                          <xs:enumeration value=""TZS"" />
                          <xs:enumeration value=""UAH"" />
                          <xs:enumeration value=""UGS"" />
                          <xs:enumeration value=""USD"" />
                          <xs:enumeration value=""UYP"" />
                          <xs:enumeration value=""VEB"" />
                          <xs:enumeration value=""VND"" />
                          <xs:enumeration value=""VUV"" />
                          <xs:enumeration value=""WST"" />
                          <xs:enumeration value=""YER"" />
                          <xs:enumeration value=""YUN"" />
                          <xs:enumeration value=""ZAR"" />
                          <xs:enumeration value=""ZMK"" />
                          <xs:enumeration value=""ZWD"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                    <xs:element name=""CoverageSumInsured"" type=""xs:decimal"" />
                    <xs:element name=""CoverageMemo"">
                      <xs:simpleType>
                        <xs:restriction base=""xs:string"">
                          <xs:whiteSpace value=""preserve"" />
                        </xs:restriction>
                      </xs:simpleType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""1"" maxOccurs=""1"" form=""qualified"" name=""Addons"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Route"" type=""xs:string"" />
              <xs:element name=""Departure"" type=""xs:string"" />
              <xs:element name=""Destination"" type=""xs:string"" />
              <xs:element name=""Traffic"" type=""xs:string"" />
              <xs:element name=""Ticket"" type=""xs:string"" />
              <xs:element name=""IMPK"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public SchIssueIn() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ApplyForm";
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
