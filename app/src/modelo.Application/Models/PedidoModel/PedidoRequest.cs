using Microsoft.AspNetCore.Mvc;
using System;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoRequest
    {
        public PedidoRequest()
        {
            Senha = 0;
        }

        [FromQuery(Name = "Senha")]
        public int Senha { get; set; }
    }
}
