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
           
           
        
       
        [BeforeScenario]
        [Obsolete]
        public void BeforeScenario()
            {
            //var init =new FrameworkHooks();
            //.IntialSetup(objectContainer);
            driver = new ChromeDriver();
            objectContainer.RegisterInstanceAs(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(ConstantUtils.Url);
            }
        [BeforeFeature]
        public static void BeforeFeature()
        {
            CommonMethod.ExtentReports();
        }

        
        [BeforeStep]
        public static void CreateTest(ScenarioContext scenarioContext)
        {
           
            CommonMethod.test =CommonMethod.extent.CreateTest(scenarioContext.ScenarioInfo.Title);
        }
        [AfterStep]
        public void ReportTest(ScenarioContext scenarioContext)
        {
           
            String img = SaveScreenShot.SaveScreenshot(driver, "Report");
            CommonMethod.test.Log(Status.Info, scenarioContext.CurrentScenarioBlock + ": Image example: " + img);
            
        }

        [AfterScenario]
            public  void Teardown(IWebDriver driver)
            {
            driver.Close();
            CommonMethod.extent.Flush();
        }
    
            



        }
    }
