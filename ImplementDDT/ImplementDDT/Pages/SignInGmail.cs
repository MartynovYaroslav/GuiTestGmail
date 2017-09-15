using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDDT.Pages
{
    class SignInGmail : BasePage
    {
        public SignInGmail(IWebDriver driver) :
            base(driver)
        { }


        [FindsBy(How = How.Id, Using = "identifierId")]
        public IWebElement txtEmailPhone { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span.RveJvd")]
        public IWebElement btnNext { get; set; }


        public void LoginTxt(int rowNamber)
        {
            txtEmailPhone.SendKeys(ExcelHelpers.ReadData(rowNamber, "UserName"));
            btnNext.Click();
        }
    }
