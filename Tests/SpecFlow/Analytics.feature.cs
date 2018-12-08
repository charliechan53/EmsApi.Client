﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace EmsApi.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AnalyticsFeature : Xunit.IClassFixture<AnalyticsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Analytics.feature"
#line hidden
        
        public AnalyticsFeature(AnalyticsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Analytics", "\tAs an application developer\r\n\tI want to be able to access EMS analytic definitio" +
                    "ns and values", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Search for analytics by name")]
        [Xunit.TraitAttribute("FeatureTitle", "Analytics")]
        [Xunit.TraitAttribute("Description", "Search for analytics by name")]
        public virtual void SearchForAnalyticsByName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for analytics by name", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
 testRunner.Given("A valid API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And("The cached EMS system id of 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.When("I run Search and enter a search string of \'MD-80 Series\' and a group id of \'Dimen" +
                    "sionValues.Dimension:ada09d23-162d-46ad-a438-a0cdaefdb3f8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then("A single AnalyticInfo object is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Search for analytics by name and flight")]
        [Xunit.TraitAttribute("FeatureTitle", "Analytics")]
        [Xunit.TraitAttribute("Description", "Search for analytics by name and flight")]
        public virtual void SearchForAnalyticsByNameAndFlight()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search for analytics by name and flight", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
 testRunner.Given("A valid API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
 testRunner.And("The cached EMS system id of 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.When("I run Search and enter a flight id of 1 and a search string of \'MD-80 Series\' and" +
                    " a group id of \'DimensionValues.Dimension:ada09d23-162d-46ad-a438-a0cdaefdb3f8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("A single AnalyticInfo object is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get analytic info")]
        [Xunit.TraitAttribute("FeatureTitle", "Analytics")]
        [Xunit.TraitAttribute("Description", "Get analytic info")]
        public virtual void GetAnalyticInfo()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get analytic info", null, ((string[])(null)));
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 18
 testRunner.Given("A valid API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And("The cached EMS system id of 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When(@"I run GetInfo and enter an analytic id of 'H4sIAAAAAAAEAJ2STW/CMAyGz0PiPyAO3NIkbekHsEqTuCDBBcS0qxunEKkkrA1jP39tUWDVtstuie3ntf0mi62sTfkBeSlXKLVVhZLV6PNU6nqmnsdHa88zSq/Xq3cNPFMdqM8Yp2+b9U4c5QmI0rUFLeT4xtyJukvXHoIFYbStQFjHh5TF9AWVt69gnA0Ho9HiNoWsVpgtoVyqk9S1MvoVyotc0G/ZXvXuLEUzsFg2TbJJaedbY+zkYOftuS/iEO+x73+2bMWHg6enXoM2CAgsRT8gPPKRhBEggTBICDCBIAvMgyJpIdqjnNTGoGzvayOgXGFX6GKuplujDfhJMY0lByLzKCehSHnTaiqIz30meYxpDqxTuBONRL/3X5Y476gz8uF9z+tfX2Gv1ful+UWZABA+a2zgQcRJEQRIRJGnJMUkSrFgYRjGP4Xv+HDgkv1fmX0BGyq1a6wCAAA='", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("An AnlyticInfo object is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.And("It has the name \'Airframe: MD-80 Series\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get analytic info for flight")]
        [Xunit.TraitAttribute("FeatureTitle", "Analytics")]
        [Xunit.TraitAttribute("Description", "Get analytic info for flight")]
        public virtual void GetAnalyticInfoForFlight()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get analytic info for flight", null, ((string[])(null)));
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
 testRunner.Given("A valid API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.And("The cached EMS system id of 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When(@"I run GetInfo and enter a flight id of 1 and an analytic id of 'H4sIAAAAAAAEAJ2STW/CMAyGz0PiPyAO3NIkbekHsEqTuCDBBcS0qxunEKkkrA1jP39tUWDVtstuie3ntf0mi62sTfkBeSlXKLVVhZLV6PNU6nqmnsdHa88zSq/Xq3cNPFMdqM8Yp2+b9U4c5QmI0rUFLeT4xtyJukvXHoIFYbStQFjHh5TF9AWVt69gnA0Ho9HiNoWsVpgtoVyqk9S1MvoVyotc0G/ZXvXuLEUzsFg2TbJJaedbY+zkYOftuS/iEO+x73+2bMWHg6enXoM2CAgsRT8gPPKRhBEggTBICDCBIAvMgyJpIdqjnNTGoGzvayOgXGFX6GKuplujDfhJMY0lByLzKCehSHnTaiqIz30meYxpDqxTuBONRL/3X5Y476gz8uF9z+tfX2Gv1ful+UWZABA+a2zgQcRJEQRIRJGnJMUkSrFgYRjGP4Xv+HDgkv1fmX0BGyq1a6wCAAA='", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("An AnlyticInfo object is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And("It has the name \'Airframe: MD-80 Series\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get the contents of an analytic group")]
        [Xunit.TraitAttribute("FeatureTitle", "Analytics")]
        [Xunit.TraitAttribute("Description", "Get the contents of an analytic group")]
        public virtual void GetTheContentsOfAnAnalyticGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the contents of an analytic group", null, ((string[])(null)));
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
 testRunner.Given("A valid API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And("The cached EMS system id of 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.When("I run GetGroup and enter an an analytic group id of \'DimensionValues.Dimension:ad" +
                    "a09d23-162d-46ad-a438-a0cdaefdb3f8\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("An AnalyticGroupContents object is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.And("It contains an analytic with the name \'Airframe: MD-80 Series\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get analytic results")]
        [Xunit.TraitAttribute("FeatureTitle", "Analytics")]
        [Xunit.TraitAttribute("Description", "Get analytic results")]
        public virtual void GetAnalyticResults()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get analytic results", null, ((string[])(null)));
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 39
 testRunner.Given("A valid API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
 testRunner.And("The cached EMS system id of 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.When(@"I run QueryResults and enter a flight id of 1 and a query with an analytic id of 'H4sIAAAAAAAEAJ2STW/CMAyGz0PiPyAO3NIkbekHsEqTuCDBBcS0qxunEKkkrA1jP39tUWDVtstuie3ntf0mi62sTfkBeSlXKLVVhZLV6PNU6nqmnsdHa88zSq/Xq3cNPFMdqM8Yp2+b9U4c5QmI0rUFLeT4xtyJukvXHoIFYbStQFjHh5TF9AWVt69gnA0Ho9HiNoWsVpgtoVyqk9S1MvoVyotc0G/ZXvXuLEUzsFg2TbJJaedbY+zkYOftuS/iEO+x73+2bMWHg6enXoM2CAgsRT8gPPKRhBEggTBICDCBIAvMgyJpIdqjnNTGoGzvayOgXGFX6GKuplujDfhJMY0lByLzKCehSHnTaiqIz30meYxpDqxTuBONRL/3X5Y476gz8uF9z+tfX2Gv1ful+UWZABA+a2zgQcRJEQRIRJGnJMUkSrFgYRjGP4Xv+HDgkv1fmX0BGyq1a6wCAAA='", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("A QueryResult object is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Get analytic metadata")]
        [Xunit.TraitAttribute("FeatureTitle", "Analytics")]
        [Xunit.TraitAttribute("Description", "Get analytic metadata")]
        public virtual void GetAnalyticMetadata()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get analytic metadata", null, ((string[])(null)));
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 45
 testRunner.Given("A valid API endpoint", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.And("The cached EMS system id of 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When(@"I run GetMetadata and enter a flight id of 1 and an analytic id of 'H4sIAAAAAAAEAG2QQQuCQBCF74H/Qby7qyUUokJQB8EuidB1WzcdWFfbXbOf35ZYSb3DY2DmY95MdGSq5Tdy5iwtmdBwASbte8OFCiF2aq27EONhGNCwQq2s8NLzfHw6ZDmtWUNcEEoTQZkzMm9CvdoKlUQT2gotCdUTH2BvjbcloEISJ7EWth2NKZhMy2QqFdo3KmsroIRH+GtgBuQdoyYz3Zk9NoQCeOxo2Zs8+P9gIeDam1sTb5TvGtu4gfFnNdqkz94f3FpMzfnvkgfLSh/6UgEAAA=='", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("A Metadata object is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("It contains an item with the key \'DataType\' and the value \'Real\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("It contains an item with the key \'Information\\Internal Description\' and the value" +
                    " \'Radio Altitude (second fastest)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                AnalyticsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                AnalyticsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
