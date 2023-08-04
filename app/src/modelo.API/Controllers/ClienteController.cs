using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelo.Application.Models.ClienteModel;
using modelo.Application.UseCases;
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
        private readonly IUseCaseIEnumerableAsync<IEnumerable<ClienteResponse>> _getAlluseCase;
        private readonly IUseCaseAsync<ClienteRequest, ClienteResponse> _getByCPFUseCase;
        private readonly IUseCaseAsync<ClientePostRequest> _postUseCase;
        private readonly IUseCaseAsync<ClienteDeleteRequest> _deleteUseCase;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger,
            IUseCaseIEnumerableAsync<IEnumerable<ClienteResponse>> getAlluseCase,
            IUseCaseAsync<ClienteRequest, ClienteResponse> useCaseByCPFAsync,
            IUseCaseAsync<ClientePostRequest> postUseCase,
            IUseCaseAsync<ClienteDeleteRequest> deleteUseCase)
        {
            _logger = logger;
            _getAlluseCase = getAlluseCase;
            _getByCPFUseCase = useCaseByCPFAsync;
            _postUseCase = postUseCase;
            _deleteUseCase = deleteUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var result = await _getAlluseCase.ExecuteAsync();

                if (result.Any())
                    return Ok(result);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{Cpf}")]
        public async Task<IActionResult> ClienteByCPFAsync([FromRoute] ClienteRequest clienteResquest)
        {
            try
            {
                var result = await _getByCPFUseCase.ExecuteAsync(clienteResquest);

                if (result != null)
                    return Ok(result);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBodyAttribute] ClientePostRequest request)
        {
            try
            {
                await _postUseCase.ExecuteAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] ClienteDeleteRequest request)
        {
            try
            {
                await _deleteUseCase.ExecuteAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
