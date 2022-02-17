namespace ScootAceHT
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class RecPipeWS : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" N"+
"ame=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040"+
"674ad6\" />      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlValida"+
"tor,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856"+
"ad364e35</Name>          <ComponentName>XML validator</ComponentName>          <Description>XML vali"+
"dator component.</Description>          <Version>1.0</Version>          <Properties>            <Pro"+
"perty Name=\"DocumentSpecName\">              <Value xsi:type=\"xsd:string\">ScootAceHT.SchIssueIn|Scoot"+
"AceHT.SchSurrenderIn</Value>            </Property>            <Property Name=\"DocumentSpecTargetNam"+
"espaces\">              <Value xsi:type=\"xsd:string\">http://ScootAceHT.SchIssueIn.eTaiWa http://Scoo"+
"tAceHT.SchSurrenderIn</Value>            </Property>            <Property Name=\"HiddenProperties\">  "+
"            <Value xsi:type=\"xsd:string\">DocumentSpecTargetNamespaces</Value>            </Property>"+
"            <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:boo"+
"lean\">false</Value>            </Property>          </Properties>          <CachedDisplayName>XML va"+
"lidator</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>    "+
"  </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"Re"+
"solveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674"+
"ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "933c53aa-da7a-435a-bdfb-eb407f776ca8";
        
        public RecPipeWS()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlValidator,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"DocumentSpecNam"+
"e\">      <Value xsi:type=\"xsd:string\">ScootAceHT.SchIssueIn|ScootAceHT.SchSurrenderIn</Value>    </P"+
"roperty>    <Property Name=\"DocumentSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://"+
"ScootAceHT.SchIssueIn.eTaiWa http://ScootAceHT.SchSurrenderIn</Value>    </Property>    <Property N"+
"ame=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">DocumentSpecTargetNamespaces</Value>    </"+
"Property>    <Property Name=\"RecoverableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">f"+
"alse</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
