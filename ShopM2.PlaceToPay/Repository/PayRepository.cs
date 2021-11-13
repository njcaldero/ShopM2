using PlacetoPay.Integrations.Library.CSharp.Contracts;
using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2P = PlacetoPay.Integrations.Library.CSharp.PlacetoPay;

namespace ShopM2.PlaceToPay.Repository
{
    public class PayRepository 
    {
        private Gateway gateway;

        public PayRepository()
        {
            gateway = new P2P(ConfigurationManager.AppSettings.Get("Login"),
                ConfigurationManager.AppSettings.Get("Trankey"),
                new Uri(ConfigurationManager.AppSettings.Get("Url")), Gateway.TP_REST);
        }

        bool PayProcess(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
