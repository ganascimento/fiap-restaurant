using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using modelo.Infrastructure.DataProviders;
using Microsoft.EntityFrameworkCore;

namespace modelo.Infrastructure.Extensions
{
    public static class DatabaseServiceExtensions
    {
        public static void RegisterDatabases(this IServiceCollection services, IConfiguration configurations, IWebHostEnvironment environment)
        {
            try
            {
                if (environment.IsTesting())
                {
                    return;
                }

                var connectionString = environment.IsDevelopment() ? GetLocalConnectionStringDocker(configurations) : GetConnectionString(configurations);

                services.AddDbContextPool<DBContext>(options => options.UseMysqlServer(connectionString.ToString()));
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static object GetConnectionString(IConfiguration configurations)
        {
            // TODO : criar a conection string de hom e prod aqui
            throw new NotImplementedException();
        }

        private static object GetLocalConnectionStringDocker(IConfiguration configurations) => configurations.GetConnectionString("Default");
        
    }
}
