using System;
using modelo.Domain.Entities.Base;

namespace modelo.Domain.Entities
{
    public class Cliente : Entity<Guid>
    {
        public Cliente(string nome, string cpf, Guid? id = null)
        {
            Id = id == null ? Guid.NewGuid() : (Guid)id;
            Nome = nome;
            Cpf = CpfValidation.ClearCpf(cpf);
            ValidateEntity();
        }

        /// <summary>
        /// EF constructor
        /// </summary>
        public Cliente(string nome, string cpf, Guid id)
        {
            Id = id;
            Nome = nome;
            Cpf = CpfValidation.ClearCpf(cpf);
            ValidateEntity();
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public void CheckClienteAlreadyExists(Cliente cliente)
        {
            if (cliente == null) return;
            AssertionConcern.AssertArgumentEquals(cliente.Cpf, Cpf, "Já existe um cliente com este CPF cadastrado!");
        }

        private void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotNull(Id, "O Id não pode estar vazio!");
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertCpfIsValid(Cpf, "O CPF é inválido");
        }
    }
}
