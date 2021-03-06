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
    [NUnit.Framework.DescriptionAttribute("Torturer")]
    public partial class TorturerFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Torturer.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Torturer", "", ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Player plays Torturer and opponents must decide whether to discard cards or gain " +
            "a curse")]
        public virtual void PlayerPlaysTorturerAndOpponentsMustDecideWhetherToDiscardCardsOrGainACurse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Torturer and opponents must decide whether to discard cards or gain " +
                    "a curse", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
testRunner.Given("A new game with 3 players");
#line 5
testRunner.And("Player1 has a Torturer in hand instead of a Copper");
#line 6
testRunner.When("Player1 plays a Torturer");
#line 7
testRunner.Then("Player1 should have 7 cards in hand");
#line 8
testRunner.And("Player2 must choose whether to discard cards (Yes or No)");
#line 9
testRunner.And("Player3 must choose whether to discard cards (Yes or No)");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays Torturer and opponent decides to discard cards")]
        public virtual void PlayerPlaysTorturerAndOpponentDecidesToDiscardCards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Torturer and opponent decides to discard cards", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
testRunner.Given("A new game with 2 players");
#line 13
testRunner.And("Player1 has a Torturer in hand instead of a Copper");
#line 14
testRunner.When("Player1 plays a Torturer");
#line 15
testRunner.And("Player2 chooses to discard cards (Yes)");
#line 16
testRunner.Then("Player2 must select 2 cards to discard");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player plays Torturer and opponent decides to gain a curse")]
        public virtual void PlayerPlaysTorturerAndOpponentDecidesToGainACurse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player plays Torturer and opponent decides to gain a curse", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
testRunner.Given("A new game with 2 players");
#line 20
testRunner.And("Player1 has a Torturer in hand instead of a Copper");
#line 21
testRunner.When("Player1 plays a Torturer");
#line 22
testRunner.And("Player2 chooses to gain a curse (No)");
#line 23
testRunner.Then("Player2 should have 6 cards in hand");
#line 24
testRunner.And("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Player decides to discard to torturer with only 1 card in hand")]
        public virtual void PlayerDecidesToDiscardToTorturerWithOnly1CardInHand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Player decides to discard to torturer with only 1 card in hand", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
testRunner.Given("A new game with 2 players");
#line 28
testRunner.And("Player1 has a Torturer in hand instead of a Copper");
#line 29
testRunner.And("Player2 has a hand of Copper");
#line 30
testRunner.When("Player1 plays a Torturer");
#line 31
testRunner.And("Player2 chooses to discard cards (Yes)");
#line 32
testRunner.Then("Player2 should have 0 cards in hand");
#line 33
testRunner.And("All actions should be resolved");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
