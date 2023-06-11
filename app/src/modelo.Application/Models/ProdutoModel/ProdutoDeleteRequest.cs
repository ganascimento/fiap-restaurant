using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo.Application.Models.ProdutoModel
{
    public class ProdutoDeleteRequest
    {
        public ProdutoDeleteRequest()
        {
            Id = Guid.Empty;

        }
        [JsonProperty("id")]
        public Guid Id { get; set; }

    }
}
