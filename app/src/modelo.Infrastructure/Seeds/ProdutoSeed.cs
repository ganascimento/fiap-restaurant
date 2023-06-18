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
                new Produto("Hamburguer", 8.00m, Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")),
                new Produto("Cheeseburger", 9.00m, Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")),
                new Produto("X Salada", 10.00m, Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")),
                new Produto("X Bacon", 11.00m, Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")),
                new Produto("X Tudo", 12.00m, Guid.Parse("ada751db-8553-493f-b308-70bd29aed106")),
            #endregion

            #region Acompanhamento
                new Produto("Batata Frita Pequena", 5.00m, Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")),
                new Produto("Batata Frita Media", 7.00m, Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")),
                new Produto("Batata Frita Grande", 9.00m, Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")),
                new Produto("Chicken Nuggets 4 unidades", 6.00m, Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")),
                new Produto("Chicken Nuggets 8 unidades", 12.00m, Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")),
                new Produto("Chicken Nuggets 12 unidades", 16.00m, Guid.Parse("cf412102-35da-43d8-9c3c-b72546104c72")),
            #endregion

            #region Bebida
                new Produto("Coca Cola Pequena", 6.00m, Guid.Parse("5117243c-b007-49e8-9a30-842ec79248ae")),
                new Produto("Coca Cola Media", 8.00m, Guid.Parse("5117243c-b007-49e8-9a30-842ec79248ae")),
                new Produto("Coca Cola Grande", 10.00m, Guid.Parse("5117243c-b007-49e8-9a30-842ec79248ae")),


            #endregion

            #region Sobremesa
                new Produto("Sorverte de Baunilha", 3.00m, Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")),
                new Produto("Sorverte de Chocolate", 3.00m, Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")),
                new Produto("Sorverte de Misto", 3.00m, Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")),
                new Produto("Sundae de Baunilha", 6.00m, Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")),
                new Produto("Sundae de Chocolate", 6.00m, Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b")),
                new Produto("Sundae Misto", 6.00m, Guid.Parse("32f0c5f0-d9ba-40e2-8d7a-57eed4727e2b"))
            #endregion
            );
        }
    }
}