using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;
using modelo.Infrastructure.DataProviders.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.DataProviders
{
    public class DBContext : DbContext
    {
        public DbSet <WeatherForecast> WeatherForecast { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Categoria> Categoria { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new WeatherForecastEntityConfiguration());

            modelBuilder.ApplyConfiguration(new ClienteEntityConfiguration());

            modelBuilder.ApplyConfiguration(new CategoriaEntityConfiguration());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DbContext).Assembly);
            
        }
    } 
    

}
