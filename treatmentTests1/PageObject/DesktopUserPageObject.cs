using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace treatmentTests1.PageObject
{
    class DesktopUserPageObject
    {
        private IWebDriver _webdriver;
        private readonly By _Treatment = By.XPath("//a[@href='/demo/user/treatment/']");

        public DesktopUserPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        public MainMenuPageObject treatmentclick ()
        {
            new WebDriverWait(_webdriver, TimeSpan.FromSeconds(15000)).Until(ExpectedConditions.ElementExists(By.XPath("//a[@href='/demo/user/treatment/']")));

            var Treatment = _webdriver.FindElement(_Treatment);
            Treatment.Click();           

            return new MainMenuPageObject(_webdriver);
        }


    }
}
