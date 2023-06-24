using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
