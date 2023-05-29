using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo.Application.Models
{
    public class ClienteRequest
    {
        public ClienteRequest()
        {
            Id = Guid.Empty;
            Nome = string.Empty;
            CPF = string.Empty;

        }
        [FromRoute(Name = "id")]
        public Guid Id { get; set; }

        [FromRoute(Name = "Nome")]
        public string Nome { get; set; }

        [FromRoute(Name = "CPF")]
        public string CPF { get; set; }
       
    }
}
