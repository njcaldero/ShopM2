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
    public class ProductControllerTest
    {

        Mock<IProductService> ps = new Mock<IProductService>();

        [TestMethod]
        public void GetAll()
        {
            ps.Setup(m => m.GetAll()).Returns(new List<Product>());

            // Disponer
            ProductController controller = new ProductController(ps.Object);

            // Actuar
            List<Product> result = controller.GetAll();

            // Declarar
            Assert.IsNotNull(result);

        }
    }
}
