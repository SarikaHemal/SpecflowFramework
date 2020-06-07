using MarsFramework;
using MarsFramework.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowFramework.Steps
{
    [Binding]
    public sealed class ProfileEditSteps
    {
        private readonly ProfilePage ProfilePage;
        private readonly SignInPage LoginPage;
        private readonly IWebDriver driver;
        [Obsolete]
        public ProfileEditSteps(IWebDriver driver)
        {
            this.driver = driver;
            LoginPage = new SignInPage(driver);
            ProfilePage = new ProfilePage(driver);
        }
        [Given(@"I click Change Password option under user name and sign out")]
        [Obsolete]
        public void GivenIClickChangePasswordOptionUnderUserNameAndSignOut()
        {
            ProfilePage.ChangePassword("234567", "123456");
            driver.FindElement(By.XPath("//button[contains(.,'Sign Out')]")).Click();
            Thread.Sleep(3000);
        }

        
        [Then(@"I can login with changed password")]
        [Obsolete]
        public void ThenICanLoginWithChangedPassword()
        {
                    
            LoginPage.LoginSteps("Myra.bamania@gmail.com", "123456");
        }

    }
}
