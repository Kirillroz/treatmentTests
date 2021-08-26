using OpenQA.Selenium;

namespace treatmentTests1.PageObject
{
    class MainMenuPageObject
    {
        private IWebDriver _webdriver;

        public MainMenuPageObject()
        {
        }

        public MainMenuPageObject(IWebDriver webDriver)
        {
            _webdriver = webDriver;
        }
        public AuthorizationPageObject SignIn()
        {

            return new AuthorizationPageObject(_webdriver);
        }
        public CreateTreatment create()
        {
            return new CreateTreatment (_webdriver);
        }
        public DesktopUserPageObject ClickTreatment()
        {
            return new DesktopUserPageObject(_webdriver);

        }

    }
}
