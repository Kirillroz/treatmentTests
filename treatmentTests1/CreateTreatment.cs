using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using treatmentTests1.PageObject;


namespace treatmentTests1
{
    class CreateTreatment
    {
        private readonly IWebDriver _webdriver;
        private static readonly string DAte = DateTime.Now.ToString("MMMM dd, yyyy");
        static private string _datenow = "//span[@aria-label='" + DAte + "']";       
        private readonly By _CreateTreatment = By.XPath("//button[@class='btn btn-primary lift header__create-vote-btn']");
        private readonly By _ContentTreatment = By.XPath("//textarea[@id='content']");
        private readonly By _ClickCreateTrerment = By.XPath("//button[@class='btn btn-primary']");
        private readonly By _InputCalendar = By.XPath("//input[@id='calendar']");       
        private readonly By _AcceptDate = By.XPath("//div[@class='flatpickr-confirm  lightTheme']");
        
        public CreateTreatment (IWebDriver webdriver)
        {
            _webdriver = webdriver;
            
        } 
        public MainMenuPageObject CreateTreatments (string _UsingCont)
        {          
            var _createTreatment = _webdriver.FindElement(_CreateTreatment);
            _createTreatment.Click();  
            
            Thread.Sleep(3000);
            var ContentTreatment = _webdriver.FindElement(_ContentTreatment);
            ContentTreatment.SendKeys(_UsingCont);
            Thread.Sleep(3000);

            var InputCalendar = _webdriver.FindElement(_InputCalendar);
            InputCalendar.Click();
            _datenow = _datenow.Replace("августа", "Август").Replace("сентября", "Сентябрь").Replace("октября", "Октябрь").Replace("ноября", "Ноябрь").Replace("декабря", "Декабрь").Replace("января", "Январь").Replace("февраля", "Февраль").Replace("марта", "Март").Replace("апреля", "Апрель").Replace("мая", "Май").Replace("июня", "Июнь").Replace("июля", "Июль");
            By _ChoiseDate = By.XPath(_datenow);
            Thread.Sleep(3000);
            var ChoiseDate = _webdriver.FindElement(_ChoiseDate);
            ChoiseDate.Click();
            Thread.Sleep(3000);
            var AcceptDate = _webdriver.FindElement(_AcceptDate);
            AcceptDate.Click();
            Thread.Sleep(3000);

            var ClickCrateTreatment = _webdriver.FindElement(_ClickCreateTrerment);
            ClickCrateTreatment.Click();
            Thread.Sleep(3000);

            return new MainMenuPageObject (_webdriver); 
        }

    }
}
