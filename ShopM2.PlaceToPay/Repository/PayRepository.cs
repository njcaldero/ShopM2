using Newtonsoft.Json;
using PlacetoPay.Integrations.Library.CSharp.Contracts;
using PlacetoPay.Integrations.Library.CSharp.Entities;
using PlacetoPay.Integrations.Library.CSharp.Message;
using ShopM2.Core.Dto;
using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using ShopM2.PlaceToPay.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P2P = PlacetoPay.Integrations.Library.CSharp.PlacetoPay;

namespace ShopM2.PlaceToPay.Repository
{
    public class PayRepository : IPayRepository
    {
        private Gateway gateway;

        public PayRepository()
        {
            gateway = new P2P(Settings.Login, Settings.Trankey, new Uri(Settings.Url),
                Gateway.TP_REST);
        }

        /// <summary>
        /// start the payment process for the order
        /// </summary>
        /// <param name="order">InputPayDto order</param>
        /// <returns> OutPutPayDto</returns>
        OutPutPayDto IPayRepository.PayOrder(InputPayDto order)
        {
            Amount amount = new Amount(order.amount);
            Payment payment = new Payment(order.reference, Settings.PayDescription + order.reference, amount);

            //se dejan algunos algunos datos temporalmente, estos deben ir en config file
            RedirectRequest request = new RedirectRequest(payment, Settings.UrlBack + order.reference, Settings.IP, Settings.UserAgent, Settings.Expiration);
            RedirectResponse response = gateway.Request(request);

            if (response != null)
            {
                OutPutPayDto outPutPayDto = new OutPutPayDto()
                {
                    processUrl = response.ProcessUrl,
                    requestId = response.RequestId,
                    responseTrx = JsonConvert.SerializeObject(response),
                    status = response.Status.status
                };

                return outPutPayDto;
            }
            return null;
        }

        /// <summary>
        /// validation of the order payment against the gateway
        /// </summary>
        /// <param name="order"InputPayDto order</param>
        /// <returns>OutPutPayDto IPayRepository.CheckPayment</returns>
        OutPutPayDto IPayRepository.CheckPayment(InputPayDto inputPayDto)
        {
            RedirectInformation response = gateway.Query(inputPayDto.reference);
            if (response != null)
            {
                OutPutPayDto outPutPayDto = new OutPutPayDto()
                {
                    requestId = response.RequestId.ToString(),
                    responseTrx = JsonConvert.SerializeObject(response),
                    status = response.Status.status
                };

                return outPutPayDto;
            }
            return null;
        }



    }
}
