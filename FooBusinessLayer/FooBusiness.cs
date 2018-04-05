using System;
using System.Collections.Generic;
using System.Text;
using FooServiceLayer.Contracts;
using FooServiceLayer.Services;

namespace FooBusinessLayer
{
    public class FooBusiness : IFooBusiness
    {
        private readonly IFooService _fooService;
        public FooBusiness(IFooService fooService)
        {
            _fooService = fooService;
        }


        public string GetBusinessName()
        {
            var serviceName = _fooService.GetServiceName();
            var businessName = this.GetType().Name;

            return $"This is {businessName} and I have {serviceName}";
        }
    }
}
