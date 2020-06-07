using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using BoDi;
using Dynamitey.Internal.Optimization;
using MongoDB.Bson;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RazorEngine.Compilation.ImpromptuInterface;
using SkillsSwap.Base;
using SpecFlowFramework.Base;
using SpecFlowFramework.Utils;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace SpecFlowFramework
{
    [Binding]
    public sealed class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        private readonly IObjectContainer objectContainer;
        public IWebDriver driver { get; set; }

        public TestFixture(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;



        }
        public static void Main()
        { }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            CommonMethod.ExtentReports();
        }


        [BeforeScenario]
        [Obsolete]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            //var init =new FrameworkHooks();
            //.IntialSetup(objectContainer);
            driver = new ChromeDriver();
            objectContainer.RegisterInstanceAs(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(ConstantUtils.Url);
            

        }
        //[AfterScenario]
        //public void BeforeStep(ScenarioContext scenarioContext)
        //{
             
        //}


        [AfterStep]
        public void ReportTest(ScenarioContext scenarioContext)
        {
            CommonMethod.test = CommonMethod.extent.CreateTest(scenarioContext.StepContext.StepInfo.Text);
            String img = SaveScreenShot.SaveScreenshot(driver, "Report");
            if (scenarioContext.TestError!=null)
            {
                CommonMethod.test.Fail(scenarioContext.TestError.Message)
                    .Log(Status.Error,scenarioContext.TestError.Message +": Image example: " + img);
            }
            else
            {
                CommonMethod.test.Log(Status.Pass, scenarioContext.StepContext.StepInfo.Text + ": Image example: " + img);
            }

            
        }

        [AfterScenario]
        public void Teardown(IWebDriver driver)
        {
            
            driver.Close();
            CommonMethod.extent.Flush();
        }
        
    }
}
