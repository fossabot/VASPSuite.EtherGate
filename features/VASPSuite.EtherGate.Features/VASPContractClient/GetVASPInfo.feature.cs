﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace VASPSuite.EtherGate.Features.VASPContractClient
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Get VASP info")]
    public partial class GetVASPInfoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetVASPInfo.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "VASPContractClient", "Get VASP info", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
  #line hidden
#line 4
    testRunner.Given("VASPIndex smart contract was deployed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
      testRunner.And("VASP with a code c28d7646 created a VASP contract", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 6
      testRunner.And("VASP set its contract channels to 0x00000001", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
      testRunner.And("VASP set its contract message key to 0x030b92658a44acd5d608be37beecc15e6c2c3c8021" +
                    "5f8f1ae20cd6292e1f20fe4d", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
      testRunner.And("VASP set its contract signing key to 0x02196d0b08a258f6a8041c867d248cab1dcdef473e" +
                    "5069cdb15c64b7998449594a", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
      testRunner.And("VASP set its contract transport key to 0x02a780672d5d7ce6ae295908eb43b3831fe6d0d0" +
                    "341555b1be40526a0da5e954c2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
      testRunner.And("then 100 blocks were mined", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
      testRunner.And("VASP set its contract message key to 0x0224c8cc4021e06ef493157f5be5358bfc2ca18053" +
                    "4b3cfa49281e1647bc7e2373", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
      testRunner.And("VASP set its contract signing key to 0x03047107117e5c30ec0dfe00ef3e15e3940734e751" +
                    "cf9d38610ed4c8797383a75a", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
      testRunner.And("VASP set its contract transport key to 0x03e09bd332934bab62b79c943fd274e8b41f969c" +
                    "11b4d41f19401e2efd383a1a23", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling GetChannelsAsync method of a VASPContractClient")]
        [NUnit.Framework.TestCaseAttribute("0", "0x00000001", null)]
        [NUnit.Framework.TestCaseAttribute("100", "0x00000001", null)]
        public virtual void CallingGetChannelsAsyncMethodOfAVASPContractClient(string minimalConfirmationLevel, string channels, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("channels", channels);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling GetChannelsAsync method of a VASPContractClient", null, tagsOfScenario, argumentsOfScenario);
#line 15
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 16
    testRunner.When(string.Format("I call GetChannelsAsync method of a VASPContractClient with a following parameter" +
                            ": \"{0}\"", minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
    testRunner.Then(string.Format("the GetChannelsAsync call result should be \"{0}\"", channels), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling GetMessageKeyAsync method of a VASPContractClient")]
        [NUnit.Framework.TestCaseAttribute("0", "0x0224c8cc4021e06ef493157f5be5358bfc2ca180534b3cfa49281e1647bc7e2373", null)]
        [NUnit.Framework.TestCaseAttribute("100", "0x030b92658a44acd5d608be37beecc15e6c2c3c80215f8f1ae20cd6292e1f20fe4d", null)]
        public virtual void CallingGetMessageKeyAsyncMethodOfAVASPContractClient(string minimalConfirmationLevel, string messageKey, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("messageKey", messageKey);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling GetMessageKeyAsync method of a VASPContractClient", null, tagsOfScenario, argumentsOfScenario);
#line 24
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 25
    testRunner.When(string.Format("I call GetMessageKeyAsync method of a VASPContractClient with a following paramet" +
                            "er: \"{0}\"", minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
    testRunner.Then(string.Format("the GetMessageKeyAsync call result should be \"{0}\"", messageKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling GetSigningKeyAsync method of a VASPContractClient")]
        [NUnit.Framework.TestCaseAttribute("0", "0x03047107117e5c30ec0dfe00ef3e15e3940734e751cf9d38610ed4c8797383a75a", null)]
        [NUnit.Framework.TestCaseAttribute("100", "0x02196d0b08a258f6a8041c867d248cab1dcdef473e5069cdb15c64b7998449594a", null)]
        public virtual void CallingGetSigningKeyAsyncMethodOfAVASPContractClient(string minimalConfirmationLevel, string signingKey, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("signingKey", signingKey);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling GetSigningKeyAsync method of a VASPContractClient", null, tagsOfScenario, argumentsOfScenario);
#line 33
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 34
    testRunner.When(string.Format("I call GetSigningKeyAsync method of a VASPContractClient with a following paramet" +
                            "er: \"{0}\"", minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
    testRunner.Then(string.Format("the GetSigningKeyAsync call result should be \"{0}\"", signingKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling GetTransportKeyAsync method of a VASPContractClient")]
        [NUnit.Framework.TestCaseAttribute("0", "0x03e09bd332934bab62b79c943fd274e8b41f969c11b4d41f19401e2efd383a1a23", null)]
        [NUnit.Framework.TestCaseAttribute("100", "0x02a780672d5d7ce6ae295908eb43b3831fe6d0d0341555b1be40526a0da5e954c2", null)]
        public virtual void CallingGetTransportKeyAsyncMethodOfAVASPContractClient(string minimalConfirmationLevel, string transportKey, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("transportKey", transportKey);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling GetTransportKeyAsync method of a VASPContractClient", null, tagsOfScenario, argumentsOfScenario);
#line 42
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 43
    testRunner.When(string.Format("I call GetTransportKeyAsync method of a VASPContractClient with a following param" +
                            "eter: \"{0}\"", minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
    testRunner.Then(string.Format("the GetTransportKeyAsync call result should be \"{0}\"", transportKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling GetVASPCodeAsync method of a VASPContractClient")]
        [NUnit.Framework.TestCaseAttribute("0", "c28d7646", null)]
        [NUnit.Framework.TestCaseAttribute("100", "c28d7646", null)]
        public virtual void CallingGetVASPCodeAsyncMethodOfAVASPContractClient(string minimalConfirmationLevel, string vaspCode, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("vaspCode", vaspCode);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling GetVASPCodeAsync method of a VASPContractClient", null, tagsOfScenario, argumentsOfScenario);
#line 51
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 52
    testRunner.When(string.Format("I call GetVASPCodeAsync method of a VASPContractClient with a following parameter" +
                            ": \"{0}\"", minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
    testRunner.Then(string.Format("the GetVASPCodeAsync call result should be \"{0}\"", vaspCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling GetVASPInfoAsync method of a VASPContractClient")]
        [NUnit.Framework.TestCaseAttribute("0", "0x00000001", "c28d7646", "0x0224c8cc4021e06ef493157f5be5358bfc2ca180534b3cfa49281e1647bc7e2373", "0x03047107117e5c30ec0dfe00ef3e15e3940734e751cf9d38610ed4c8797383a75a", "0x03e09bd332934bab62b79c943fd274e8b41f969c11b4d41f19401e2efd383a1a23", null)]
        [NUnit.Framework.TestCaseAttribute("100", "0x00000001", "c28d7646", "0x030b92658a44acd5d608be37beecc15e6c2c3c80215f8f1ae20cd6292e1f20fe4d", "0x02196d0b08a258f6a8041c867d248cab1dcdef473e5069cdb15c64b7998449594a", "0x02a780672d5d7ce6ae295908eb43b3831fe6d0d0341555b1be40526a0da5e954c2", null)]
        public virtual void CallingGetVASPInfoAsyncMethodOfAVASPContractClient(string minimalConfirmationLevel, string channels, string vaspCode, string messageKey, string signingKey, string transportKey, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("channels", channels);
            argumentsOfScenario.Add("vaspCode", vaspCode);
            argumentsOfScenario.Add("messageKey", messageKey);
            argumentsOfScenario.Add("signingKey", signingKey);
            argumentsOfScenario.Add("transportKey", transportKey);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling GetVASPInfoAsync method of a VASPContractClient", null, tagsOfScenario, argumentsOfScenario);
#line 60
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
  this.FeatureBackground();
#line hidden
#line 61
    testRunner.When(string.Format("I call GetVASPInfoAsync method of a VASPContractClient with a following parameter" +
                            ": \"{0}\"", minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
    testRunner.Then(string.Format("the Channels property of the GetVASPInfoAsync call result should be \"{0}\"", channels), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
     testRunner.And(string.Format("the VASPCode property of the GetVASPInfoAsync call result should be \"{0}\"", vaspCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
     testRunner.And(string.Format("the MessageKey property of the GetVASPInfoAsync call result should be \"{0}\"", messageKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
     testRunner.And(string.Format("the SigningKey property of the GetVASPInfoAsync call result should be \"{0}\"", signingKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
     testRunner.And(string.Format("the TransportKey property of the GetVASPInfoAsync call result should be \"{0}\"", transportKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
