using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
