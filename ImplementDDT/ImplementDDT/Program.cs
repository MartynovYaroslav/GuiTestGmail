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
            string url = ConfigReaderHelper.InitializeTest();

            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(15000));

            _driver.Navigate().GoToUrl(url);

            string currentWay = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            string fileName = Path.Combine(currentWay, "Login.xlsx");
            ExcelHelpers.PopulateInCollection(fileName);


        }



        [TestCase(1), Repeat(4)]
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

