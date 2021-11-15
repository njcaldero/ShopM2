using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopM2.WebApi.Controllers
{
    public class HealthController : ApiController
    {
        [HttpGet]
        public string liveness()
        {
            return "Running...";
        }
    }
}