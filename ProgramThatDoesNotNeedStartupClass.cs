using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace MessingWithStartups
{
    public class ProgramThatDoesNotNeedStartupClass
    {
        public static void Change_To_Main_When_You_Want_To_Try_This(string[] args)
        //public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // instead of using Startup
                    webBuilder
                        .ConfigureServices(ConfigureServices)
                        .Configure(Configure);
                });

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDeveloper, RabbitMQDeveloper>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Rabbit NO Startup", Version = "v1" });
            });
        }

        public static void Configure(IApplicationBuilder app)
        {
            // get this manually
            IWebHostEnvironment env = app.ApplicationServices.GetService<IWebHostEnvironment>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Developing with Rabbit MQ v1" + " : NO Startup"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}