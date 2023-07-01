using Microsoft.AspNetCore.Mvc;
using System;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoDeleteRequest
    {
        public PedidoDeleteRequest()
        {
            Id = Guid.Empty;
        }

        [FromRoute]
        public Guid Id { get; set; }
    }
}
