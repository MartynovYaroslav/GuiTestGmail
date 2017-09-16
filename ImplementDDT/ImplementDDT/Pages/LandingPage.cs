using ImplementDDT.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ImplementDDT.Pages
{
    class LandingPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "div.gmail-nav__nav-links-wrap a.gmail-nav__nav-link__sign-in")]
        public IWebElement lnkEnter { get; set; }


        public void EnterLandingPage()
        {
            lnkEnter.Click();
        }

    }
}
