﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18034
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace YahooApiSite.AcceptanceTest.網站安全性.使用者認證
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class 取得操作者的登入資訊Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "取得使用者資料.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "取得操作者的登入資訊", "In order to 顯示線上操作者的資料\r\nAs a 線上使用者\r\nI want to 取得操作者的資料", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "取得操作者的登入資訊")))
            {
                YahooApiSite.AcceptanceTest.網站安全性.使用者認證.取得操作者的登入資訊Feature.FeatureSetup(null);
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("無操作者序號取得登入資訊")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "取得操作者的登入資訊")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("HttpClient")]
        public virtual void 無操作者序號取得登入資訊()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("無操作者序號取得登入資訊", new string[] {
                        "HttpClient"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.When("無操作者序號取得登入資訊", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
    testRunner.Then("回傳狀態為 \"BadRequest\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("以 null 操作者序號取得登入資訊")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "取得操作者的登入資訊")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("HttpClient")]
        public virtual void 以Null操作者序號取得登入資訊()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("以 null 操作者序號取得登入資訊", new string[] {
                        "HttpClient"});
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
    testRunner.When("以 null 操作者序號取得登入資訊", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
    testRunner.Then("回傳狀態為 \"BadRequest\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("以操作者序號 2733 取得登入資訊")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "取得操作者的登入資訊")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("HttpClient")]
        public virtual void 以操作者序號2733取得登入資訊()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("以操作者序號 2733 取得登入資訊", new string[] {
                        "HttpClient"});
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.When("以操作者序號 2733 取得登入資訊", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
    testRunner.Then("回傳成功狀態", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
    testRunner.And("回傳操作者序號為 2733", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.And("回傳操作帳號為 \"jacktsai\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
    testRunner.And("回傳操作者的子站為 \"1,2,3,4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
    testRunner.And("回傳操作者中文姓名為 \"蔡逸華\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.And("回傳操作者部門為 \"工程部\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
    testRunner.And("回傳操作者等級為 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
    testRunner.And("回傳操作者首頁為 \"http://\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
    testRunner.And("回傳操作者分機為 \"124567\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.And("回傳操作者Backyard ID 為 \"jacktsai\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
    testRunner.And("回傳細部權限-SELECT為 False", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
    testRunner.And("回傳細部權限-INSERT為 True", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.And("回傳細部權限-UPDATE為 False", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.And("回傳細部權限-DELETE為 True", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
    testRunner.And("回傳細部權限-特殊權限為 False", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
