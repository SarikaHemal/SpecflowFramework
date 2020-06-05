using Dynamitey;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SkillsSwap.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFramework.Utils
{
    public static class ExtentionMethod
    {
        

        
        public static void EnterText(this IWebElement element, string value)
        {
              element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element)
        {
             element.Click();
        }

        public static void SelectFromDDL(this IWebElement element, string value)
        {
             new SelectElement(element).SelectByText(value);
        }


    }
}

