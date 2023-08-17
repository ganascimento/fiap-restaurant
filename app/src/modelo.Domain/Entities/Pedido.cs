using modelo.Domain.Entities.Base;
using modelo.Domain.Enums;
using System;
using System.Collections.Generic;

namespace modelo.Domain.Entities
{
    public class Pedido : Entity<Guid>
    {
        private Pedido() { }

        public Pedido(Guid? id = null, Status? status = null, Pagamento pagamento = null)
        {
            Id = id == null ? Guid.NewGuid() : (Guid)id;
            this.Status = status == null ? Status.Pendente : (Status)status;
            Pagamento = pagamento;
            ValidateEntity();
        }

        public int Senha { get; private set; }
        public Status Status { get; private set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
        public virtual Pagamento Pagamento { get; set; }

        public void AddItemPedido(ItemPedido itemPedido)
        {
            if (ItensPedido == null) ItensPedido = new List<ItemPedido>();
            ItensPedido.Add(itemPedido);
        }

        public void SetStatus(short status)
        {
            this.Status = (Status)status;
            ValidateEntity();
        }

        public void AddPagamento(TipoPagamento tipo)
        {
            Pagamento = new Pagamento(tipo, this.Id);
        }

        private void ValidateEntity()
        {
            AssertionConcern.AssertArgumentNotNull(Id, "O Id não pode estar vazio!");
            AssertionConcern.AssertArgumentNotNull(this.Status, "O Status não pode estar vazio!");
            AssertionConcern.AssertArgumentRange((short)this.Status, 0, 3, "O Status informado não existe");
        }
    }
}
