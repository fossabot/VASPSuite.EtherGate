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
namespace VASPSuite.EtherGate.Features.VASPDirectoryClient
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Get VASP credentials reference and hash")]
    public partial class GetVASPCredentialsReferenceAndHashFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "GetVASPCredentialsReferenceAndHash.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "VASPDirectoryClient", "Get VASP credentials reference and hash", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
    testRunner.Given("VASPDirectory smart contract was deployed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
      testRunner.And("directory administrator added credentials from \"Examples/Credentials/f00000000001" +
                    ".json\" for the VASP with id \"f00000000001\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 6
      testRunner.And("then 100 blocks were mined", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
      testRunner.And("directory administrator added credentials from \"Examples/Credentials/f00000000002" +
                    ".json\" for the VASP with id \"f00000000002\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling GetCredentialsRefAndHashAsync method of VASPDirectoryClient")]
        [NUnit.Framework.TestCaseAttribute("f00000000001", "100", "0x2a433539bb6f490f0e7f53e36708b65ea32ada9ba0660e37c8d74069a53ce89f", "0x2a433539bb6f490f0e7f53e36708b65ea32ada9ba0660e37c8d74069a53ce89f", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000001", "0", "0x2a433539bb6f490f0e7f53e36708b65ea32ada9ba0660e37c8d74069a53ce89f", "0x2a433539bb6f490f0e7f53e36708b65ea32ada9ba0660e37c8d74069a53ce89f", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000002", "100", "", "0x0000000000000000000000000000000000000000000000000000000000000000", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000002", "0", "0x3fc752bf18130623d5bf4a85ab1575102d3ff8bf391d4dc4b18959c6a7a97491", "0x3fc752bf18130623d5bf4a85ab1575102d3ff8bf391d4dc4b18959c6a7a97491", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000003", "100", "", "0x0000000000000000000000000000000000000000000000000000000000000000", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000003", "0", "", "0x0000000000000000000000000000000000000000000000000000000000000000", null)]
        public virtual void CallingGetCredentialsRefAndHashAsyncMethodOfVASPDirectoryClient(string vaspId, string minimalConfirmationLevel, string vaspCredentialsRef, string vaspCredentialsHash, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("vaspId", vaspId);
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("vaspCredentialsRef", vaspCredentialsRef);
            argumentsOfScenario.Add("vaspCredentialsHash", vaspCredentialsHash);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling GetCredentialsRefAndHashAsync method of VASPDirectoryClient", null, tagsOfScenario, argumentsOfScenario);
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
    testRunner.When(string.Format("I call GetCredentialsRefAndHashAsync method of a VASPDirectoryClient with a follo" +
                            "wing parameters: \"{0}\", \"{1}\"", vaspId, minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
    testRunner.Then(string.Format("the Ref property of the GetCredentialsRefAndHashAsync call result should be \"{0}\"" +
                            "", vaspCredentialsRef), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
     testRunner.And(string.Format("the Hash property of the GetCredentialsRefAndHashAsync call result should be \"{0}" +
                            "\"", vaspCredentialsHash), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calling TryGetCredentialsRefAndHashAsync method of VASPDirectoryClient")]
        [NUnit.Framework.TestCaseAttribute("f00000000001", "100", "true", "0x2a433539bb6f490f0e7f53e36708b65ea32ada9ba0660e37c8d74069a53ce89f", "0x2a433539bb6f490f0e7f53e36708b65ea32ada9ba0660e37c8d74069a53ce89f", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000001", "0", "true", "0x2a433539bb6f490f0e7f53e36708b65ea32ada9ba0660e37c8d74069a53ce89f", "0x2a433539bb6f490f0e7f53e36708b65ea32ada9ba0660e37c8d74069a53ce89f", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000002", "100", "false", "", "0x0000000000000000000000000000000000000000000000000000000000000000", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000002", "0", "true", "0x3fc752bf18130623d5bf4a85ab1575102d3ff8bf391d4dc4b18959c6a7a97491", "0x3fc752bf18130623d5bf4a85ab1575102d3ff8bf391d4dc4b18959c6a7a97491", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000003", "100", "false", "", "0x0000000000000000000000000000000000000000000000000000000000000000", null)]
        [NUnit.Framework.TestCaseAttribute("f00000000003", "0", "false", "", "0x0000000000000000000000000000000000000000000000000000000000000000", null)]
        public virtual void CallingTryGetCredentialsRefAndHashAsyncMethodOfVASPDirectoryClient(string vaspId, string minimalConfirmationLevel, string vaspIsRegistered, string vaspCredentialsRef, string vaspCredentialsHash, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("vaspId", vaspId);
            argumentsOfScenario.Add("minimalConfirmationLevel", minimalConfirmationLevel);
            argumentsOfScenario.Add("vaspIsRegistered", vaspIsRegistered);
            argumentsOfScenario.Add("vaspCredentialsRef", vaspCredentialsRef);
            argumentsOfScenario.Add("vaspCredentialsHash", vaspCredentialsHash);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calling TryGetCredentialsRefAndHashAsync method of VASPDirectoryClient", null, tagsOfScenario, argumentsOfScenario);
#line 23
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
#line 24
    testRunner.When(string.Format("I call TryGetCredentialsRefAndHashAsync method of a VASPDirectoryClient with a fo" +
                            "llowing parameters: \"{0}\", \"{1}\"", vaspId, minimalConfirmationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
    testRunner.Then(string.Format("the VASPIsRegistered property of the TryGetCredentialsRefAndHashAsync call result" +
                            " should be \"{0}\"", vaspIsRegistered), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
     testRunner.And(string.Format("the VASPCredentialsRefAndHash property of the TryGetCredentialsRefAndHashAsync ca" +
                            "ll result should be (\"{0}\", \"{1}\")", vaspCredentialsRef, vaspCredentialsHash), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
