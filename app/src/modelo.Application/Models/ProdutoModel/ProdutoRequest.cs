using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo.Application.Models.ProdutoModel
{
    public class ProdutoRequest
    {
        public ProdutoRequest()
        {
            CategoriaId = Guid.Empty;

        }
        [FromQuery(Name = "CategoriaId")]
        public Guid CategoriaId { get; set; }

    }
}
