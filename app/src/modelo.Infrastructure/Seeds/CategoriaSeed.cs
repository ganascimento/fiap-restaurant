using System;
using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.Seeds
{
    public static class CategoriaSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria
                {
                    Id = Guid.NewGuid(),
                    Nome = "Lanche",
                },
                new Categoria
                {
                    Id = Guid.NewGuid(),
                    Nome = "Acompanhamento",
                },
                new Categoria
                {
                    Id = Guid.NewGuid(),
                    Nome = "Bebida",
                },
                new Categoria
                {
                    Id = Guid.NewGuid(),
                    Nome = "Sobremesa",
                }
            );
        }
    }
}