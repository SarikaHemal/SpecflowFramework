using Dynamitey;
using MarsFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowFramework
{
    [Binding]
    public class ProfileEducationSteps
    {
        private readonly ProfilePage ProfilePage;

        [Obsolete]
        public ProfileEducationSteps(IWebDriver driver)
        {
            ProfilePage = new ProfilePage(driver);
        }
        //[Given(@"I can add this education")]
        //[Obsolete]
        //public void GivenICanAddThisEducation(IEnumerable<dynamic> dataList)
        //{
        //    var data = dataList.First();
        //    //string GraduationYear = (string)Convert.ChangeType(data.GraduationYear, typeof(string));

        //    ProfilePage.AddEducation(data.University,data.Country,data.Title,data.Degree, Convert.ToString(data.GraduationYear));

        //}
        [Given(@"I can add this education")]
        public void GivenICanAddThisEducation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.AddEducation(data.University, data.Country, data.Title, data.Degree,Convert.ToString(data.GraduationYear));
        }

        [Then(@"I can see added education")]
        public void ThenICanSeeAddedEducation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.ValidateEducation(data.University, data.Country, data.Title, data.Degree, Convert.ToString(data.GraduationYear));
        }
        [Given(@"I can delete this education")]
        public void GivenICanDeleteThisEducation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.DeleteEducation(data.University, data.Country, data.Title, data.Degree, Convert.ToString(data.GraduationYear));
        }
    

        [Then(@"I cannot see deleted education")]
        public void ThenICannotSeeDeletedEducation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.ValidateEducation(data.University, data.Country, data.Title, data.Degree, Convert.ToString(data.GraduationYear));

        }

        [Given(@"I can edit this education")]
        public void GivenICanEditThisEducation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.EditEducation(data.University, data.Country, data.Title, data.Degree, Convert.ToString(data.GraduationYear),
                data.NewUniversity, data.NewCountry, data.NewTitle, data.NewDegree, Convert.ToString(data.NewGraduationYear));

        }

        [Then(@"I can see edited education")]
        public void ThenICanSeeEditedEducation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.ValidateEditEducation(data.University, data.Country, data.Title, data.Degree, Convert.ToString(data.GraduationYear),
                data.NewUniversity, data.NewCountry, data.NewTitle, data.NewDegree, Convert.ToString(data.NewGraduationYear));
        }



    }
}
