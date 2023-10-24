using System;
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
                var connectionString = configurations.GetConnectionString("ConnectionString");

                services.AddDbContextPool<DBContext>(options =>
                    options.UseMysqlServer(connectionString.ToString())
                );
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
