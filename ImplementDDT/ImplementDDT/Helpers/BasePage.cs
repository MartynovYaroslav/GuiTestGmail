using EAAutoFramework.Base;
using OpenQA.Selenium.Support.PageObjects;

namespace ImplementDDT.Helpers
{
    public abstract class BasePage
    {
        
        public BasePage()
        {

            PageFactory.InitElements(DriverContext.Driver, this);

        }
    }
}
