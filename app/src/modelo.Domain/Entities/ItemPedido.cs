using System;
using modelo.Domain.Entities.Base;

namespace modelo.Domain.Entities
{
    public class ItemPedido : Entity<Guid>
    {
        private ItemPedido() { }

        public ItemPedido(Guid pedidoId, Guid produtoId, string observacao, Guid? id = null)
        {
            Id = id == null ? Guid.NewGuid() : (Guid)id;
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            Observacao = observacao;

            ValidateEntity();
        }

        public Guid PedidoId { get; set; }
        public Guid ProdutoId { get; set; }
        public string Observacao { get; set; }

        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }

        private void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotNull(Id, "O Id não pode estar vazio!");
            AssertionConcern.AssertArgumentNotNull(PedidoId, "O Id do pedido não pode estar vazio!");
            AssertionConcern.AssertArgumentNotNull(ProdutoId, "O Id do produto não pode estar vazio!");
            if (!string.IsNullOrEmpty(Observacao))
                AssertionConcern.AssertArgumentLength(Observacao, 500, "A observação deve conter no máximo 500 caracteres");
        }
    }
}