using System.IO;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using treatmentTests1.PageObject;
namespace treatmentTests1
{
    [TestFixture]
    public class Tests : BasicalClassTest 
    {         
        private readonly By _ClickCreatedTreament = By.XPath("//p[contains(text(),'AutoTest')]");
        private readonly By _SearchAutoTest = By.XPath("//input[@class='module__search-line form-control form-control-flush']");
        private readonly By _ExpectedFIO = By.XPath("//span[@id='fio']");
        private readonly By _ExpectedEmail = By.XPath("//a[@id='email']");
        private readonly By _ExpectedPhone = By.XPath("//span[@id='phone']");
        private readonly By _ExpectedContent = By.XPath("//p[@id='content']");
        private const string _User = "Рожанский Кирилл Евгеньевич";
        private const string _eMail = "modara007@gmail.com";
        private const string _PhoneNumber = "9963838043";
        int cout = 0;

        

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
                 .CreateTreatments(_UsingCont)
                 .ClickTreatment()
                 .treatmentclick();
                 
                 
                 

             Assert.Pass();

        }

        [TearDown]

        public void rezult()
        { 
            //Получение проверяемых данных 
         var searchAutoTest = _webDriver.FindElement(_SearchAutoTest);
            searchAutoTest.SendKeys(_UsingCont);
            Thread.Sleep(8000);
         var ClickCreatedTreatment = _webDriver.FindElement(_ClickCreatedTreament);
            ClickCreatedTreatment.Click();
            Thread.Sleep(3000);
         var ExpectedFIO = _webDriver.FindElement(_ExpectedFIO);
            string ExpectedFioStr = ExpectedFIO.Text;
            Thread.Sleep(3000);
         var ExpectedEmail = _webDriver.FindElement(_ExpectedEmail);
            string ExpectedEmailStr = ExpectedEmail.Text;
            Thread.Sleep(3000);
         var ExpectedPhone = _webDriver.FindElement(_ExpectedPhone);
            string ExpectedPhoneStr = ExpectedPhone.Text;
            Thread.Sleep(3000);
         var ExpectedContent = _webDriver.FindElement(_ExpectedContent);
            string ExpectedContentStr = ExpectedContent.Text;
            Thread.Sleep(3000);

            //Подготовка к началу основной проверки 

            try
            {
           StreamWriter proverkaTXT = new StreamWriter(@"D:\rezult.txt");
           proverkaTXT.Close();
          }
          catch
          {
           FileStream filecreate = File.Create(@"D:\rezult.txt");               
          }
         StreamWriter rez = new StreamWriter(@"D:\rezult.txt");  
            //Начало основной проверки проверки
               try
                {
                    // string _listTreatment = _webdriver.FindElement(_ListTreatment).Text;
                    Assert.AreEqual(ExpectedContentStr, _UsingCont);
                    string rezult = "Название обращения  совпадает";
                    rez.WriteLine(rezult);

                }

                catch
                {
                    // string _listTreatment = _webdriver.FindElement(_ListTreatment).Text;
                    string rezult = "Название обращения не совпадает";
                    rez.WriteLine(rezult);

                    cout++;
                }
                try
                {
                    Assert.AreEqual(ExpectedFioStr, _User);
                    string rezult = "Фио пользователя совпадает";
                    rez.WriteLine(rezult);

                }
                catch
                {
                    string rezult = "Фио пользователя не совпадает";
                    rez.WriteLine(rezult);
                    cout++;
                }
                try
                {
                    Assert.AreEqual(ExpectedEmailStr, _eMail);
                    string rezult = "Е-mail пользователя совпадает";
                    rez.WriteLine(rezult);


                }
                catch
                {
                    string rezult = "E-mail пользователя не совпадает";
                    rez.WriteLine(rezult);
                    cout++;
                }
                try
                {
                    Assert.AreEqual(ExpectedPhoneStr, _PhoneNumber);
                    string rezult = "Телефон  пользователя совпадает";
                    rez.WriteLine(rezult);
                }
                catch
                {
                    string rezult = "Телефон пользователя не совпадает";
                    rez.WriteLine(rezult);
                    cout++;
                }
            //Конец проверок , обработка результатов 
            if (cout > 0)
            {
                rez.WriteLine("                                   ");
                rez.WriteLine("Раздел обращений не прошли проверку,ошибок:" + cout);
             }
            else
            {
                rez.WriteLine("Раздел обращений прошел проверку,ошибок нет");
            }
                rez.Close();
                
        }


    }
}