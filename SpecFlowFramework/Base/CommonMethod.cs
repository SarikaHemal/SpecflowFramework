
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowFramework.Base;
using SpecFlowFramework.Utils;
using System;

namespace SkillsSwap.Base
{
    public class CommonMethod
    {
        public static IWebDriver driver { get; set; }
        
        public static void Wait(int time)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
        }

        [Obsolete]
        public static IWebElement WaitForElement(IWebDriver driver, By by, int timeOutinSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
            return (wait.Until(ExpectedConditions.ElementIsVisible(by)));
        }
        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        public static void ExtentReports()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(ConstantUtils.ReportsPath);
            htmlReporter.LoadConfig(ConstantUtils.ReportXMLPath);
            extent.AttachReporter(htmlReporter);
        }
        #endregion
    }


}


