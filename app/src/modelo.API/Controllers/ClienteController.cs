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
    public class ClienteController : ControllerBase
    {
        private readonly IUseCaseIEnumerableAsync<IEnumerable<ClienteResponse>> useCaseAsyncResponse;
        private readonly IUseCaseAsync<ClienteRequest, ClienteResponse> useCaseByNameAsync;

        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger, IUseCaseIEnumerableAsync<IEnumerable<ClienteResponse>> useCaseAsyncResponse, IUseCaseAsync<ClienteRequest, ClienteResponse> useCaseByNameAsync)
        {
            _logger = logger;
            this.useCaseAsyncResponse = useCaseAsyncResponse;
            this.useCaseByNameAsync = useCaseByNameAsync;
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

        [HttpGet("{Nome}")]
        public async Task<IActionResult> ClienteByNomeAsync([FromQuery]ClienteRequest clienteResquest)
        {
            var result = await useCaseByNameAsync.ExecuteAsync(clienteResquest);

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }
    }
}
