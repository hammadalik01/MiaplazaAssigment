using OpenQA.Selenium;

namespace AutomationProject
{
    public static class Locators
    {
        public static readonly By OnlineHighSchoolLink = By.XPath("//div[@class='mia-announcementText']//a[contains(text(), 'Online High School')]");
        public static readonly By ApplyButton = By.XPath("//div[@class='wp-block-button']");
        public static readonly By FirstNameInput = By.XPath("//label[text()='First Name']/preceding-sibling::input[@name='Name']");
        public static readonly By LastNameInput = By.XPath("//label[text()='Last Name']/preceding-sibling::input[@name='Name']");
        public static readonly By EmailInput = By.Id("Email-arialabel");
        public static readonly By PhoneNumberInput = By.Id("PhoneNumber");
        public static readonly By Dropdown = By.Id("select2-Dropdown-arialabel-container");
        public static readonly By DropdownOptionNo = By.XPath("//span[@class='select2-results']/ul/li[text()='No']");
        public static readonly By TikTokOption = By.XPath("//*[text() = \"TikTok\"]");
        public static readonly By WordOfMouthOption = By.XPath("//*[text() = \"Word of mouth\"]");
        public static readonly By CalendarDate = By.XPath("//div[@class=\"calendarCont\"]//div[@aria-label=\"Date\"]");
        public static readonly By Date31 = By.XPath("//*[text() = \"31\"]");
        public static readonly By NextButton = By.XPath("//ul[@page_link_name='Page']//button[@type='button']");
        public static readonly By EnrollDropdown = By.Id("select2-Dropdown1-arialabel-container");
        public static readonly By EnrollOptionOne = By.XPath("(//*[text() = \"One\"])[2]");
        public static readonly By StudentFirstNameInput = By.XPath("//input[@complink='Name2_First']");
        public static readonly By StudentLastNameInput = By.XPath("//input[@complink=\"Name2_Last\"]");
        public static readonly By StudentNicknameInput = By.Id("SingleLine5-arialabel");
        public static readonly By StudentEmailInput = By.Id("Email2-arialabel");
        public static readonly By StudentPhoneNumberInput = By.Id("PhoneNumber2");
        public static readonly By ConsentDropdown = By.Id("select2-Dropdown2-arialabel-container");
        public static readonly By ConsentOptionNo = By.XPath("//select[@id='Dropdown2-arialabel']//option[@value='No']");
        public static readonly By StudentBirthdateInput = By.Id("SingleLine3-arialabel");
        public static readonly By GenderDropdown = By.Id("Dropdown3-arialabel");
        public static readonly By MiaPrepAccountDropdown = By.Id("Dropdown4-arialabel");
        public static readonly By MiaPrepAccountOptionNo = By.XPath("//select[@id='Dropdown4-arialabel']//option[@value='No']");
        public static readonly By StudentTypeDropdown = By.Id("Dropdown5-arialabel");
        public static readonly By StudentTypeOptionHomeschool = By.XPath("//select[@id='Dropdown5-arialabel']//option[@value='Homeschool']");
        public static readonly By AlgebraOption = By.XPath("//*[text() = \"Algebra 1\"]");
        public static readonly By GeometryOption = By.XPath("//*[text() = \"Geometry\"]");
        public static readonly By English1Option = By.XPath("//*[text() = \"English 1\"]");
        public static readonly By English2Option = By.XPath("//*[text() = \"English 2\"]");
        public static readonly By PhysicalScienceOption = By.XPath("//*[text() = \"Physical Science\"]");
        public static readonly By ChemistryOption = By.XPath("//*[text() = \"Chemistry\"]");
        public static readonly By PerformingArtsInput = By.Id("MultiLine-arialabel");
        public static readonly By LearningNeedsDropdown = By.Id("Dropdown13-arialabel");
        public static readonly By LearningNeedsOptionNo = By.XPath("//select[@id='Dropdown13-arialabel']//option[@value='No']");
    }





}
