using Microsoft.AspNetCore.Mvc;

namespace modelo.Application.Models.AcompanhamentoModel
{
    public class AcompanhamentoRequest
    {
        public AcompanhamentoRequest()
        {
            Senha = 0;
        }

        [FromRoute]
        public int Senha { get; set; }
    }
}
