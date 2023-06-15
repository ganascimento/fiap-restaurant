using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelo.Application.Models.ClienteModel;
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
        private readonly IUseCaseIEnumerableAsync<IEnumerable<ClienteResponse>> getAlluseCase;
        private readonly IUseCaseAsync<ClienteRequest, ClienteResponse> getByCPFUseCase;
        private readonly IUseCaseAsync<ClientePostRequest> postUseCase;
        private readonly IUseCaseAsync<ClienteDeleteRequest> deleteUseCase;

        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger,
            IUseCaseIEnumerableAsync<IEnumerable<ClienteResponse>> getAlluseCase,
            IUseCaseAsync<ClienteRequest, ClienteResponse> useCaseByCPFAsync,
            IUseCaseAsync<ClientePostRequest> postUseCase,
            IUseCaseAsync<ClienteDeleteRequest> deleteUseCase
            )
        {
            _logger = logger;
            this.getAlluseCase = getAlluseCase;
            this.getByCPFUseCase = useCaseByCPFAsync;
            this.postUseCase = postUseCase;
            this.deleteUseCase = deleteUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await getAlluseCase.ExecuteAsync();

            if (result.Any())
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpGet("{CPF}")]
        public async Task<IActionResult> ClienteByCPFAsync([FromQuery]ClienteRequest clienteResquest)
        {
            var result = await getByCPFUseCase.ExecuteAsync(clienteResquest);

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBodyAttribute] ClientePostRequest request)
        {
            await postUseCase.ExecuteAsync(request);
            
            return Ok();
            
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] ClienteDeleteRequest request)
        {
            await deleteUseCase.ExecuteAsync(request);

            return Ok();

        }
    }
}
