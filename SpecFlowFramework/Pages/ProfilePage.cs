using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SkillsSwap.Base;
using SpecFlowFramework.Base;
using SpecFlowFramework.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MarsFramework
{
    class ProfilePage
    {

        private readonly IWebDriver driver;
        [Obsolete]
        public ProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }
       

        #region  Initialize Web Elements 
        //Click on Availability Edit button
        private IWebElement AvailabilityTimeEdit => driver.FindElement
            (By.XPath("i[@class='right floated outline small write icon'])[1]"));

        //Click on Availability Time dropdown
        private IWebElement AvailabilityTime => driver.FindElement(By.Name("availabiltyType"));

        //Click on Availability Time option
        private IWebElement AvailabilityTimeOpt => driver.FindElement(By.XPath("//option[@value='0'"));

        //Click on Availability Hour Edit button
        private IWebElement AvailabilityHoursEdit => driver.FindElement(By.XPath("//i[@class='right floated outline small write icon'])[2]"));

        //Click on Availability Hour dropdown
        private IWebElement AvailabilityHoursOpt => driver.FindElement(By.CssSelector("select.ui.right.labeled.dropdown"));

        //Click on salary
        private IWebElement Salary => driver.FindElement(By.XPath("//select[@name='availabiltyTarget']"));

        //Click on EarnTarget Edit button
        private IWebElement EarnTargetEdit => driver.FindElement(By.XPath("(//i[@class='right floated outline small write icon'])[3]"));
        //Click on Location
        private IWebElement Location => driver.FindElement(By.XPath
            ("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div"));

        //Choose Location
        private IWebElement LocationOpt => driver.FindElement(By.XPath
            ("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]"));

        //Click on City
        private IWebElement City => driver.FindElement
            (By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div"));

        //Choose City
        private IWebElement CityOpt => driver.FindElement
            (By.XPath("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]"));


        //Language tab 
        private IWebElement LangTab => driver.FindElement(By.XPath("//a[contains(text(),'Languages')]"));

        //Click on Add new to button in language
        private IWebElement AddNewLangBtn => driver.FindElement(By.XPath
            ("(//div[@class='ui teal button '][contains(.,'Add New')])[1]"));

        //Enter the Language on text box
        private IWebElement AddLangText => driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));

        //Select the Language level from dropbox
        private IWebElement ChooseLangLevel => driver.FindElement(By.XPath("//select[@class='ui dropdown']"));

        //click on add button language
        private IWebElement AddLangButton => driver.FindElement(By.XPath("//input[contains(@value,'Add')]"));

        //Skill tab 
        private IWebElement SkillsTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));


        //Click on Add new to add new skill
        private IWebElement AddNewSkillBtn => driver.FindElement(By.XPath("(//div[contains(@class,'ui teal button')])[2]"));

        //Enter the Skill on text box
        private IWebElement AddSkillText => driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Skill')]"));

        //Click on skill level dropdown
        private IWebElement ChooseSkill => driver.FindElement(By.XPath("//select[contains(@class,'ui fluid dropdown')]"));

        //Add button Skill
        private IWebElement AddSkillButton => driver.FindElement(By.XPath("//input[contains(@value,'Add')]"));
        //Educaiton Tab
        private IWebElement EducationTab => driver.FindElement(By.XPath("//a[contains(@data-tab,'third')]"));
        //Click on Add new button in Educaiton
        private IWebElement AddNewEducationButton => driver.FindElement
            (By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[2]"));

        //Enter university in the text box
        private IWebElement EnterUniversity => driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));

        //Choose the country
        private IWebElement ChooseCountry => driver.FindElement(By.XPath("//select[contains(@name,'country')]"));

        //Click on Title dropdown
        private IWebElement ChooseEducationTitle => driver.FindElement(By.XPath("//select[contains(@name,'title')]"));


        //Degree
        private IWebElement Degree => driver.FindElement(By.XPath("//input[@placeholder='Degree']"));

        //Year of graduation
        private IWebElement DegreeYear => driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));


        //Click on Add
        private IWebElement AddEduButton => driver.FindElement(By.XPath("//input[contains(@value,'Add')]"));
        //Skill tab 
        private IWebElement CertificationTab => driver.FindElement(By.XPath("//a[contains(.,'Certifications')]"));

        //Add new Certificate
        private IWebElement AddNewCertiButton => driver.FindElement
            (By.XPath("(//div[@class='ui teal button '][contains(.,'Add New')])[3]"));

        //Enter Certification Name
        private IWebElement EnterCerti => driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));

        //Certified from
        private IWebElement CertiFrom => driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));

        //Year
        private IWebElement CertiYear => driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));

        //Add Ceritification
        private IWebElement AddCerti => driver.FindElement(By.XPath("//input[contains(@value,'Add')]"));

        //Add Desctiption
        private IWebElement Description => driver.FindElement(By.XPath
            ("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea"));

        //Click on Save Button
        private IWebElement Save => driver.FindElement(By.XPath
            ("//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]"));

        //Profile username for change password
        private IWebElement UserName => driver.FindElement(By.CssSelector("span.item.ui.dropdown.link"));



        #endregion

        public string IsLogin()
        {
            Thread.Sleep(3000);
            string logo = driver.FindElement(By.XPath("//a[contains(.,'Mars Logo')]")).Text;
            String img = SaveScreenShot.SaveScreenshot(driver, "Report");//AddScreenCapture(@"");


            if (logo == "Mars Logo")
            {
                CommonMethod.test.Log(Status.Pass, "Login Success: " + img);
                Console.WriteLine("Pass");
                return "Pass";
            }
            else
            {
                CommonMethod.test.Log(Status.Fail, "Something went Wrong: " + img);
                Console.WriteLine("Fail");
                return "Fail";

            }
        }
        //to navigate profile page
        [Obsolete]
        public void ProfileButton()
        {
            //to navigate profile page
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//section//div//a[@class='item'][@href='/Account/Profile']")).Click();


        }

        public string EditProfileTest(string TimeValue, string HourValue, string EarnTargetValue)
        {

            //Click on Edit sign in Availability Time
            AvailabilityTimeEdit.Clicks();
            Thread.Sleep(3000);
            //select time
            SelectElement SelectAvailableTime = new SelectElement(AvailabilityTime);
            SelectAvailableTime.SelectByValue(TimeValue);
            Thread.Sleep(2000);
            //Select Availability hours
            AvailabilityHoursEdit.Clicks();
            Thread.Sleep(3000);
            SelectElement SelectAvailableHour = new SelectElement(AvailabilityHoursOpt);
            SelectAvailableHour.SelectByValue(HourValue);
            //select Earn Target
            Thread.Sleep(2000);
            EarnTargetEdit.Clicks();
            SelectElement SelectEarnTarget = new SelectElement(Salary);
            SelectEarnTarget.SelectByValue(EarnTargetValue);

            return "Pass";

        }


        #region Language
        [Obsolete]
        public void AddLanguage(string language, string level)
        {
            //to navigate Profile
            ProfileButton();

            //click on language Tab
            LangTab.Clicks();
            Thread.Sleep(2000);
            AddNewLangBtn.Clicks();
            Thread.Sleep(2000);
            AddLangText.EnterText(language);

            ChooseLangLevel.SelectFromDDL(level);
            Thread.Sleep(2000);
            //add new button
            AddLangButton.Clicks();

        }



        // DeleteLanguage() deletes a language skill from Languages table in user's profile page
        [Obsolete]
        public string DeleteLanguge(string language, string level)
        {
            int column = SearchLanguageTableData(language, level);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");
            }
            else
            {
                driver.FindElement(By.XPath("(//i[@class='remove icon'])[" + column + "]")).Click();
                Console.WriteLine("language deleted");
            }
            return "Success";
        }
        [Obsolete]
        public string EditLanguge(string language, string level, string newLanguage, string newLevel)
        {

            int column = SearchLanguageTableData(language, level);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                driver.FindElement(By.XPath("(//i[@class='outline write icon'])[" + column + "]")).Click();
                IWebElement languageTextbox = driver.FindElement(By.XPath("//input[contains(@placeholder,'Add Language')]"));
                languageTextbox.Clear();
                languageTextbox.EnterText(newLanguage);
                IWebElement languageDropbox = driver.FindElement(By.XPath("//select[@class='ui dropdown']"));
                languageDropbox.SelectFromDDL(newLevel);
                driver.FindElement(By.XPath("//input[contains(@value,'Update')]")).Clicks();
                Console.WriteLine("language edited");
                Thread.Sleep(3000);
            }
            return "Success";
        }

        [Obsolete]
        public string ValidateEditLanguge(string language, string level, string newLanguage, string newLevel)
        {
            int oldColumn = SearchLanguageTableData(language, level);
            int newColumn = SearchLanguageTableData(newLanguage, newLevel);
            if (oldColumn <= 0 && newColumn >= 0)
            {
                Console.WriteLine("Language Updated");
                return "Success";

            }
            else
            {
                Console.WriteLine("Language not Updated");
                return "UnSuccess";
            }
        }
        [Obsolete]
        public int SearchLanguageTableData(string language, string level)
        {
            //to navigate Profile
            ProfileButton();
            //click on language Tab
            LangTab.Clicks();
            // Gets languages table
            IWebElement table = CommonMethod.WaitForElement(driver, By.XPath
                ("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/" +
                "form/div[2]/div/div[2]/div/table"), 10);
            // Languages tables has multiple body elements for each lanugage skill in the table
            IList<IWebElement> body = table.FindElements(By.TagName("tbody"));

            int count = 0;
            // Looping thorugh each body element
            foreach (var b in body)
            {
                count++;
                // Get table rows in each body
                var rows = b.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var columns = row.FindElements(By.TagName("td")).ToList();
                    if ((columns[0].Text == language) && (columns[1].Text == level))
                    {

                        return count;

                    }

                }
            }

            return -1;

        }


        [Obsolete]
        public string ValidateLanguage(string language, string level)
        {
            int column = SearchLanguageTableData(language, level);
            if (column <= 0)
            {
                return "Record not found";
            }
            else
            {
                return "Success";
            }


            //string ActualLanguage=driver.FindElement(By.XPath("//td[contains(.,'"+language+"')]")).Text;
            //string ActualLevel= driver.FindElement(By.XPath("//td[contains(.,'" + level + "')]")).Text;
            //Console.WriteLine("added laguage  " + ActualLanguage);
            //Console.WriteLine("added level  " + ActualLevel);
            //if (language == ActualLanguage && level== ActualLevel)
            //    return "Pass";
            //else
            //    return "Fail";


        }
        #endregion
        #region Skill
        [Obsolete]
        public string AddSkills(string skill, string level)
        {
            //to navigate Profile
            ProfileButton();
            Thread.Sleep(2000);
            //click on language Tab
            SkillsTab.Clicks();
            Thread.Sleep(2000);
            AddNewSkillBtn.Clicks();
            Thread.Sleep(2000);
            AddSkillText.EnterText(skill);
            ChooseSkill.SelectFromDDL(level);
            Thread.Sleep(2000);
            //add new button
            AddSkillButton.Clicks();
            Thread.Sleep(2000);
            return "Add skill Successfully";
        }

        [Obsolete]
        public string ValidateSkill(string Skill, string level)
        {
            int column = SearchSkillTableData(Skill, level);
            if (column <= 0)
            {
                return "Record not found";
            }
            else
            {
                return "Success";
            }


        }

        [Obsolete]
        public int SearchSkillTableData(string skill, string level)
        {
            ProfileButton();
            SkillsTab.Clicks();
            // Gets languages table
            IWebElement table = CommonMethod.WaitForElement(driver, By.XPath
                ("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/" +
                "form/div[3]/div/div[2]/div/table"), 10);
            // Languages tables has multiple body elements for each lanugage skill in the table
            IList<IWebElement> body = table.FindElements(By.TagName("tbody"));

            int count = 0;
            // Looping thorugh each body element
            foreach (var b in body)
            {
                count++;
                // Get table rows in each body
                var rows = b.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var columns = row.FindElements(By.TagName("td")).ToList();
                    if ((columns[0].Text == skill) && (columns[1].Text == level))
                    {
                        Console.WriteLine("Skills Found");
                        return count;

                    }

                }
            }

            return -1;

        }
        [Obsolete]
        public string DeleteSkill(string skill, string level)
        {
            int column = SearchSkillTableData(skill, level);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]" +
                    "/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[" + column + "]/tr/td[3]/span[2]/i"));
                //driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/" +
                //        "div[3]/form/div[3]/div/div[2]/div/table/tbody[" + column + "]/tr/td[3]/span[2]/i")).Clicks();
                Console.WriteLine("language deleted");
            }

            return "Success";
        }
        [Obsolete]
        public string EditSkills(string skill, string level, string newSkill, string newLevel)
        {

            int column = SearchSkillTableData(skill, level);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                column = column + 1;
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > " +
                    "form > div.ui.bottom.attached.tab.segment.tooltip-target.active >" +
                    " div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child("+column+") > tr > td.right.aligned > span:nth-child(1) > i"));
                //driver.FindElement(By.XPath("//*[@id='account - profile - section']" +
                //    "/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]" +
                //    "/div/table/tbody[" + column + "]/tr/td[3]/span[1]/i")).Clicks();
                Thread.Sleep(1000);
                IWebElement SkillTextbox = driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
                SkillTextbox.Clear();
                SkillTextbox.EnterText(newSkill);
                Thread.Sleep(1000);
                IWebElement skillDropbox = driver.FindElement(By.CssSelector("select.ui.fluid.dropdown"));
                skillDropbox.SelectFromDDL(newLevel);
                Thread.Sleep(3000);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > " +
                    "tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button")).Clicks();
                Console.WriteLine("skill edited");
                Thread.Sleep(3000);
            }
            return "Success";
        }
        [Obsolete]
        public string ValidateEditSkill(string skill, string level, string newSkill, string newLevel)
        {
            int oldColumn = SearchSkillTableData(skill, level);
            int newColumn = SearchSkillTableData(newSkill, newLevel);
            if (oldColumn <= 0 && newColumn >= 0)
            {
                Console.WriteLine("Skill Updated");
                return "Success";
            }
            else
            {
                Console.WriteLine("New skill not updated");
                return "Unsuccess";
            }


        }
        #endregion
        #region Education
        [Obsolete]
        public void AddEducation(string collegeName, string country, string title, string degree, string yearOfFinish)
        {
            //to navigate Profile
            ProfileButton();
            //click on language Tab
            EducationTab.Clicks();
            AddNewEducationButton.Clicks();
            EnterUniversity.EnterText(collegeName);
            ChooseCountry.SelectFromDDL(country);
            ChooseEducationTitle.SelectFromDDL(title);
            Degree.EnterText(degree);
            DegreeYear.SelectFromDDL(yearOfFinish);
            AddEduButton.Clicks();
            Thread.Sleep(1000);
        }

        [Obsolete]
        public string ValidateEducation(string collegeName, string country, string title, string degree, string yearOfFinish)
        {
            int column = SearchEducationTableData(collegeName, country, title, degree, yearOfFinish);
            if (column <= 0)
            {
                return "Record not found";
            }
            else
            {
                return "Success";
            }
        }

        [Obsolete]
        public int SearchEducationTableData(string collegeName, string country, string title, string degree, string yearOfFinish)
        {
            ProfileButton();
            EducationTab.Clicks();
            // Gets languages table
            IWebElement table = CommonMethod.WaitForElement(driver, By.XPath
                ("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/" +
                "form/div[4]/div/div[2]/div/table"), 10);
            // Languages tables has multiple body elements for each lanugage skill in the table
            IList<IWebElement> body = table.FindElements(By.TagName("tbody"));

            int count = 0;
            // Looping thorugh each body element
            foreach (var b in body)
            {
                count++;
                // Get table rows in each body
                var rows = b.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var columns = row.FindElements(By.TagName("td")).ToList();
                    if ((columns[0].Text == country) && (columns[1].Text == collegeName) && (columns[2].Text == title) &&
                        (columns[3].Text == degree) && (columns[4].Text == yearOfFinish))
                    {
                        Console.WriteLine("Education Found");
                        return count;

                    }

                }
            }

            return -1;

        }

        [Obsolete]
        public string DeleteEducation(string collegeName, string country, string title, string degree, string yearOfFinish)
        {
            int column = SearchEducationTableData(collegeName, country, title, degree, yearOfFinish);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");
            }
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("(//i[@class='remove icon'])[3]")).Clicks();
            //driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) >" +
            //    " div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active >" +
            //    " div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child("+column+1+") > tr > td.right.aligned > span:nth-child(2) > i")).Clicks();
            //Console.WriteLine("education deleted");

            return "Success";
        }
        [Obsolete]
        public string EditEducation(string collegeName, string country, string title, string degree, string yearOfFinish,
            string newCollegeName, string newCountry, string newTitle, string NewDegree, string NewYearOfFinish)
        {

            int column = SearchEducationTableData(collegeName, country, title, degree, yearOfFinish);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("(//i[@class='outline write icon'])[4]")).Clicks();
                Thread.Sleep(1000);
                IWebElement collegeTextbox = driver.FindElement(By.XPath("//input[contains(@placeholder,'College/University Name')]"));
                collegeTextbox.Clear();
                collegeTextbox.EnterText(newCollegeName);

                IWebElement countryDropbox = driver.FindElement(By.XPath("//select[contains(@name,'country')]"));
                countryDropbox.SelectFromDDL(newCountry);
                Thread.Sleep(1000);

                IWebElement titleDropbox = driver.FindElement(By.XPath("//select[contains(@name,'title')]"));
                titleDropbox.SelectFromDDL(newTitle);
                Thread.Sleep(1000);

                IWebElement degreeTextbox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                degreeTextbox.Clear();
                degreeTextbox.EnterText(NewDegree);

                IWebElement yearDropbox = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                yearDropbox.SelectFromDDL(NewYearOfFinish);
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("//input[contains(@value,'Update')]")).Clicks();
                Console.WriteLine("Education edited");
                Thread.Sleep(3000);
            }
            return "Success";
        }
        [Obsolete]
        public string ValidateEditEducation(string collegeName, string country, string title, string degree, string yearOfFinish,
            string newCollegeName, string newCountry, string newTitle, string NewDegree, string NewYearOfFinish)
        {
            int oldColumn = SearchEducationTableData(collegeName, country, title, degree, yearOfFinish);
            int newColumn = SearchEducationTableData(newCollegeName, newCountry, newTitle, NewDegree, NewYearOfFinish);
            if (oldColumn <= 0 && newColumn >= 0)
            {
                Console.WriteLine("Education Record Updated");
                return "Success";
            }
            else
            {
                Console.WriteLine("New Education not updated");
                return "Unsuccess";
            }

        }
        #endregion
        #region Certificate
        [Obsolete]
        public void AddCertification(string certificate, string from, string year)
        {
            //to navigate Profile
            ProfileButton();
            Thread.Sleep(2000);
            //click on skill Tab
            CertificationTab.Clicks();
            AddNewCertiButton.Clicks();
            EnterCerti.EnterText(certificate);
            CertiFrom.EnterText(from);
            CertiYear.SelectFromDDL(year);
            Thread.Sleep(2000);
            AddCerti.Clicks();

            Thread.Sleep(2000);
            Console.WriteLine(" Add skill Successfully");
        }

        [Obsolete]
        public int SearchCertificateTableData(string certificateName, string from, string year)
        {
            ProfileButton();
            CertificationTab.Clicks();
            // Gets languages table
            IWebElement table = CommonMethod.WaitForElement(driver, By.XPath
                ("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/" +
                "form/div[5]/div/div[2]/div/table"), 10);
            // Languages tables has multiple body elements for each lanugage skill in the table
            IList<IWebElement> body = table.FindElements(By.TagName("tbody"));

            int count = 0;
            // Looping thorugh each body element
            foreach (var b in body)
            {
                count++;
                // Get table rows in each body
                var rows = b.FindElements(By.TagName("tr"));
                foreach (var row in rows)
                {
                    var columns = row.FindElements(By.TagName("td")).ToList();
                    if ((columns[0].Text == certificateName) && (columns[1].Text == from) && (columns[2].Text == year))
                    {
                        Console.WriteLine("Certificate Found");
                        return count;

                    }

                }
            }
            return 0;
        }

        [Obsolete]
        public string ValidateCertificate(string certificateName, string from, string year)
        {
            int column = SearchCertificateTableData(certificateName, from, year);
            if (column <= 0)
            {
                return "Record not found";
            }
            else
            {
                return "Success";
            }


        }
        [Obsolete]
        public string DeleteCertificate(string certificateName, string from, string year)
        {
            int column = SearchCertificateTableData(certificateName, from, year);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");
            }
            column = column + 1;
            Thread.Sleep(2000);
            // driver.FindElement(By.XPath("(//i[@class='remove icon'])[3]")).Clicks();
            driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > " +
                "div > table > tbody:nth-child(" + column + ") > tr > td.right.aligned > span:nth-child(2) > i")).Click();
            //driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/" +
            //  "div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + column + "]/tr/td[4]/span[2]/i")).Clicks();

            return "Success";
        }
        [Obsolete]
        public string EditCertificate(string certificateName, string from, string year, string newCertificateName, string newFrom, string newYear)
        {

            int column = SearchCertificateTableData(certificateName, from, year);
            if (column <= 0)
            {
                Console.WriteLine("Record not found");

            }
            else
            {
                column = column + 1;
                Thread.Sleep(2000);
                driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div.row > div.twelve.wide.column.scrollTable > " +
                "div > table > tbody:nth-child(" + column + ") > tr > td.right.aligned > span:nth-child(1) > i")).Click(); ;
                Thread.Sleep(1000);
                IWebElement certificateTextbox = driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));
                certificateTextbox.Clear();
                certificateTextbox.EnterText(newCertificateName);

                IWebElement fromTextbox = driver.FindElement(By.XPath("//input[contains(@placeholder,'Certificate or Award')]"));
                fromTextbox.Clear();
                fromTextbox.EnterText(newFrom);

                IWebElement yearDropbox = driver.FindElement(By.XPath("//select[@class='ui fluid dropdown']"));
                yearDropbox.SelectFromDDL(newYear);

                driver.FindElement(By.XPath("//input[contains(@value,'Update')]")).Clicks();

                Thread.Sleep(3000);
            }
            return "Success";
        }
        [Obsolete]
        public string ValidateEditCertificate(string certificateName, string from, string year, string newCertificateName, string newFrom, string newYear)
        {
            int oldColumn = SearchCertificateTableData(certificateName, from, year);
            int newColumn = SearchCertificateTableData(newCertificateName, newFrom, newYear);
            if (oldColumn <= 0 && newColumn >= 0)
            {
                Console.WriteLine("Record Updated");
                return "Success";
            }
            else
            {
                Console.WriteLine("New record not updated");
                return "Unsuccess";
            }


        }
        #endregion
        [Obsolete]
        public ProfilePage ChangePassword()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(UserName).Build().Perform();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='item'][contains(.,'Change Password')]")).Clicks();
            //Populate the Excel sheet
            //Driver.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");
            //Enter the password 
            //IWebElement CurrentPassword = driver.FindElement(By.XPath("//input[@placeholder='Current Password']"));
            //CurrentPassword.SendKeys(Driver.ExcelLib.ReadData(2, "Password"));
            IWebElement CurrentPassword = driver.FindElement(By.XPath("//input[@placeholder='Current Password']"));
            CurrentPassword.SendKeys("234567");
            driver.FindElement(By.XPath("//input[@placeholder='New Password']")).EnterText("123456");
            driver.FindElement(By.XPath("//input[@placeholder='Confirm Password']")).EnterText("123456");
            driver.FindElement(By.XPath("//button[@type='button'][contains(.,'Save')]")).Clicks();
            return new ProfilePage(driver);


        }



    }



}