using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using modelo.Infrastructure.Configurations;
using modelo.Infrastructure.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace modelo.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public AppConfigurations AppConfigurations { get; set; }

        private readonly IWebHostEnvironment Environment;

        public void ConfigureServices(IServiceCollection services)
        {
            this.AppConfigurations = services.RegisterConfigurations(Configuration);

            RegisterServiceExtensions.RegisterService(services);

            services.RegisterAutoMapper();

            services.AddRazorPages();
            services.AddSwaggerGen();

            services.AddControllersWithViews(options =>
            {
                options.Filters.Add(new AllowAnonymousFilter());
            }).AddNewtonsoftJson(options => ConfigureJsonOptionsSerializer(options.SerializerSettings));

            services.RegisterDatabases(Configuration, Environment);

            services.AddMemoryCache();
            services.AddControllers();
        }

        private void ConfigureJsonOptionsSerializer(JsonSerializerSettings serializerSettings)
        {
            serializerSettings.ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };

            serializerSettings.Converters.Add(new StringEnumConverter());
            serializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            serializerSettings.NullValueHandling = NullValueHandling.Ignore;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
            });
            app.UseReDoc(c =>
            {
                c.DocumentTitle = "Documento REDOC API";
                c.SpecUrl = "/swagger/v1/swagger.json";
                c.RoutePrefix = "";
            });

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
