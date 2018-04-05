using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FooBusinessLayer;
using FooServiceLayer.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreFooAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Fancy")]
    public class FancyController : Controller
    {
        private readonly IFooBusiness _fooBusiness;

        public FancyController(IFooBusiness fooBusiness)
        {
            _fooBusiness = fooBusiness;
        }

        [HttpGet]
        public string Get()
        {
            return _fooBusiness.GetBusinessName();
        }

    }
}