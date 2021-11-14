using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.PlaceToPay.Util
{
 public static   class Settings
    {
        public static string Login = ConfigurationManager.AppSettings.Get("Login");
        public static string Trankey = ConfigurationManager.AppSettings.Get("Trankey");
        public static string Url = ConfigurationManager.AppSettings.Get("Url");
        public static string PayDescription = ConfigurationManager.AppSettings.Get("PayDescription");
        public static string UrlBack = ConfigurationManager.AppSettings.Get("UrlBack");
        public static string Expiration = ConfigurationManager.AppSettings.Get("Expiration");
        public static string IP = ConfigurationManager.AppSettings.Get("IP");
        public static string UserAgent = ConfigurationManager.AppSettings.Get("UserAgent");
    }
}
