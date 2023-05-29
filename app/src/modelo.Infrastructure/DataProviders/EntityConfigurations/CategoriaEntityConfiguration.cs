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
    public class CategoriaEntityConfiguration : IEntityTypeConfiguration<Categoria>

    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder
                .ToTable("tb_Categoria")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .HasColumnType("varchar(36)");

            builder.Property(p => p.Nome)
               .HasColumnName("Nome")
               .HasColumnType("varchar(200)");

           

        }
    }
}
