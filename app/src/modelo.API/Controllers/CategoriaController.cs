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

    public class CategoriaController : ControllerBase
    {
        private readonly IUseCaseIEnumerableAsync<IEnumerable<CategoriaResponse>> useCaseAsyncResponse;
        
        private readonly ILogger<CategoriaController> _logger;

        public CategoriaController(ILogger<CategoriaController> logger, IUseCaseIEnumerableAsync<IEnumerable<CategoriaResponse>> useCaseAsyncResponse)
        {
            _logger = logger;
            this.useCaseAsyncResponse = useCaseAsyncResponse;
           
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await useCaseAsyncResponse.ExecuteAsync();

            if (result.Any())
            {
                return Ok(result);
            }

            return NoContent();
        }
        
    }
}
