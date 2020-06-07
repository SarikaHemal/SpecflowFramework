using MarsFramework;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowFramework.Steps
{
    [Binding]
    public sealed class ProfileCertificateSteps
    {
        private readonly ProfilePage ProfilePage;

        [Obsolete]
        public ProfileCertificateSteps(IWebDriver driver)
        {
            ProfilePage = new ProfilePage(driver);
        }
        [Given(@"I can add this Certificate")]
        public void GivenICanAddThisCertificate(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.AddCertification(data.Certificate, data.From,Convert.ToString(data.Year));
        }

        [Then(@"I can see added Certificate")]
        public void ThenICanSeeAddedCertificate(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            string result =ProfilePage.ValidateCertificate(data.Certificate, data.From, Convert.ToString(data.Year));
            Assert.AreEqual(result, "Success");
        }
        [Given(@"I can delete this Certificate")]
        public void GivenICanDeleteThisCertificate(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.DeleteCertificate(data.Certificate, data.From, Convert.ToString(data.Year));
        }

        [Then(@"I cannot see deleted Certificate")]
        public void ThenICannotSeeDeletedCertificate(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            string result=ProfilePage.ValidateCertificate(data.Certificate, data.From, Convert.ToString(data.Year));
            Assert.AreEqual(result, "Record not found");
        }
        [Given(@"I can edit this Certificate")]
        public void GivenICanEditThisCertificate(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.EditCertificate(data.Certificate, data.From, Convert.ToString(data.Year)
                , data.NewCertificate, data.NewFrom, Convert.ToString(data.NewYear));
        }

        [Then(@"I can see edited Certificate")]
        public void ThenICanSeeEditedCertificate(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.ValidateEditCertificate(data.Certificate, data.From, Convert.ToString(data.Year)
                , data.NewCertificate, data.NewFrom, Convert.ToString(data.NewYear));
        }



    }
}
