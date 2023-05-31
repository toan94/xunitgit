using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDataverse;

namespace MyTests
{
    internal class TestStartUp
    {
        public IServiceCollection ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IService1, Service1>();
            return serviceCollection;
        }
    }
}
