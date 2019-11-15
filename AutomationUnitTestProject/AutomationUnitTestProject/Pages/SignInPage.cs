

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationUnitTestProject.Pages
{
    public class SignInPage
    {
        
        public SignInPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement EmailOrPhone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#identifierNext > span > span")]
        public IWebElement NextButton { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement EnterYourPassword { get; set; }

    }
}
