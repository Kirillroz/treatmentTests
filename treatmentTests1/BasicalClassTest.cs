using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace treatmentTests1
{   
    public class BasicalClassTest
    {
        protected const string _UsingCont = "AutoTest";
        protected const string _login = "modara007@gmail.com";
        protected const string _password = "123456Ab";


        protected IWebDriver _webDriver;

    [OneTimeSetUp]

        protected void DoVeforeAllTests()
        {
            _webDriver = new ChromeDriver();
        }

    [OneTimeTearDown]
        protected void DoAfterAllTheTests()
        {

        }
     [TearDown]
        protected void DoAfterEach()
        {
            _webDriver.Quit();
        }
     [SetUp]
         protected void DoBeforeEach()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(TestsSettings.HostPrefix);
           
            
        }

    }

}
