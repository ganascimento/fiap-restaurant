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
                new Cliente(nome: "Juca", cpf: "08154831473"),
                new Cliente(nome: "Blippi", cpf: "26521727788")
            );
        }
    }
}