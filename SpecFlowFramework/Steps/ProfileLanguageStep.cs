using AventStack.ExtentReports;
using Dynamitey;
using MarsFramework;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowFramework.Base;
using SpecFlowFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowFramework.Steps
{
    [Binding]
    public sealed class ProfileLanguageStep
    {
        private readonly IWebDriver driver;
        private readonly ProfilePage ProfilePage;

        [Obsolete]
        public ProfileLanguageStep(IWebDriver driver)
        {

            this.driver =driver ;
            ProfilePage = new ProfilePage(driver);
        }
        
       
        [Given(@"I can add this language")]
        [Obsolete]
        public void GivenICanAddThisLanguage(Table table)
        {

            ProfileProperties values = table.CreateInstance<ProfileProperties>();
            ProfilePage.AddLanguage(values.Language, values.LanguageLevel);
        }

        [Then(@"I can see added language")]
        [Obsolete]
        public void ThenICanSeeAddedLanguage(Table table)
        {

            ProfileProperties values = table.CreateInstance<ProfileProperties>();
            ProfilePage.ValidateLanguage(values.Language, values.LanguageLevel);
        }

        [Given(@"I can delete this language")]
        [Obsolete]
        [Test]
        public void GivenICanDeleteThisLanguage(Table table)
        {
            ProfileProperties values = table.CreateInstance<ProfileProperties>();
            ProfilePage.DeleteLanguge(values.Language, values.LanguageLevel);
        }

        [Then(@"I cannot see deleted language")]
        [Obsolete]
        public void ThenICannotSeeDeletedLanguage(Table table)
        {
            ProfileProperties values = table.CreateInstance<ProfileProperties>();
            ProfilePage.ValidateLanguage(values.Language, values.LanguageLevel);
        }

        [Given(@"I can edit this language")]
        [Obsolete]
        public void GivenICanEditThisLanguage(Table table)
        {
            ProfileProperties values = table.CreateInstance<ProfileProperties>();
            ProfilePage.EditLanguge(values.OldLanguage, values.OldLanguageLevel, values.NewLanguage, values.NewLanguageLevel);
        }

        [Then(@"I can see edited language")]
        [Obsolete]
        public void ThenICanSeeEditedLanguage(Table table)
        {
            ProfileProperties values = table.CreateInstance<ProfileProperties>();
            ProfilePage.ValidateEditLanguge(values.OldLanguage, values.OldLanguageLevel, values.NewLanguage, values.NewLanguageLevel);
        }




    }
}
