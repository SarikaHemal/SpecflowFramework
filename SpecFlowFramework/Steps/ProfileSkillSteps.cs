using MarsFramework;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowFramework.Steps
{
    [Binding]
    public class ProfileSkillSteps
    {
        private readonly IWebDriver driver;
        private readonly ProfilePage ProfilePage;

        [Obsolete]
        public ProfileSkillSteps(IWebDriver driver)
        {

            this.driver = driver;
            ProfilePage = new ProfilePage(driver);
        }
        [Given(@"I can add this Skills")]
        public void GivenICanAddThisSkills(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.AddSkills(data.Skill,data.SkillLevel);
        }
        
        [Then(@"I can see added Skills")]
        public void ThenICanSeeAddedSkills(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            string result=ProfilePage.ValidateSkill(data.Skill, data.SkillLevel);
            Assert.AreEqual(result, "Success");
        }
        [Given(@"I can delete this Skills")]
        public void GivenICanDeleteThisSkills(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.DeleteSkill(data.Skill, data.SkillLevel);
        }

        [Then(@"I cannot see deleted Skills")]
        public void ThenICannotSeeDeletedSkills(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            string result = ProfilePage.ValidateSkill(data.Skill, data.SkillLevel);
            Assert.AreEqual(result, "Record not found");
        }

        [Given(@"I can edit this Skills")]
        public void GivenICanEditThisSkills(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            ProfilePage.EditSkills(data.OldSkill, data.OldSkillLevel, data.NewSkill, data.NewSkillLevel);
        }

        [Then(@"I can see edited Skills")]
        public void ThenICanSeeEditedSkills(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
             string result=ProfilePage.ValidateEditSkill(data.OldSkill, data.OldSkillLevel, data.NewSkill, data.NewSkillLevel);
            Assert.AreEqual(result, "Success");
        }

    }
}
