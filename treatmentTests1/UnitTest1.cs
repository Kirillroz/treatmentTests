using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using treatmentTests1.PageObject;

namespace treatmentTests1
{
    [TestFixture]
    public class Tests : BasicalClassTest
    {
       
        

        [Test]
        public void Test1()
        {
            var mainMenu = new MainMenuPageObject(_webDriver);
            mainMenu
                 .SignIn()
                 .LogIN(_login, _password)
                 .ClickTreatment()
                 .treatmentclick()
                 .create()
                 .CreateTreatments(_UsingCont);

            Assert.Pass();
        }

        [TearDown]

        public void rezult()
        {
            
            
         try
            {
                Assert.AreEqual(_asd, _login);
                string Login = "Логин  совпадает";
                StreamWriter rez = new StreamWriter(@"C:\Users\Кирилл\Desktop\rezult.txt");
                rez.WriteLine(Login);
                rez.Close();
             }
                       
         catch
            { 
                string Login = "Логин не совпадает";
                StreamWriter rez = new StreamWriter(@"C:\Users\Кирилл\Desktop\rezult.txt");
                rez.WriteLine(Login);
                rez.Close();

            }
            
        }


    }
}