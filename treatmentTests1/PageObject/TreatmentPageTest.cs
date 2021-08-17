using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace treatmentTests1.PageObject
{
    class TreatmentPageTest
    {
        private IWebDriver _webdriver;
        private readonly By _CreateTreatment = By.XPath("//button[@class='btn btn-primary lift header__create-vote-btn']");
        private readonly By _ContentTreatment = By.XPath("//textarea[@id='content']");
        
        private readonly By _ClickCreateTrerment = By.XPath("//button[@class='btn btn-primary']");
        private readonly By _InputCalendar = By.XPath("//input[@id='calendar']");
        private readonly By _ChoiseDate = By.XPath("//span[@aria-label='Август 20, 2021']");
        private readonly By _AcceptDate = By.XPath("//div[@class='flatpickr-confirm lightTheme visible']");

        public TreatmentPageTest(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }
       
        public MainMenuPageObject Treatmentcreate (string _UsingCont)
        {
            var CreateTreatment = _webdriver.FindElement(_CreateTreatment);
            CreateTreatment.Click();
            Thread.Sleep(3000);

            var ContentTreatment = _webdriver.FindElement(_ContentTreatment);
            ContentTreatment.SendKeys(_UsingCont);
            Thread.Sleep(3000);

            var InputCalendar = _webdriver.FindElement(_InputCalendar);
            InputCalendar.Click();

            var ChoiseDate = _webdriver.FindElement(_ChoiseDate);
            ChoiseDate.Click();

            var AcceptDate = _webdriver.FindElement(_AcceptDate);
            AcceptDate.Click();

            var ClickCrateTreatment = _webdriver.FindElement(_ClickCreateTrerment);
            ClickCrateTreatment.Click();
            Thread.Sleep(3000);
            return new MainMenuPageObject(_webdriver);
        }
    
    }


}
