using Microsoft.AspNetCore.Mvc;
using System;

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
