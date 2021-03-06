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
    [TechTalk.SpecRun.FeatureAttribute("MARPOL 73/78 - Annex VI", Description=@"國際海事組織 (IMO) 在 2016 年加強了 NOx 排放標準， 2020 年又加強了 SOx 排放標準，2023 年將再加強 碳排放標準。
這個碳排新標準主要用兩種指標來要求: 一是 [船舶能效指數 (EEXI)]，二是 [碳强度指数(CII)]。
目前符合這兩指標要求的船支並不多，除非是新型的節能船。
如果舊船想要符合這兩個指標要求，就必須降低船速，或是降低主機功率。
但是在海上降低船速，可能要會造成安全性、耗油、碳排增加等問題，而且運輸量能降低又進一步加劇了目前缺船的問題。

所以，藉由這個交通運輸案例，我想再一次提醒節能減碳的重要性，只要我們認為對的事情，就提早做預備、勇敢做投資。
事實上，我看到我們有提供未來航運趨勢預估量，其實只要把這些運輸需求量乘上轉換係數，就可以知道全世界需要多少節能船，這就可以形成我們永續投資的標準和策略。", SourceFile="Features\\MARPOL_73-78_ AnnexVI.feature", SourceLine=0)]
    public partial class MARPOL7378_AnnexVIFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "MARPOL_73-78_ AnnexVI.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "MARPOL 73/78 - Annex VI", @"國際海事組織 (IMO) 在 2016 年加強了 NOx 排放標準， 2020 年又加強了 SOx 排放標準，2023 年將再加強 碳排放標準。
這個碳排新標準主要用兩種指標來要求: 一是 [船舶能效指數 (EEXI)]，二是 [碳强度指数(CII)]。
目前符合這兩指標要求的船支並不多，除非是新型的節能船。
如果舊船想要符合這兩個指標要求，就必須降低船速，或是降低主機功率。
但是在海上降低船速，可能要會造成安全性、耗油、碳排增加等問題，而且運輸量能降低又進一步加劇了目前缺船的問題。

所以，藉由這個交通運輸案例，我想再一次提醒節能減碳的重要性，只要我們認為對的事情，就提早做預備、勇敢做投資。
事實上，我看到我們有提供未來航運趨勢預估量，其實只要把這些運輸需求量乘上轉換係數，就可以知道全世界需要多少節能船，這就可以形成我們永續投資的標準和策略。", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("NOx", new string[] {
                "mytag"}, Description="Total weighted cycle emission limit (g/kWh)", SourceLine=12)]
        public virtual void NOx()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("NOx", "Total weighted cycle emission limit (g/kWh)", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 13
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
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "ship construction date",
                            "engine\' s rated speed"});
                table1.AddRow(new string[] {
                            "2000.01.01",
                            "129"});
                table1.AddRow(new string[] {
                            "2000.01.01",
                            "130"});
                table1.AddRow(new string[] {
                            "2000.01.01",
                            "720"});
                table1.AddRow(new string[] {
                            "2000.01.01",
                            "1999"});
                table1.AddRow(new string[] {
                            "2000.01.01",
                            "2000"});
                table1.AddRow(new string[] {
                            "2011.01.01",
                            "129"});
                table1.AddRow(new string[] {
                            "2011.01.01",
                            "130"});
                table1.AddRow(new string[] {
                            "2011.01.01",
                            "720"});
                table1.AddRow(new string[] {
                            "2011.01.01",
                            "1999"});
                table1.AddRow(new string[] {
                            "2011.01.01",
                            "2000"});
                table1.AddRow(new string[] {
                            "2016.01.01",
                            "129"});
                table1.AddRow(new string[] {
                            "2016.01.01",
                            "130"});
                table1.AddRow(new string[] {
                            "2016.01.01",
                            "720"});
                table1.AddRow(new string[] {
                            "2016.01.01",
                            "1999"});
                table1.AddRow(new string[] {
                            "2016.01.01",
                            "2000"});
#line 15
 testRunner.Given("the ship status :", ((string)(null)), table1, "Given ");
#line hidden
#line 32
 testRunner.When("the Total weighted cycle emission limit is asked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "total weighted cycle emission limit"});
                table2.AddRow(new string[] {
                            "17.0"});
                table2.AddRow(new string[] {
                            "17.0"});
                table2.AddRow(new string[] {
                            "12.1"});
                table2.AddRow(new string[] {
                            "9.8"});
                table2.AddRow(new string[] {
                            "9.8"});
                table2.AddRow(new string[] {
                            "14.4"});
                table2.AddRow(new string[] {
                            "14.4"});
                table2.AddRow(new string[] {
                            "9.7"});
                table2.AddRow(new string[] {
                            "7.7"});
                table2.AddRow(new string[] {
                            "7.7"});
                table2.AddRow(new string[] {
                            "3.4"});
                table2.AddRow(new string[] {
                            "3.4"});
                table2.AddRow(new string[] {
                            "2.4"});
                table2.AddRow(new string[] {
                            "2.0"});
                table2.AddRow(new string[] {
                            "2.0"});
#line 33
 testRunner.Then("Total weighted cycle emission limit should be as follows:", ((string)(null)), table2, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("SOx", new string[] {
                "mytag"}, SourceLine=51)]
        public virtual void SOx()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("SOx", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 52
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
#line 53
 testRunner.When("clinical research organization finishes doing data analysis", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.Then("independent data monitoring committee is set up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 55
 testRunner.And("vaccine safety and neutralizing nntibody value are provided", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Carbon Emission", new string[] {
                "mytag"}, SourceLine=57)]
        public virtual void CarbonEmission()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Carbon Emission", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 58
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
#line 59
 testRunner.When("clinical (contract) research organization starts doing data analysis", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("pharmaceutical company and clinical trial center are blinded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
