using System;
using System.Collections.Generic;
using modelo.Domain.Enums;

namespace modelo.Application.Models.PedidoModel
{
    public class GetPedidoDetalhadoUseCaseAsync
    {
        public Guid Id { get; set; }
        public int Senha { get; set; }
        public Status Status { get; set; }
        public StatusPagamento StatusPagamento { get; set; }
        public List<GetItemPedidoUseCaseAsync> ItensPedido { get; set; }
    }
}