using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniupdate
{
   public class AppConfig
    {
        public static string DailyTranConnection
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ServiceString"].ConnectionString;
            }
        }
    }
}
