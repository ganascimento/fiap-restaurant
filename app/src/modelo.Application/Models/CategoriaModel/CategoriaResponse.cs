using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Application.Models.CategoriaModel
{
    public class CategoriaResponse
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }


    }
}
