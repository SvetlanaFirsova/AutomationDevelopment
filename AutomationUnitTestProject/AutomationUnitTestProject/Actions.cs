using AutomationUnitTestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace AutomationUnitTestProject
{
    class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.BaseURL);
            //implicit wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
           
            return driver;
        }

      
        public static void FillEmailField(string email, IWebDriver driver)
        {
            SignInPage SignInGoogle = new SignInPage(driver);

            SignInGoogle.EmailOrPhone.Clear();
            SignInGoogle.EmailOrPhone.SendKeys(email);

        }

   
        public static void PressNextButton(IWebDriver driver)
        {
            SignInPage Button = new SignInPage(driver);
            Button.NextButton.Click();
        }

        
        public static void PasswordField(string password, IWebDriver driver)
        {
            SignInPage Field = new SignInPage(driver);
            Field.EnterYourPassword.Clear();
            Field.EnterYourPassword.SendKeys(password);
        }


        public static bool IsPasswordFieldVisible(IWebDriver driver)
        {
            SignInPage SignInPage = new SignInPage(driver);
            bool FieldPasswordVisible = SignInPage.EnterYourPassword.Displayed;
           

            return FieldPasswordVisible;
        }
        public static string GetPasswordField(IWebDriver driver)
        {
            SignInPage SignInPage = new SignInPage(driver);
            string GetFieldPasswordVisible = SignInPage.EnterYourPassword.GetAttribute("value");
           

            return GetFieldPasswordVisible;
        }

    }
}
