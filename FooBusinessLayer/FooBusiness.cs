using System;
using System.Collections.Generic;
using System.Text;
using FooServiceLayer.Contracts;
using FooServiceLayer.Services;
using Microsoft.Extensions.Configuration;

namespace FooBusinessLayer
{
    public class FooBusiness : IFooBusiness
    {
        private readonly IConfiguration _configuration;
        private readonly IFooService _fooService;
        public FooBusiness(IConfiguration configuration, IFooService fooService)
        {
            _configuration = configuration;
            _fooService = fooService;
        }


        public string GetBusinessName()
        {
            var serviceName = _fooService.GetServiceName();
            var businessName = this.GetType().Name;

            return $"This is {businessName} and I have {serviceName}";
        }

        public string GetEnvironmentName()
        {
           var envName = _configuration.GetSection("Environment").GetSection("Name").Value;

           return $"This is {envName} environment";
        }
    }
}
