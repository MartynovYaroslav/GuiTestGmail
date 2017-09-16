using EAAutoFramework.Base;
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
    public class UnitTest1 : InitializeTestMethod
    {

        //[SetUp]
        //public void BeaforTest()
        //{

        //    DriverContext.Driver = new ChromeDriver();
        //    string url = ConfigReaderHelper.UrlInitializeTest();

        //    DriverContext.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(15000));

        //    DriverContext.Driver.Navigate().GoToUrl(url);

        //    string currentWay = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


        //    string fileName = Path.Combine(currentWay, "Login.xlsx");
        //    ExcelHelpers.PopulateInCollection(fileName);
        //}


        [TestCase(0), Repeat(4)]
        public void AuthorisationUser(int numm)
        {
            numm++;

            new LandingPage().PressEnterLandingPage();

            new SignInGmail().LoginTxt(numm);

            new SignInPassword().PasswordTxt(numm);

        }

        //[TearDown]
        //public void AfterTest()
        //{
        //    DriverContext.Driver.Quit();
        //}
    }
}

