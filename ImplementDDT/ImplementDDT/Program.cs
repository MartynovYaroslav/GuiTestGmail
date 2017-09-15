using ImplementDDT.Helpers;
using ImplementDDT.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDDT
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }


    [TestFixture]
    public class UnitTest1
    {

        private IWebDriver _driver;


        [SetUp]
        public void BeaforTest()
        {

            _driver = new ChromeDriver();
            string url = "https://www.google.com/intl/ru/gmail/about/";
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(5000));
            _driver.Navigate().GoToUrl(url);

            //string fileName = Directory.GetCurrentDirectory();

            string put = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)/*+String.Format("\\Login.xlsx")*/;


            string fileName = Path.Combine(put, "Login.xlsx");
            ExcelHelpers.PopulateInCollection(fileName);



            //string path = Directory.GetCurrentDirectory();
            //string fileName = String.Format("Login.xlsx");
            //path = Path.Combine(path, fileName);


        }



        [TestCase(1), Repeat(2)]
        //[Retry(Times = 3, RequiredPassCount = 2)]
        public void AuthorisationByUser(int numm)
        {


            LandingPage landingPage = new LandingPage(_driver);
            SignInGmail signInGmail = new SignInGmail(_driver);
            SignInPassword signInPassword = new SignInPassword(_driver);


            landingPage.PressEnterLandingPage();

            signInGmail.LoginTxt(numm);

            signInPassword.PasswordTxt(numm);

        }

        [TearDown]
        public void AfterTest()
        {
            _driver.Quit();
        }
    }
}

