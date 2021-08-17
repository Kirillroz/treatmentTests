using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace treatmentTests1.PageObject
{
    class MainMenuPageObject
    {
        private IWebDriver _webDriver;

        public MainMenuPageObject()
        {
        }

        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        public AuthorizationPageObject SignIn ()
        {

            return new AuthorizationPageObject(_webDriver);
        }
        public TreatmentPageTest create ()
        {
            return new TreatmentPageTest(_webDriver);
        }
        public DesktopUserPageObject ClickTreatment()
        {
            return new DesktopUserPageObject(_webDriver);

        }
        
    }
}
