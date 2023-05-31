using Microsoft.Extensions.DependencyInjection;
using TestDataverse;

namespace MyTests
{
    public class UnitTest1
    {
        private readonly IService1 _sv1;
        public UnitTest1()
        {
            IServiceCollection sv = new ServiceCollection();
            var startUp = new TestStartUp();
            sv = startUp.ConfigureServices(sv);
            var serviceProvider = sv.BuildServiceProvider();
            _sv1 = serviceProvider.GetRequiredService<IService1>();

        }

        [Fact]
        public void Test1()
        {
            var b = _sv1.getBool();
            Assert.Equal(b, true);
        }

    }
}