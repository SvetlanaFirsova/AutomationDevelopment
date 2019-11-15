using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace AutomationUnitTestProject
{
    [TestClass]
    class TestSighInPage
    {
       

        public IWebDriver Driver { get; set; }


        public TestSighInPage()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();

        }

        [Test]
  
 
        public void FillinfTheField()
        {
            Thread.Sleep(1000);
            Actions.FillEmailField(Config.Credentials.Valid.Email, Driver);
            Thread.Sleep(1000);

            NUnit.Framework.Assert.IsNotNull(Config.Credentials.Valid.Email, "example@example.com");

            Thread.Sleep(1000);
            Actions.PressNextButton(Driver);
            //Explicit wait
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.ClassName("password")));
            NUnit.Framework.Assert.IsTrue(Actions.IsPasswordFieldVisible(Driver));
            Thread.Sleep(1000);
            Actions.PasswordField(Config.Credentials.Valid.Password, Driver);
            Thread.Sleep(2000);

            NUnit.Framework.Assert.IsNotEmpty(Actions.GetPasswordField(Driver));

        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }

    }
}
