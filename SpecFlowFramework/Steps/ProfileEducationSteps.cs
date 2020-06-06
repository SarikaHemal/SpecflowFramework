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
        //    ProfilePage.AddEducation((string)data.University,(string)data.Country,(string)data.Tital,(string)data.Degree,(string)data.GraduationYear);

        //}
        [Given(@"I can add this education")]
        public void GivenICanAddThisEducation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.AddEducation(data.University, data.Country, data.Tital, data.Degree, "2005");
        }

        [Then(@"I can see added education")]
        public void ThenICanSeeAddedEducation()
        {
            Console.WriteLine("Success");
        }



    }
}
