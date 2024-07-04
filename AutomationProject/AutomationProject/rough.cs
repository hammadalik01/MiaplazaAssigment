using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutomationProject
{
    public class rough
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
        }



        
        public void Test1()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://miacademy.co/#/");
            // Perform assertion
            string currentUrl = Driver.Url;
            Assert.AreEqual("https://miacademy.co/#/", currentUrl, "URLs do not match.");


            // Click on the link to navigate to MiaPrep Online High School
            IWebElement linkElement = Driver.FindElement(By.XPath("//div[@class='mia-announcementText']//a[contains(text(), 'Online High School')]"));
            linkElement.Click();

            //Click on Apply to Our School and Go to MOHS Initial Application 
            IWebElement Apply_Button = Driver.FindElement(By.XPath("//div[@class='wp-block-button']"));
            Apply_Button.Click();

            //Fill Parent Information

            Driver.FindElement(By.XPath("//label[text()='First Name']/preceding-sibling::input[@name='Name']")).SendKeys("Hammad Ali");
            Driver.FindElement(By.XPath("//label[text()='Last Name']/preceding-sibling::input[@name='Name']")).Clear();
            Driver.FindElement(By.XPath("//label[text()='Last Name']/preceding-sibling::input[@name='Name']")).SendKeys("Khan");
            Driver.FindElement(By.Id("Email-arialabel")).Clear();
            Driver.FindElement(By.Id("Email-arialabel")).SendKeys("hammadalik01@gmail.com");
            Driver.FindElement(By.Id("PhoneNumber")).Clear();
            Driver.FindElement(By.Id("PhoneNumber")).SendKeys("1234567891");


            // Wait for the dropdown to be clickable
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement dropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("select2-Dropdown-arialabel-container")));

            // Click to open the dropdown
            dropdown.Click();


            // Wait for the dropdown options to be visible
            IWebElement optionNo = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[@class='select2-results']/ul/li[text()='No']")));

            // Click the "No" option
            optionNo.Click();



            //Wrong Code End Here 



            Driver.FindElement(By.XPath("//*[text() = \"TikTok\"]")).Click();
            Driver.FindElement(By.XPath("//*[text() = \"Word of mouth\"]")).Click();

            //Error From Here 
            Driver.FindElement(By.XPath("//div[@class=\"calendarCont\"]//div[@aria-label=\"Date\"]")).Click();
            //Driver.FindElement(By.Id("#select2-gak2-container")).Click();

            //Driver.FindElement(By.CssSelector("span.select2.select2-container.select2-container--default.monthSeparator.liveDateTimeDropdown.select2-container--below.select2-container--open.select2-container--focus > span.selection > span.select2-selection.select2-selection--single > span.select2-selection__arrow")).Click();
            Driver.FindElement(By.XPath("//*[text() = \"31\"]")).Click();

            //Click on Next button
            Driver.FindElement(By.XPath("//ul[@page_link_name='Page']//button[@type='button']")).Click();

            //Student Information

            // Wait for the dropdown to be clickable
            IWebElement Enrolldropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("select2-Dropdown1-arialabel-container")));
            // Click to open the dropdown
            Enrolldropdown.Click();
            // Wait for the dropdown options to be visible
            IWebElement optionOne = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//*[text() = \"One\"])[2]")));
            // Click the "Yes" option
            optionOne.Click();

            Driver.FindElement(By.XPath("//input[@complink='Name2_First']")).SendKeys("Jhon");
            Driver.FindElement(By.XPath("//input[@complink=\"Name2_Last\"]")).SendKeys("King");
            Driver.FindElement(By.Id("SingleLine5-arialabel")).SendKeys("jhoni");
            Driver.FindElement(By.Id("Email2-arialabel")).SendKeys("jhontw@mailinator.com");
            Driver.FindElement(By.Id("PhoneNumber2")).SendKeys("+49123456789");


            // Wait for the dropdown to be clickable
            IWebElement Consetdropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("select2-Dropdown2-arialabel-container")));
            // Click to open the dropdown
            Consetdropdown.Click();
            // Wait for the dropdown options to be visible
            IWebElement optionNO = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@id='Dropdown2-arialabel']//option[@value='No']")));
            // Click the "NO" option
            optionNO.Click();

            Driver.FindElement(By.Id("SingleLine3-arialabel")).Click();
            Driver.FindElement(By.Id("SingleLine3-arialabel")).SendKeys("16-04-1992");

            //click On gender Start

            // Wait for the dropdown to be clickable
            WebDriverWait Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            IWebElement dropdownElement = Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("Dropdown3-arialabel")));

            // Initialize a SelectElement for the dropdown
            SelectElement Dropdown = new SelectElement(dropdownElement);

            // Select by visible text
            Dropdown.SelectByText("Male");

            //click On gender End

            //Select MiaPrep account for this student

            // Wait for the dropdown to be clickable
            IWebElement Miadropdown = Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("Dropdown4-arialabel")));

            // Initialize a SelectElement for the dropdown
            SelectElement SelectOption = new SelectElement(Miadropdown);

            // Select by visible text
            SelectOption.SelectByText("No");

            //End MiaPrep account for this student

            // Wait for the dropdown to be clickable
            IWebElement Studentdropdown = Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("Dropdown5-arialabel")));

            // Initialize a SelectElement for the dropdown
            SelectElement StudentOption = new SelectElement(Studentdropdown);

            // Select by visible text
            StudentOption.SelectByText("Homeschool");


            Driver.FindElement(By.XPath("//*[text() = \"Algebra 1\"]")).Click();
            Driver.FindElement(By.XPath("//*[text() = \"Geometry\"]")).Click();
            Driver.FindElement(By.XPath("//*[text() = \"English 1\"]")).Click();
            Driver.FindElement(By.XPath("//*[text() = \"English 2\"]")).Click();
            Driver.FindElement(By.XPath("//*[text() = \"Physical Science\"]")).Click();
            Driver.FindElement(By.XPath("//*[text() = \"Chemistry\"]")).Click();

            Driver.FindElement(By.Id("MultiLine-arialabel")).SendKeys("Performing Arts");



            //Start learning needs DropDown

            // Wait for the dropdown to be clickable
            IWebElement Challengesdropdown = Wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("Dropdown13-arialabel")));

            // Initialize a SelectElement for the dropdown
            SelectElement ChallengesSelectOption = new SelectElement(Challengesdropdown);

            // Select by visible text
            ChallengesSelectOption.SelectByText("No");

            //End learning needs DropDown





        }



        [TearDown]
        public void TearDown()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
        }


    }
}
