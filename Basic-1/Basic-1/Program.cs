using Microsoft.Extensions.DependencyInjection;

namespace Basic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConfigureServices();
            
        }

        private void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<Engine>();
            services.AddTransient<Car>();

            var provider = services.BuildServiceProvider();
            var Toyota = provider.GetService<Car>();
            Toyota.Start();
        }
    }
}
