
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SpecFlowFramework.Base;
using SpecFlowFramework.Utils;
using System;

namespace MarsFramework.Pages
{
    class SignInPage
    {
        private IWebDriver driver;
                   
        
        public SignInPage(IWebDriver driver)
        {
          this.driver=driver;
                         
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        private IWebElement SignIntab => driver.FindElement(By.XPath("//a[contains(text(),'Sign')]"));

        // Finding the Email Field
        private IWebElement Email => driver.FindElement(By.Name("email"));

        //Finding the Password Field
        private IWebElement Password => driver.FindElement(By.Name("password"));

        //Finding the Login Button
         private IWebElement LoginBtn => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));

        #endregion
        [Obsolete]
        internal ProfilePage LoginSteps(string email,string password)
        {
            //Click on Sign In tab
            SignIntab.Clicks();
            //Enter the data in Username textbox
            Email.EnterText(email);
            //Enter the password 
            Password.EnterText(password);
            //Click on Login button
            LoginBtn.Click();
            return new ProfilePage(driver);

        }

    }

}