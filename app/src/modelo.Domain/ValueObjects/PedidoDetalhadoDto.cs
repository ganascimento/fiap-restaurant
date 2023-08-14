using System;
using System.Collections.Generic;
using modelo.Domain.Enums;

namespace modelo.Domain.ValueObjects
{
    public class PedidoDetalhadoDto
    {
        public Guid Id { get; set; }
        public int Senha { get; set; }
        public Status Status { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public List<ItemPedidoDto> ItensPedido { get; set; }
    }
}
