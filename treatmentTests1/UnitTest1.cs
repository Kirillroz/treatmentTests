using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using treatmentTests1.PageObject;

namespace treatmentTests1
{
    public class Tests
    {
        private IWebDriver _webdriver;
        private const string _login = "modara007@gmail.com";
        private const string _password = "123456Ab";
        private const string _UsingCont = "AutoTest";
        
        [SetUp]
        public void Setup()
        {
            _webdriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _webdriver.Navigate().GoToUrl("https://test.rozentalgroup.ru/demo/authorization/index.php");
        
        }

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(_webdriver);
            mainMenu
                 .SignIn()
                 .LogIN(_login, _password)
                 .ClickTreatment()
                 .treatmentclick()
                 .create()
                 .Treatmentcreate(_UsingCont);                                                 
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            //_webdriver.Quit();
        }
    
    }
}