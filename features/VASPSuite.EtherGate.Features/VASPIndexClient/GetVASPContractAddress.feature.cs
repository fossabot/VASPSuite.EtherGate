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
namespace VASPSuite.EtherGate.Features.VASPIndexClient
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Get VASP contract address")]
    public partial class GetVASPContractAddressFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetVASPContractAddress.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "VASPIndexClient", "Get VASP contract address", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
      testRunner.And("VASP with a code c28d7646 created a VASP contract with an address 0x23F66130a8808" +
                    "950AcD3956DB6092a4E19608D0A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 6
      testRunner.And("then 100 blocks were mined", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
      testRunner.And("VASP with a code 5bf89160 created a VASP contract with an address 0xD6C3FE9953074" +
                    "Db4a29Cc5aDb1d101b51236bBB8", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling GetVASPContractAddressAsync method of a VASPIndexClient")]
        [NUnit.Framework.TestCaseAttribute("5bf89160", "0", "0xD6C3FE9953074Db4a29Cc5aDb1d101b51236bBB8", null)]
        [NUnit.Framework.TestCaseAttribute("5bf89160", "100", "0x0000000000000000000000000000000000000000", null)]
        [NUnit.Framework.TestCaseAttribute("c28d7646", "0", "0x23F66130a8808950AcD3956DB6092a4E19608D0A", null)]
        [NUnit.Framework.TestCaseAttribute("c28d7646", "100", "0x23F66130a8808950AcD3956DB6092a4E19608D0A", null)]
        [NUnit.Framework.TestCaseAttribute("4a86b7ba", "0", "0x0000000000000000000000000000000000000000", null)]
        public virtual void CallingGetVASPContractAddressAsyncMethodOfAVASPIndexClient(string vaspCode, string minimalConfirmationLevel, string vaspContractAddress, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("vaspCode", vaspCode);
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("vaspContractAddress", vaspContractAddress);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling GetVASPContractAddressAsync method of a VASPIndexClient", null, tagsOfScenario, argumentsOfScenario);
#line 9
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
#line 10
    testRunner.When(string.Format("I call GetVASPContractAddressAsync method of a VASPIndexClient with a following p" +
                            "arameters: \"{0}\", \"{1}\"", vaspCode, minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
    testRunner.Then(string.Format("the GetVASPContractAddressAsync call result should be \"{0}\"", vaspContractAddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling TryGetVASPContractAddressAsync method of a VASPIndexClient")]
        [NUnit.Framework.TestCaseAttribute("5bf89160", "0", "true", "0xD6C3FE9953074Db4a29Cc5aDb1d101b51236bBB8", null)]
        [NUnit.Framework.TestCaseAttribute("5bf89160", "100", "false", "0x0000000000000000000000000000000000000000", null)]
        [NUnit.Framework.TestCaseAttribute("c28d7646", "0", "true", "0x23F66130a8808950AcD3956DB6092a4E19608D0A", null)]
        [NUnit.Framework.TestCaseAttribute("c28d7646", "100", "true", "0x23F66130a8808950AcD3956DB6092a4E19608D0A", null)]
        [NUnit.Framework.TestCaseAttribute("4a86b7ba", "0", "false", "0x0000000000000000000000000000000000000000", null)]
        public virtual void CallingTryGetVASPContractAddressAsyncMethodOfAVASPIndexClient(string vaspCode, string minimalConfirmationLevel, string vaspIsRegistered, string vaspContractAddress, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("vaspCode", vaspCode);
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("vaspIsRegistered", vaspIsRegistered);
            argumentsOfScenario.Add("vaspContractAddress", vaspContractAddress);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling TryGetVASPContractAddressAsync method of a VASPIndexClient", null, tagsOfScenario, argumentsOfScenario);
#line 21
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
#line 22
    testRunner.When(string.Format("I call TryGetVASPContractAddressAsync method of a VASPIndexClient with a followin" +
                            "g parameters: \"{0}\", \"{1}\"", vaspCode, minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
    testRunner.Then(string.Format("the TryGetVASPContractAddressAsync call result should be (\"{0}\", \"{1}\")", vaspIsRegistered, vaspContractAddress), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion