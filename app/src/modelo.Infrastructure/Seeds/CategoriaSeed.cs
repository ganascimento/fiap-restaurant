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
                    Id = Guid.Parse("ada751db-8553-493f-b308-70bd29aed106"),
                    Nome = "Lanche",
                },
                new Categoria
                {
                    Id = Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72"),
                    Nome = "Acompanhamento",
                },
                new Categoria
                {
                    Id = Guid.Parse("5117243c-b007-49e8-9a30-842ec79248ae"),
                    Nome = "Bebida",
                },
                new Categoria
                {
                    Id = Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"),
                    Nome = "Sobremesa",
                }
            );
        }
    }
}