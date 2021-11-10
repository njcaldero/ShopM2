using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopM2.Template;
using ShopM2.Template.Controllers;
using System.Web.Mvc;

namespace ShopM2.Template.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Disponer
            HomeController controller = new HomeController();

            // Actuar
            ViewResult result = controller.Index() as ViewResult;

            // Declarar
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
