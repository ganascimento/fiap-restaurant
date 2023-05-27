using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.Extensions
{
    public static class DbContextOptionsExtensions
    {
        public static DbContextOptionsBuilder UseMysqlServer(this DbContextOptionsBuilder optionsBuilder, string connectionString, Action<MySqlDbContextOptionsBuilder> mySqlOptionsAction = null)
        {
            var serverVersion = ServerVersion.AutoDetect(connectionString);

            return optionsBuilder
                .UseMySql(connectionString, serverVersion, mySqlOptionsAction)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}
