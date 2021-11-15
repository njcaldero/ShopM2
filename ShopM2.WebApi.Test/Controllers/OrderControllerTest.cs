using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using ShopM2.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace ShopM2.WebApi.Test.Controllers
{

    [TestClass]
    public class OrderControllerTest
    {
        Mock<IOrderService> os = new Mock<IOrderService>();

        [TestMethod]
        public void GetAll()
        {
            os.Setup(m => m.GetAll()).Returns(new List<Order>());

            // Disponer
            OrderController controller = new OrderController(os.Object);

            // Actuar
            List<Order> result = controller.GetAll();

            // Declarar
            Assert.IsNotNull(result);

        }
    }


}
