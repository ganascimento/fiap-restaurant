using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo.Application.Models.ProdutoModel
{
    public class ProdutoPostRequest
    {
        public ProdutoPostRequest()
        {
            Nome = string.Empty;
            Valor = 0;
            CategoriaId = Guid.Empty;

        }

        [JsonProperty("Nome")]
        public string Nome { get; set; }

        [JsonProperty("Valor")]
        public decimal Valor { get; set; }

        [JsonProperty("CategoriaId")]
        public Guid? CategoriaId { get; set; }

    }
}
