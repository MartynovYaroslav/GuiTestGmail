using OpenQA.Selenium;

namespace EAAutoFramework.Base
{
    public static class DriverContext
    {
        private static IWebDriver driver;


        public static IWebDriver Driver
        {
            get
            {
                return driver;
            }
            set
            {

                driver = value;
            }
        }
    }

}

