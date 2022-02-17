namespace ScootAceHT
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class RecPipeSurrender : Microsoft.BizTalk.PipelineOM.ReceivePipeline
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
"perty Name=\"DocumentSpecName\">              <Value xsi:type=\"xsd:string\">ScootAceHT.SchSurrenderIn</"+
"Value>            </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">             "+
" <Value xsi:type=\"xsd:string\">http://ScootAceHT.SchSurrenderIn</Value>            </Property>       "+
"     <Property Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">DocumentSpecTarget"+
"Namespaces</Value>            </Property>            <Property Name=\"RecoverableInterchangeProcessin"+
"g\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>          </Prope"+
"rties>          <CachedDisplayName>XML validator</CachedDisplayName>          <CachedIsManaged>true<"+
"/CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStag"+
"e _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" s"+
"tageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Documen"+
"t>";
        
        private const string _versionDependentGuid = "23327882-1b52-4e7f-9d34-5555ea11c25f";
        
        public RecPipeSurrender()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlValidator,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"DocumentSpecNam"+
"e\">      <Value xsi:type=\"xsd:string\">ScootAceHT.SchSurrenderIn</Value>    </Property>    <Property "+
"Name=\"DocumentSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://ScootAceHT.SchSurrende"+
"rIn</Value>    </Property>    <Property Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">D"+
"ocumentSpecTargetNamespaces</Value>    </Property>    <Property Name=\"RecoverableInterchangeProcessi"+
"ng\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>  </Properties></PropertyBag>";
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
