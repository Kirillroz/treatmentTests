using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

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
            Thread.Sleep(8000);

            var Treatment = _webdriver.FindElement(_Treatment);
            Treatment.Click();
            Thread.Sleep(3000);


            return new MainMenuPageObject(_webdriver);
        }


    }
}
