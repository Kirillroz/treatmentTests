using System.Threading;
using OpenQA.Selenium;

namespace treatmentTests1.PageObject
{
    class AuthorizationPageObject
    {
        private IWebDriver _webdriver;

        private readonly By _LogIn = By.XPath("//button[@id='log_in']");
        private readonly By _logininputButton = By.XPath("//input[@name='login']");
        private readonly By _PasswordinputButton = By.XPath("//input[@name='password']");
        public AuthorizationPageObject(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }

        public MainMenuPageObject LogIN(string Login, string password)
        {
            Thread.Sleep(3000);
            _webdriver.FindElement(_logininputButton).SendKeys(Login);
            _webdriver.FindElement(_PasswordinputButton).SendKeys(password);
            _webdriver.FindElement(_LogIn).Click();


            return new MainMenuPageObject(_webdriver);
        }
    }
}
