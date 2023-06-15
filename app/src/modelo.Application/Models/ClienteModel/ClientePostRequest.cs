using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo.Application.Models.ClienteModel
{
    public class ClientePostRequest
    {
        public ClientePostRequest()
        {
            Nome = string.Empty;
            CPF = string.Empty;

        }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("CPF")]
        public string CPF { get; set; }

    }
}
