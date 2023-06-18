using Newtonsoft.Json;
using System;

namespace modelo.Application.Models.CategoriaModel
{
    public class CategoriaResponse
    {
        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("Nome")]
        public string Nome { get; set; }
    }
}
