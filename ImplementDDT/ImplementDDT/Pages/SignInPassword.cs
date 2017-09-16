using ImplementDDT.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ImplementDDT.Pages
{
    class SignInPassword : BasePage
    {

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtEmailPhone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#passwordNext>content span")]
        public IWebElement btnNext { get; set; }


        public void PassPassword(int rowRead)
        {
            txtEmailPhone.SendKeys(ExcelHelpers.ReadData(rowRead, "Password"));
            btnNext.Click();
        }
    }
}
