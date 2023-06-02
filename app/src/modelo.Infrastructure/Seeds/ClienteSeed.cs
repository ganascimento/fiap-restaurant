using System;
using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;

namespace modelo.Infrastructure.Seeds
{
    public static class ClienteSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = Guid.NewGuid(),
                    Nome = "Juca",
                    CPF = "54252344881"
                },
                new Cliente
                {
                    Id = Guid.NewGuid(),
                    Nome = "Blippi",
                    CPF = "34450347889"
                }
            );
        }
    }
}