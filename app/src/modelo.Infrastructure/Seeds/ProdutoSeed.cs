using System;
using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.Seeds
{
    public static class ProdutoSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData(

            #region Lanche
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Hamburguer",
                    Valor = 8.00m,
                    CategoriaId = Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Cheeseburger",
                    Valor = 9.00m,
                    CategoriaId = Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "X Salada",
                    Valor = 10.00m,
                    CategoriaId = Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "X Bacon",
                    Valor = 11.00m,
                    CategoriaId = Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "X Tudo",
                    Valor = 12.00m,
                    CategoriaId = Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")
                },
            #endregion

            #region Acompanhamento
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Batata Frita Pequena",
                    Valor = 5.00m,
                    CategoriaId = Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Batata Frita Media",
                    Valor = 7.00m,
                    CategoriaId = Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Batata Frita Grande",
                    Valor = 9.00m,
                    CategoriaId = Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Chicken Nuggets 4 unidades",
                    Valor = 6.00m,
                    CategoriaId = Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Chicken Nuggets 8 unidades",
                    Valor = 12.00m,
                    CategoriaId = Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Chicken Nuggets 12 unidades",
                    Valor = 16.00m,
                    CategoriaId = Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")
                },
            #endregion

            #region Bebida
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Coca Cola Pequena",
                    Valor = 6.00m,
                    CategoriaId = Guid.Parse("5117243c-b007-49e8-9a30-842ec79248ae")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Coca Cola Media",
                    Valor = 8.00m,
                    CategoriaId = Guid.Parse("5117243c-b007-49e8-9a30-842ec79248ae")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Coca Cola Grande",
                    Valor = 10.00m,
                    CategoriaId = Guid.Parse("5117243c-b007-49e8-9a30-842ec79248ae")
                },
                
                
            #endregion

            #region Sobremesa
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Sorverte de Baunilha",
                    Valor = 3.00m,
                    CategoriaId = Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Sorverte de Chocolate",
                    Valor = 3.00m,
                    CategoriaId = Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Sorverte de Misto",
                    Valor = 3.00m,
                    CategoriaId = Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Sundae de Baunilha",
                    Valor = 6.00m,
                    CategoriaId = Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Sundae de Chocolate",
                    Valor = 6.00m,
                    CategoriaId = Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")
                },
                new Produto
                {
                    Id = Guid.NewGuid(),
                    Nome = "Sundae Misto",
                    Valor = 6.00m,
                    CategoriaId = Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")
                }
                #endregion
            );
        }
    }
}