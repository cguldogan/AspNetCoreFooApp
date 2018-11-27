using FooBusinessLayer;
using Microsoft.AspNetCore.Mvc;

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