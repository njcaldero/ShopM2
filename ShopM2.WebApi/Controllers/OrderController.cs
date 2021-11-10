using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopM2.WebApi.Controllers
{
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

      
    }
}