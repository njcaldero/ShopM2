using Newtonsoft.Json;
using ShopM2.Core.Dto;
using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ShopM2.WebApi.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrderController : ApiController
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService _orderService)
        {
            orderService = _orderService;
        }

        [HttpPost]
        public List<Order> GetAll()
        {
            return orderService.GetAll();
        }

        [HttpPost]
        public Order Create(Order order)
        {
            try
            {
               // string json = JsonConvert.SerializeObject(order);

                if (order != null)
                    return orderService.Create(order);
                else
                    throw new Exception("No se completo la operación"); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public Order GetById(Order order)
        {
            try
            {
                if (order.Id > 0)
                    return orderService.GetById(order.Id);
                else
                    throw new Exception("No se completo la operación"); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public bool PayOrder(Order order)
        {
            try
            {
                if (order.Id > 0)
                    return orderService.PayOrder(order.Id);
                else
                    throw new Exception("No se completo la operación"); ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }



    }
}