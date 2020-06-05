using AventStack.ExtentReports;
using AventStack.ExtentReports.Model;
using MarsFramework;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SkillsSwap.Base;
using SpecFlowFramework.Base;
using SpecFlowFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowFramework.Steps
{
    [Binding]
    public class SignInStep
    {
        private readonly IWebDriver driver;
        private readonly SignInPage LoginPage;
        private readonly ProfilePage ProfilePage;
                

        [Obsolete]
        public SignInStep(IWebDriver driver)
        {
            this.driver = driver;
            LoginPage = new SignInPage(driver);
            ProfilePage = new ProfilePage(driver);
           
            
        }
        
       
        //ProfilePage ProfilePage = new ProfilePage(Driver.driver);

        [Given(@"I login with valid user")]
        [Obsolete]
        public void GivenILoginWithValidUser(Table table)
        {

            
            UserDetails details = table.CreateInstance<UserDetails>();
            LoginPage.LoginSteps(details.Email,details.Password);
            
        }


        [Then(@"I can navigate to profile page")]
        public void ThenICanNavigateToProfilePage()
        {
           string result= ProfilePage.IsLogin();
            Assert.AreEqual(result, "Pass","Test fail");
        }

    }
}
