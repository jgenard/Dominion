// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.3.5.2
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Dominion.Specs.Cards
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.3.5.2")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Kings Court")]
    public partial class KingsCourtFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "KingsCourt.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Kings Court", "", ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player must choose which card to use Kings Court effect on")]
        public virtual void PlayerMustChooseWhichCardToUseKingsCourtEffectOn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player must choose which card to use Kings Court effect on", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has a KingsCourt in hand instead of a Copper");
#line 6
testRunner.And("Player1 has a Market in hand instead of a Copper");
#line 7
testRunner.When("Player1 plays a KingsCourt");
#line 8
testRunner.Then("Player1 must select 1 action card");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player uses Kings Court\'s effect on a Market")]
        public virtual void PlayerUsesKingsCourtSEffectOnAMarket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player uses Kings Court\'s effect on a Market", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given("A new game with 3 players");
#line 12
testRunner.And("Player1 has a KingsCourt in hand instead of a Copper");
#line 13
testRunner.And("Player1 has a Market in hand instead of a Copper");
#line 14
testRunner.When("Player1 plays a KingsCourt");
#line 15
testRunner.And("Player1 selects a Market to KingsCourt");
#line 16
testRunner.Then("Player1 should have 6 cards in hand");
#line 17
testRunner.And("Player1 should have 3 remaining actions");
#line 18
testRunner.And("Player1 should have 4 buys");
#line 19
testRunner.And("Player1 should have 3 to spend");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
