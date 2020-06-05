using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SpecFlowFramework.Utils;

namespace SpecFlowFramework.Base
{
    public class WebDriverContext
    {
        private readonly IObjectContainer _objectContainer;
        public static IWebDriver driver { set; get; }
        public WebDriverContext(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            switch (ConstantUtils.Browser)
            {

                case "FireFox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
            }
            _objectContainer.RegisterInstanceAs(driver);
            


        }
    }
}