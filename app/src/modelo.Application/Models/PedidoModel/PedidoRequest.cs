using Microsoft.AspNetCore.Mvc;

namespace modelo.Application.Models.PedidoModel
{
    public class PedidoRequest
    {
        public PedidoRequest()
        {
            Senha = 0;
        }

        [FromRoute]
        public int Senha { get; set; }
    }
}
