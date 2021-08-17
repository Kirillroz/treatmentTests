using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace treatmentTests1
{
    public class Tests
    {
        private IWebDriver driver;
        private readonly By _logininputButton = By.XPath("//input[@name='login']");
        private const string _login = "modara007@gmail.com";
        private const string _password = "123456Ab";
        private readonly By _PasswordinputButton = By.XPath("//input[@name='password']");
        private readonly By _LogIn = By.XPath("//button[@id='log_in']");
        private readonly By _Treatment = By.XPath("//a[@href='/demo/user/treatment/']");
        private readonly By _CreateTreatment = By.XPath("//button[@class='btn btn-primary lift header__create-vote-btn']");
        private readonly By _ContentTreatment = By.XPath("//textarea[@id='content']");
        private const string _UsingCont = "AutoTest";
        private readonly By _ClickCreateTrerment = By.XPath("//button[@class='btn btn-primary']");
        private readonly By _InputCalendar = By.XPath("//input[@id='calendar']");
        private readonly By _ChoiseDate = By.XPath("//span[@aria-label='Август 20, 2021']");
        private readonly By _AcceptDate = By.XPath("//div[@class='flatpickr-confirm lightTheme visible']");

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://test.rozentalgroup.ru/demo/authorization/index.php");
        
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(3000);
            var login = driver.FindElement(_logininputButton);
            login.SendKeys(_login);

            var password = driver.FindElement(_PasswordinputButton);
           password.SendKeys(_password);

            var LogIn = driver.FindElement(_LogIn);
            LogIn.Click();
            Thread.Sleep(15000);

            var Treatment = driver.FindElement(_Treatment);
            Treatment.Click();
            Thread.Sleep(3000);

            var CreateTreatment = driver.FindElement(_CreateTreatment);
            CreateTreatment.Click();
            Thread.Sleep(3000);

            var ContentTreatment = driver.FindElement(_ContentTreatment);
            ContentTreatment.SendKeys(_UsingCont);
            Thread.Sleep(3000);

            var InputCalendar = driver.FindElement(_InputCalendar);
            InputCalendar.Click();

            var ChoiseDate = driver.FindElement(_ChoiseDate);
            ChoiseDate.Click();

            var AcceptDate = driver.FindElement(_AcceptDate);
            AcceptDate.Click();

            var ClickCrateTreatment = driver.FindElement(_ClickCreateTrerment);
            ClickCrateTreatment.Click();
            Thread.Sleep(3000);

            
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            
        }
    
    }
}