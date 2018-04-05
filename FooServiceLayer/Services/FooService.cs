using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using FooServiceLayer.Contracts;

namespace FooServiceLayer.Services
{
    public class FooService : IFooService
    {
        public string GetServiceName()
        {
            return this.GetType().Name;
        }
    }
}
