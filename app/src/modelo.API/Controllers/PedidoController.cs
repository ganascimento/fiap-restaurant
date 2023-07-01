using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelo.Application.Models.PedidoModel;
using modelo.Application.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modelo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IUseCaseIEnumerableAsync<PedidoRequest, PedidoDetalhadoPorSenhaResponse> _getBySenhaCase;
        private readonly IUseCaseIEnumerableAsync<IEnumerable<PedidoDetalhadoResponse>> _getAlluseCase;
        private readonly IUseCaseAsync<PedidoPostRequest> _postUseCase;
        private readonly IUseCaseAsync<PedidoDeleteRequest> _deleteUseCase;
        private readonly ILogger<PedidoController> _logger;

        public PedidoController(ILogger<PedidoController> logger,
            IUseCaseIEnumerableAsync<PedidoRequest, PedidoDetalhadoPorSenhaResponse> getBySenhauseCase,
            IUseCaseIEnumerableAsync<IEnumerable<PedidoDetalhadoResponse>> getAlluseCase,
            IUseCaseAsync<PedidoPostRequest> postUseCase,
            IUseCaseAsync<PedidoDeleteRequest> deleteUseCase)
        {
            _logger = logger;
            _getBySenhaCase = getBySenhauseCase;
            _getAlluseCase = getAlluseCase;
            _postUseCase = postUseCase;
            _deleteUseCase = deleteUseCase;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _getAlluseCase.ExecuteAsync();

            if (result.Any())
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpGet("{Senha}")]
        public async Task<IActionResult> GetPedidoBySenha([FromRoute] PedidoRequest request)
        {
            var result = await _getBySenhaCase.ExecuteAsync(request);

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpPost()]
        public async Task<IActionResult> Post([FromBodyAttribute] PedidoPostRequest request)
        {
            try
            {
                await _postUseCase.ExecuteAsync(request);
            } 
            catch (InvalidOperationException exception)
            {
                return BadRequest(exception.Message);
            }

            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] PedidoDeleteRequest request)
        {
            await _deleteUseCase.ExecuteAsync(request);

            return Ok();
        }
    }
}
