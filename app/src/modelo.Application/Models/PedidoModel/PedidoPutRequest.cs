using System;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoPutRequest
    {
        public Guid Id { get; set; }
        public short Status { get; set; }
    }
}