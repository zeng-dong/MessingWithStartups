using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MessingWithStartups
{
    public class Program
    {
        //public static void TemprarilyDisabledMain(string[] args)
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //webBuilder.UseStartup<Startup>();

                    // app can run by find startup with naming convention, for example, StartupStaging
                    // however, test project won't run
                    //webBuilder.UseStartup(typeof(Startup).Assembly.FullName);

                    // different Startup can be used, and test project will pick it up.
                    webBuilder.UseStartup<AzureServiceBus>();
                    //webBuilder.UseStartup<RabbitMq>();
                });
    }
}