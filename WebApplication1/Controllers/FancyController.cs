using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FooBusinessLayer;
using FooServiceLayer.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreFooAPI.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class FancyController : Controller
    {
        private readonly IFooBusiness _fooBusiness;
        
        public FancyController(IFooBusiness fooBusiness)
        {
            _fooBusiness = fooBusiness;
        }

        [Route("api/fancy")]
        public string Get()
        {
            return _fooBusiness.GetBusinessName();
        }

        [Route("api/fancy/environment")]
        public string Environment()
        {
            return _fooBusiness.GetEnvironmentName();
        }

    }
}