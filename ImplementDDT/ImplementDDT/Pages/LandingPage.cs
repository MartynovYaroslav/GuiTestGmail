using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDDT.Pages
{
    class LandingPage : BasePage
    {
        public LandingPage(IWebDriver driver) :
            base(driver)
        { }


        [FindsBy(How = How.CssSelector, Using = "div.gmail-nav__nav-links-wrap a.gmail-nav__nav-link__sign-in")]
        public IWebElement lnkEnter { get; set; }






        public void PressEnterLandingPage()
        {
            lnkEnter.Click();
        }

    }
}
