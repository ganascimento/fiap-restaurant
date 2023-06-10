using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelo.Application.Models;
using modelo.Application.UseCases;
using modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modelo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>> useCaseIEnumerableAsync;
        
        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger, IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>> useCaseIEnumerableAsync)
        {
            _logger = logger;
            this.useCaseIEnumerableAsync = useCaseIEnumerableAsync;
           
        }
       

        [HttpGet("{CategoriaId}")]
        public async Task<IActionResult> GetProdutoByCategoriaId([FromQuery] ProdutoRequest request)
        {
            var result = await useCaseIEnumerableAsync.ExecuteAsync(request);

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }
    }
}
