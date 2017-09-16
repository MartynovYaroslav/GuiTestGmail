using System.Configuration;

namespace ImplementDDT.Helpers
{
    class ConfigReaderHelper
    {
        public static string UrlInitializeTest()
        {

          return  ConfigurationManager.AppSettings["Gmail"].ToString();

        }
    }
}
