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
