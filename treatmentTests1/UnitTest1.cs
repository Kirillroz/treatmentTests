using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using treatmentTests1.PageObject;
using System;
using System.Text;

namespace treatmentTests1
{
    [TestFixture]
    public class Tests : BasicalClassTest
    {   
         private readonly IWebDriver _webdriver;
      //  private readonly By _ListTreatment = By.XPath("//div[@class='content-list-wrapper']"); 
        private const string _asd = "��������� ������ ����������";
        private const string _asdd = "AutoTest";
        private const string _User = "��������� ������ ����������";
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
                 .ClickTreatment();

            
           
            Assert.Pass();
        }

        [TearDown]

        public void rezult()
        {
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
            try
                {
                    // string _listTreatment = _webdriver.FindElement(_ListTreatment).Text;
                    Assert.AreEqual(_asdd, _UsingCont);
                    string rezult = "�������� ���������  ���������";
                    rez.WriteLine(rezult);

                }

                catch
                {
                    // string _listTreatment = _webdriver.FindElement(_ListTreatment).Text;
                    string rezult = "�������� ��������� �� ���������";
                    rez.WriteLine(rezult);

                    cout++;
                }
                try
                {
                    Assert.AreEqual(_asd, _User);
                    string rezult = "��� ������������ ���������";
                    rez.WriteLine(rezult);

                }
                catch
                {
                    string rezult = "��� ������������ �� ���������";
                    rez.WriteLine(rezult);
                    cout++;
                }
                try
                {
                    Assert.AreEqual(_asd, _eMail);
                    string rezult = "�-mail ������������ ���������";
                    rez.WriteLine(rezult);


                }
                catch
                {
                    string rezult = "E-mail ������������ �� ���������";
                    rez.WriteLine(rezult);
                    cout++;
                }
                try
                {
                    Assert.AreEqual(_asd, _PhoneNumber);
                    string rezult = "�������  ������������ ���������";
                    rez.WriteLine(rezult);
                }
                catch
                {
                    string rezult = "������� ������������ �� ���������";
                    rez.WriteLine(rezult);
                    cout++;
                }
                if (cout > 0)
                {
                    rez.WriteLine("                                   ");
                    rez.WriteLine("������ ��������� �� ������ ��������,������:" + cout);
                }
                else
                    rez.WriteLine("������ ��������� ������ ��������,������ ���");
                rez.Close();
                
        }


    }
}