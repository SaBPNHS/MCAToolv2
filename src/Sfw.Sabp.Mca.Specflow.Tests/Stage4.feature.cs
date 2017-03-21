﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sfw.Sabp.Mca.Specflow.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class Stage4Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Stage4.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Stage4", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Stage4")))
            {
                Sfw.Sabp.Mca.Specflow.Tests.Stage4Feature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AnswerQuestion(string question, string option, string nextquestion, string outcome, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Answer question", @__tags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given(string.Format("I have answered {0} with {1}", question, option), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then(string.Format("the next question should be {0}", nextquestion), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 7
 testRunner.And(string.Format("the next question outcome should be {0}", outcome), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "17D7C17A-3665-4DFC-B54E-B4851D10C70D")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "17D7C17A-3665-4DFC-B54E-B4851D10C70D")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "FE8F701D-E1F8-4280-830A-C92ACC802198")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "CF5F6C27-8558-40C8-ABD3-48694749659E")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_17D7C17A_3665_4DFC_B54E_B4851D10C70D()
        {
            this.AnswerQuestion("17D7C17A-3665-4DFC-B54E-B4851D10C70D", "FE8F701D-E1F8-4280-830A-C92ACC802198", "CF5F6C27-8558-40C8-ABD3-48694749659E", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CF5F6C27-8558-40C8-ABD3-48694749659E")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "CF5F6C27-8558-40C8-ABD3-48694749659E")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "1A9A4ED4-1F7C-40B8-9A6A-5F4795FFAA66")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "E0B77A49-FE2C-4775-A7D3-F0AF1A84DD03")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_CF5F6C27_8558_40C8_ABD3_48694749659E()
        {
            this.AnswerQuestion("CF5F6C27-8558-40C8-ABD3-48694749659E", "1A9A4ED4-1F7C-40B8-9A6A-5F4795FFAA66", "E0B77A49-FE2C-4775-A7D3-F0AF1A84DD03", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "E0B77A49-FE2C-4775-A7D3-F0AF1A84DD03")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "E0B77A49-FE2C-4775-A7D3-F0AF1A84DD03")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "F9EB3CE3-4333-43F9-BC13-F92830FC8FC2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "3A273925-D576-4FBA-9E44-A5DE64D865D4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_E0B77A49_FE2C_4775_A7D3_F0AF1A84DD03()
        {
            this.AnswerQuestion("E0B77A49-FE2C-4775-A7D3-F0AF1A84DD03", "F9EB3CE3-4333-43F9-BC13-F92830FC8FC2", "3A273925-D576-4FBA-9E44-A5DE64D865D4", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "3A273925-D576-4FBA-9E44-A5DE64D865D4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "3A273925-D576-4FBA-9E44-A5DE64D865D4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "3BA9DB0C-0371-4D3D-B57B-1400BB281515")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "1FD42031-3051-47BA-A6EC-E469D0A8ABF5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_3A273925_D576_4FBA_9E44_A5DE64D865D4()
        {
            this.AnswerQuestion("3A273925-D576-4FBA-9E44-A5DE64D865D4", "3BA9DB0C-0371-4D3D-B57B-1400BB281515", "1FD42031-3051-47BA-A6EC-E469D0A8ABF5", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "1FD42031-3051-47BA-A6EC-E469D0A8ABF5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "1FD42031-3051-47BA-A6EC-E469D0A8ABF5")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "39CB576A-1A88-4A5F-9D8A-E4819670419A")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "E02E9DC7-5C29-4AD4-B19A-4253EF13DD96")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_1FD42031_3051_47BA_A6EC_E469D0A8ABF5()
        {
            this.AnswerQuestion("1FD42031-3051-47BA-A6EC-E469D0A8ABF5", "39CB576A-1A88-4A5F-9D8A-E4819670419A", "E02E9DC7-5C29-4AD4-B19A-4253EF13DD96", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "E02E9DC7-5C29-4AD4-B19A-4253EF13DD96")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "E02E9DC7-5C29-4AD4-B19A-4253EF13DD96")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "D97BAF43-B487-4F7D-873A-27E46C6B16AB")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "B24C33D2-2044-4AD4-95DE-911DA33D7175")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_E02E9DC7_5C29_4AD4_B19A_4253EF13DD96()
        {
            this.AnswerQuestion("E02E9DC7-5C29-4AD4-B19A-4253EF13DD96", "D97BAF43-B487-4F7D-873A-27E46C6B16AB", "B24C33D2-2044-4AD4-95DE-911DA33D7175", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "B24C33D2-2044-4AD4-95DE-911DA33D7175")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "B24C33D2-2044-4AD4-95DE-911DA33D7175")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "BC22A43C-11FF-4A34-B467-D636C9C12E4F")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "34F3B19C-38AA-4FE4-917B-B4523D490364")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_B24C33D2_2044_4AD4_95DE_911DA33D7175()
        {
            this.AnswerQuestion("B24C33D2-2044-4AD4-95DE-911DA33D7175", "BC22A43C-11FF-4A34-B467-D636C9C12E4F", "34F3B19C-38AA-4FE4-917B-B4523D490364", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "34F3B19C-38AA-4FE4-917B-B4523D490364")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "34F3B19C-38AA-4FE4-917B-B4523D490364")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "9F687E87-E6FD-471C-9237-7BBA17A6117E")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "CC7EA523-3FB5-4408-B487-651E193774AF")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_34F3B19C_38AA_4FE4_917B_B4523D490364()
        {
            this.AnswerQuestion("34F3B19C-38AA-4FE4-917B-B4523D490364", "9F687E87-E6FD-471C-9237-7BBA17A6117E", "CC7EA523-3FB5-4408-B487-651E193774AF", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "CC7EA523-3FB5-4408-B487-651E193774AF")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "CC7EA523-3FB5-4408-B487-651E193774AF")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "07BB30B5-E25D-4676-8182-A00BECBDDB28")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "106746FD-4A42-49B6-B823-1789A7552995")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_CC7EA523_3FB5_4408_B487_651E193774AF()
        {
            this.AnswerQuestion("CC7EA523-3FB5-4408-B487-651E193774AF", "07BB30B5-E25D-4676-8182-A00BECBDDB28", "106746FD-4A42-49B6-B823-1789A7552995", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "106746FD-4A42-49B6-B823-1789A7552995")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "106746FD-4A42-49B6-B823-1789A7552995")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "1D416730-70D8-43A5-A27E-3E7E543EB44F")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "0B2FB4DA-1D2A-4A82-893B-8DC14EC32411")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_106746FD_4A42_49B6_B823_1789A7552995()
        {
            this.AnswerQuestion("106746FD-4A42-49B6-B823-1789A7552995", "1D416730-70D8-43A5-A27E-3E7E543EB44F", "0B2FB4DA-1D2A-4A82-893B-8DC14EC32411", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "0B2FB4DA-1D2A-4A82-893B-8DC14EC32411")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "0B2FB4DA-1D2A-4A82-893B-8DC14EC32411")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "23D2EE38-C8DC-4480-AD85-51E36AE1AA11")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "8B7185B4-C924-4207-8370-F9DFFCBAF6B6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_0B2FB4DA_1D2A_4A82_893B_8DC14EC32411()
        {
            this.AnswerQuestion("0B2FB4DA-1D2A-4A82-893B-8DC14EC32411", "23D2EE38-C8DC-4480-AD85-51E36AE1AA11", "8B7185B4-C924-4207-8370-F9DFFCBAF6B6", "1", ((string[])(null)));
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Answer question")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Stage4")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "8B7185B4-C924-4207-8370-F9DFFCBAF6B6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:question", "8B7185B4-C924-4207-8370-F9DFFCBAF6B6")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:option", "E77E7863-7181-4158-8ED2-C841EE01C330")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:nextquestion", "3A5D760F-A123-4D39-89F0-826AC14DABFD")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:outcome", "1")]
        public virtual void AnswerQuestion_8B7185B4_C924_4207_8370_F9DFFCBAF6B6()
        {
            this.AnswerQuestion("8B7185B4-C924-4207-8370-F9DFFCBAF6B6", "E77E7863-7181-4158-8ED2-C841EE01C330", "3A5D760F-A123-4D39-89F0-826AC14DABFD", "1", ((string[])(null)));
        }
    }
}
#pragma warning restore
#endregion
