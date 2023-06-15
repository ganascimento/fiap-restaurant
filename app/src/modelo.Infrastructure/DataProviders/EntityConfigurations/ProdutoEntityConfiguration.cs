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
    public class ProdutoEntityConfiguration : IEntityTypeConfiguration<Produto>

    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder
                .ToTable("tb_Produto")
                .HasKey(p => new { p.Id });

            builder.Property(p => p.Id)
                .HasColumnName("id")
                .HasColumnType("varchar(36)");

            builder.Property(p => p.Nome)
               .HasColumnName("Nome")
               .HasColumnType("varchar(200)");

            builder.Property(p => p.Valor)
              .HasColumnName("Valor")
              .HasColumnType("decimal(19,2)");


            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Produtos);

        }
    }
}
