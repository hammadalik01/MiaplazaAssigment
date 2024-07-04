using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace AutomationProject
{
    public class BaseTest
    {
        public IWebDriver driver; 

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(); 
            driver.Manage().Window.Maximize(); 
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit(); 
                driver.Dispose();
            }
        }
    }
}
