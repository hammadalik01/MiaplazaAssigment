using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace AutomationProject
{
    public class Tests : BaseTest
    {
        [Test]
        public void Test1()
        {
            // Get the URL from configuration and put assertion on it if it failed
            string url = ConfigurationHelper.GetConfigValue("ApplicationSettings", "Url");
            if (url == null)
            {
                Assert.Fail("URL configuration value is null or not found.");
            }

            // Navigate to the URL
            driver.Navigate().GoToUrl(url);

            // Click on the link to navigate to MiaPrep Online High School
            driver.FindElement(Locators.OnlineHighSchoolLink).Click();

            // Click on Apply to Our School and Go to MOHS Initial Application
            driver.FindElement(Locators.ApplyButton).Click();

            // Fill Parent Information
            HelperMethods.ClearAndSendKeys(driver, Locators.FirstNameInput, ConfigurationHelper.GetConfigValue("ParentInformation", "FirstName"));
            HelperMethods.ClearAndSendKeys(driver, Locators.LastNameInput, ConfigurationHelper.GetConfigValue("ParentInformation", "LastName"));
            HelperMethods.ClearAndSendKeys(driver, Locators.EmailInput, ConfigurationHelper.GetConfigValue("ParentInformation", "Email"));
            HelperMethods.ClearAndSendKeys(driver, Locators.PhoneNumberInput, ConfigurationHelper.GetConfigValue("ParentInformation", "PhoneNumber"));

            // Wait for the dropdown to be clickable and select "No"
            HelperMethods.WaitForElementAndClick(driver, Locators.Dropdown, TimeSpan.FromSeconds(10));
            HelperMethods.WaitForElementAndClick(driver, Locators.DropdownOptionNo, TimeSpan.FromSeconds(10));

            // Click on options
            driver.FindElement(Locators.TikTokOption).Click();
            driver.FindElement(Locators.WordOfMouthOption).Click();

            // Select a date from the calendar
            driver.FindElement(Locators.CalendarDate).Click();
            driver.FindElement(Locators.Date31).Click();

            // Click on Next button
            driver.FindElement(Locators.NextButton).Click();

            // Fill Student Information
            HelperMethods.WaitForElementAndClick(driver, Locators.EnrollDropdown, TimeSpan.FromSeconds(10));
            HelperMethods.WaitForElementAndClick(driver, Locators.EnrollOptionOne, TimeSpan.FromSeconds(10));

            HelperMethods.ClearAndSendKeys(driver, Locators.StudentFirstNameInput, ConfigurationHelper.GetConfigValue("StudentInformation", "FirstName"));
            HelperMethods.ClearAndSendKeys(driver, Locators.StudentLastNameInput, ConfigurationHelper.GetConfigValue("StudentInformation", "LastName"));
            HelperMethods.ClearAndSendKeys(driver, Locators.StudentNicknameInput, ConfigurationHelper.GetConfigValue("StudentInformation", "Nickname"));
            HelperMethods.ClearAndSendKeys(driver, Locators.StudentEmailInput, ConfigurationHelper.GetConfigValue("StudentInformation", "Email"));
            HelperMethods.ClearAndSendKeys(driver, Locators.StudentPhoneNumberInput, ConfigurationHelper.GetConfigValue("StudentInformation", "PhoneNumber"));

            // Wait for the consent dropdown to be clickable and select "No"
            HelperMethods.WaitForElementAndClick(driver, Locators.ConsentDropdown, TimeSpan.FromSeconds(10));
            HelperMethods.WaitForElementAndClick(driver, Locators.ConsentOptionNo, TimeSpan.FromSeconds(10));

            // Enter birthdate
            HelperMethods.ClearAndSendKeys(driver, Locators.StudentBirthdateInput, ConfigurationHelper.GetConfigValue("StudentInformation", "Birthdate"));

            // Select gender
            HelperMethods.SelectDropdownOptionByText(driver, Locators.GenderDropdown, ConfigurationHelper.GetConfigValue("StudentInformation", "Gender"));

            // Select MiaPrep account option
            HelperMethods.SelectDropdownOptionByText(driver, Locators.MiaPrepAccountDropdown, ConfigurationHelper.GetConfigValue("StudentInformation", "MiaPrepAccountOption"));

            // Select student type
            HelperMethods.SelectDropdownOptionByText(driver, Locators.StudentTypeDropdown, ConfigurationHelper.GetConfigValue("StudentInformation", "StudentType"));

            // Select courses
            driver.FindElement(Locators.AlgebraOption).Click();
            driver.FindElement(Locators.GeometryOption).Click();
            driver.FindElement(Locators.English1Option).Click();
            driver.FindElement(Locators.English2Option).Click();
            driver.FindElement(Locators.PhysicalScienceOption).Click();
            driver.FindElement(Locators.ChemistryOption).Click();

            // Enter interests
            HelperMethods.ClearAndSendKeys(driver, Locators.PerformingArtsInput, ConfigurationHelper.GetConfigValue("StudentInformation", "Interest"));

            // Select learning needs option
            HelperMethods.SelectDropdownOptionByText(driver, Locators.LearningNeedsDropdown, ConfigurationHelper.GetConfigValue("StudentInformation", "LearningNeedsOption"));
        }
    }
}
