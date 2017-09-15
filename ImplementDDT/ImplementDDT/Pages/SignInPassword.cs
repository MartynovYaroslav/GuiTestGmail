using ImplementDDT.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDDT.Pages
{
    class SignInPassword : BasePage
    {

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtEmailPhone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#passwordNext>content span")]
        public IWebElement btnNext { get; set; }


        public void PasswordTxt(int rowNumber)
        {
            txtEmailPhone.SendKeys(ExcelHelpers.ReadData(rowNumber, "Password"));
            btnNext.Click();
        }
    }
}
