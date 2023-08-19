using System;
using modelo.Domain.Entities.Base;
using modelo.Domain.ValueObjects;

namespace modelo.Domain.Entities
{
    public class Cliente : Entity<Guid>
    {
        private Cliente() { }

        public Cliente(string nome, string cpf, Guid? id = null)
        {
            Id = id == null ? Guid.NewGuid() : (Guid)id;
            Nome = nome;
            Cpf = cpf;
            ValidateEntity();
        }

        public string Nome { get; private set; }
        public Cpf Cpf { get; private set; }

        public void CheckClienteAlreadyExists(Cliente cliente)
        {
            if (cliente == null) return;
            AssertionConcern.AssertArgumentNotEquals(cliente.Cpf, Cpf, "Já existe um cliente com este CPF cadastrado!");
        }

        private void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotNull(Id, "O Id não pode estar vazio!");
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
        }
    }
}
