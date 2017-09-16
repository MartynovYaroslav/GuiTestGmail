using ImplementDDT.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ImplementDDT.Pages
{
    class SignInGmail : BasePage
    {

        [FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement EnterEmailOrPhone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.RveJvd")]
        public IWebElement btnNext { get; set; }


        public void PassLogin(int rowRead)
        {
            EnterEmailOrPhone.SendKeys(ExcelHelpers.ReadData(rowRead, "UserName"));
            btnNext.Click();
        }
    }
}
