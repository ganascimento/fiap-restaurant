using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.DataProviders.EntityConfigurations
{
    public class WeatherForecastEntityConfiguration : IEntityTypeConfiguration<WeatherForecast>

    {
        public void Configure(EntityTypeBuilder<WeatherForecast> builder)
        {
            builder
                .ToTable("tb_WeatherForecast")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .HasColumnType("varchar(36)");

            builder.Property(p => p.TemperatureC)
               .HasColumnName("TemperatureC")
               .HasColumnType("integer");

            builder.Property(p => p.TemperatureF)
               .HasColumnName("TemperatureF")
               .HasColumnType("integer");


            builder.Property(p => p.Date)
               .HasColumnName("Date")
               .HasColumnType("datetime");

            builder.Property(p => p.Summary)
               .HasColumnName("Summary")
               .HasColumnType("varchar(36)");

        }
    }
}
