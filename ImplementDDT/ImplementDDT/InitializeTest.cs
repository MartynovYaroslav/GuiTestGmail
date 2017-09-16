using EAAutoFramework.Base;
using ImplementDDT.Helpers;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace ImplementDDT
{
    public class InitializeTest
    {
        [SetUp]
        public void BeaforTest()
        {

            DriverContext.Driver = new ChromeDriver();
            string url = ConfigReaderHelper.UrlInitializeTest();

            DriverContext.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(15000));

            DriverContext.Driver.Navigate().GoToUrl(url);

            string currentWay = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


            string fileName = Path.Combine(currentWay, "Login.xlsx");
            ExcelHelpers.PopulateInCollection(fileName);
        }


        [TearDown]
        public void AfterTest()
        {
            DriverContext.Driver.Quit();
        }

    }
}
