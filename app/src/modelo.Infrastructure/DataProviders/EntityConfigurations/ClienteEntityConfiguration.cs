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
    public class ClienteEntityConfiguration : IEntityTypeConfiguration<Cliente>

    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder
                .ToTable("tb_Cliente")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .HasColumnType("varchar(36)");

            builder.Property(p => p.Nome)
               .HasColumnName("Nome")
               .HasColumnType("varchar(200)");

            builder.Property(p => p.CPF)
               .HasColumnName("CPF")
               .HasColumnType("varchar(11)");
           

        }
    }
}
