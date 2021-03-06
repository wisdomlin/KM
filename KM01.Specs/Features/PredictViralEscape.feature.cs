// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.8.0.0
//      SpecFlow Generator Version:3.8.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ReusableEntities.specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("predict viral escape", Description="[Viral mutations] that evade [neutralizing antibodies], an occurrence known as [v" +
        "iral escape], \r\ncan occur and may impede [the development of vaccines]. \r\nTo pre" +
        "dict which mutations may lead to [viral escape], \r\nHie et al. used a machine lea" +
        "rning technique for natural language processing with two components: \r\ngrammar (" +
        "or syntax) and meaning (or semantics) (see the Perspective by Kim and Przytycka)" +
        ". \r\n\r\nThree [different unsupervised language models] were constructed for \r\ninfl" +
        "uenza A hemagglutinin, \r\nHIV-1 envelope glycoprotein, and \r\nsevere acute respira" +
        "tory syndrome coronavirus 2 (SARS-CoV-2) spike glycoprotein. \r\n[Semantic landsca" +
        "pes] for these viruses predicted [viral escape mutations] \r\nthat produce [sequen" +
        "ces] that are [syntactically and/or grammatically correct] \r\nbut [effectively di" +
        "fferent in semantics] and thus able to [evade the immune system].\r\n\r\n\r\nThe abili" +
        "ty for viruses to mutate and evade the human immune system and cause infection, " +
        "called [viral escape], \r\nremains an obstacle to [antiviral and vaccine developme" +
        "nt]. \r\nUnderstanding the complex rules that govern escape could inform [therapeu" +
        "tic design]. \r\nWe modeled [viral escape] with machine learning algorithms origin" +
        "ally developed for human natural language. \r\nWe identified [escape mutations] as" +
        " those \r\nthat preserve [viral infectivity] but cause a virus to [look different " +
        "to the immune system], \r\nakin to [word changes] that preserve [a sentence’s gram" +
        "maticality] but [change its meaning]. \r\nWith this approach, language models of \r" +
        "\n[influenza hemagglutinin], \r\n[HIV-1 envelope glycoprotein (HIV Env)], and \r\nsev" +
        "ere acute respiratory syndrome coronavirus 2 (SARS-CoV-2) Spike viral proteins \r" +
        "\ncan accurately predict [structural escape patterns] using [sequence data] alone" +
        ". \r\nOur study represents a promising conceptual bridge between [natural language" +
        "] and [viral evolution].", SourceFile="Features\\PredictViralEscape.feature", SourceLine=0)]
    public partial class PredictViralEscapeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "PredictViralEscape.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "predict viral escape", "[Viral mutations] that evade [neutralizing antibodies], an occurrence known as [v" +
                    "iral escape], \r\ncan occur and may impede [the development of vaccines]. \r\nTo pre" +
                    "dict which mutations may lead to [viral escape], \r\nHie et al. used a machine lea" +
                    "rning technique for natural language processing with two components: \r\ngrammar (" +
                    "or syntax) and meaning (or semantics) (see the Perspective by Kim and Przytycka)" +
                    ". \r\n\r\nThree [different unsupervised language models] were constructed for \r\ninfl" +
                    "uenza A hemagglutinin, \r\nHIV-1 envelope glycoprotein, and \r\nsevere acute respira" +
                    "tory syndrome coronavirus 2 (SARS-CoV-2) spike glycoprotein. \r\n[Semantic landsca" +
                    "pes] for these viruses predicted [viral escape mutations] \r\nthat produce [sequen" +
                    "ces] that are [syntactically and/or grammatically correct] \r\nbut [effectively di" +
                    "fferent in semantics] and thus able to [evade the immune system].\r\n\r\n\r\nThe abili" +
                    "ty for viruses to mutate and evade the human immune system and cause infection, " +
                    "called [viral escape], \r\nremains an obstacle to [antiviral and vaccine developme" +
                    "nt]. \r\nUnderstanding the complex rules that govern escape could inform [therapeu" +
                    "tic design]. \r\nWe modeled [viral escape] with machine learning algorithms origin" +
                    "ally developed for human natural language. \r\nWe identified [escape mutations] as" +
                    " those \r\nthat preserve [viral infectivity] but cause a virus to [look different " +
                    "to the immune system], \r\nakin to [word changes] that preserve [a sentence’s gram" +
                    "maticality] but [change its meaning]. \r\nWith this approach, language models of \r" +
                    "\n[influenza hemagglutinin], \r\n[HIV-1 envelope glycoprotein (HIV Env)], and \r\nsev" +
                    "ere acute respiratory syndrome coronavirus 2 (SARS-CoV-2) Spike viral proteins \r" +
                    "\ncan accurately predict [structural escape patterns] using [sequence data] alone" +
                    ". \r\nOur study represents a promising conceptual bridge between [natural language" +
                    "] and [viral evolution].", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("predict [structural escape patterns] using [sequence data]", new string[] {
                "mytag"}, SourceLine=31)]
        public virtual void PredictStructuralEscapePatternsUsingSequenceData()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("predict [structural escape patterns] using [sequence data]", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 32
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
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Syntax",
                            "Semantics"});
                table3.AddRow(new string[] {
                            "correct",
                            "effectively different"});
                table3.AddRow(new string[] {
                            "correct",
                            "effectively same"});
                table3.AddRow(new string[] {
                            "correct",
                            "ineffective"});
                table3.AddRow(new string[] {
                            "incorrect",
                            "ineffective"});
#line 33
 testRunner.Given("viral evolution generates the following structral patterns of sequence data:", ((string)(null)), table3, "Given ");
#line hidden
#line 39
 testRunner.When("the structral patterns of sequence data are predicted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Prediction Result"});
                table4.AddRow(new string[] {
                            "viral escape"});
                table4.AddRow(new string[] {
                            "no viral escape"});
                table4.AddRow(new string[] {
                            "no viral escape"});
                table4.AddRow(new string[] {
                            "no viral escape"});
#line 40
 testRunner.Then("the prediction result should be as follows:", ((string)(null)), table4, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
