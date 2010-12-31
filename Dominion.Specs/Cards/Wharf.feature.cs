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
    [NUnit.Framework.DescriptionAttribute("Wharf")]
    public partial class WharfFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Wharf.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Wharf", "", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Player plays Wharf and draws 2 cards and gains a buy")]
        public virtual void PlayerPlaysWharfAndDraws2CardsAndGainsABuy()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Wharf and draws 2 cards and gains a buy", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 2 players");
#line 5
testRunner.And("Player1 has a Wharf in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a Wharf");
#line 7
testRunner.Then("Player1 should have 6 cards in hand");
#line 8
testRunner.And("Player1 should have 2 buys");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays Wharf and draws 2 cards and gains a buy on the following turn")]
        public virtual void PlayerPlaysWharfAndDraws2CardsAndGainsABuyOnTheFollowingTurn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Wharf and draws 2 cards and gains a buy on the following turn", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 11
testRunner.Given("A new game with 2 players");
#line 12
testRunner.And("Player1 has a Wharf in hand instead of a Copper");
#line 13
testRunner.When("Player1 plays a Wharf");
#line 14
testRunner.And("Player1 ends their turn");
#line 15
testRunner.And("Player2 ends their turn");
#line 16
testRunner.Then("Player1 should have 7 cards in hand");
#line 17
testRunner.And("Player1 should have 2 buys");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion