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
    public class ProductController : ApiController
    {
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpPost]
        public List<Product> GetAll()
        {
            //throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, "Hola"));
            return productService.GetAll();
        }
    }
}