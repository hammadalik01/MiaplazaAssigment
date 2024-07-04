using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationProject
{
    public static class HelperMethods
    {
        public static void ClearAndSendKeys(IWebDriver driver, By by, string text)
        {
            var element = driver.FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        public static void WaitForElementAndClick(IWebDriver driver, By by, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(by));
            element.Click();
        }

        public static void SelectDropdownOptionByText(IWebDriver driver, By by, string text)
        {
            IWebElement dropdownElement = driver.FindElement(by);
            SelectElement dropdown = new SelectElement(dropdownElement);
            dropdown.SelectByText(text);
        }
    }
}
