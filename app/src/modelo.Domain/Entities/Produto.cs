using System;
using System.Collections.Generic;
using modelo.Domain.Entities.Base;

namespace modelo.Domain.Entities
{
    public class Produto : Entity<Guid>
    {
        public Produto(Guid id)
        {
            Id = id;
        }

        public Produto(string nome, decimal valor, Guid categoriaId, Guid? id = null)
        {
            Id = id == null ? Guid.NewGuid() : (Guid)id;
            Nome = nome;
            Valor = valor;
            CategoriaId = categoriaId;
            ValidateEntity();
        }

        /// <summary>
        /// EF constructor
        /// </summary>
        public Produto(string nome, decimal valor, Guid categoriaId, Guid id)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            CategoriaId = categoriaId;
            ValidateEntity();
        }

        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public Guid CategoriaId { get; private set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }

        public void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotNull(Id, "O Id não pode estar vazio!");
            AssertionConcern.AssertArgumentNotEmpty(Nome, "O nome não pode estar vazio!");
            AssertionConcern.AssertArgumentNotNull(Valor, "O valor não pode estar vazio!");
            AssertionConcern.AssertArgumentMinValue(Valor, 0, "O valor deve ser maior que zero!");
            AssertionConcern.AssertArgumentNotNull(CategoriaId, "O Id da categoria não pode estar vazio!");
        }
    }
}
