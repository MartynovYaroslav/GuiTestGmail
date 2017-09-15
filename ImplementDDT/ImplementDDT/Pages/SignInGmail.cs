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
    class SignInGmail : BasePage
    {

        [FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement EnterEmailOrPhone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.RveJvd")]
        public IWebElement btnNext { get; set; }


        public void LoginTxt(int rowNamber)
        {
            EnterEmailOrPhone.SendKeys(ExcelHelpers.ReadData(rowNamber, "UserName"));
            btnNext.Click();
        }
    }
}
