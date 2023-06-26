using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelo.Application.Models.PedidoModel;
using modelo.Application.Models.AcompanhamentoModel;
using modelo.Application.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modelo.Application.Models.ClienteModel;
using modelo.Application.Models.ProdutoModel;
using modelo.Application.UseCases.AcompanhamentoUseCase;

namespace modelo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcompanhamentoController : ControllerBase
    {
        private readonly ILogger<AcompanhamentoController> _logger;
        private readonly IUseCaseAsync<AcompanhamentoRequest, AcompanhamentoResponse> _getAcompanhamentoBySenhaUseCase;
        private readonly IUseCaseAsync<AcompanhamentoPutRequest> _putAcompanhamentoUseCaseAsync;

        public AcompanhamentoController(
            ILogger<AcompanhamentoController> logger,
            IUseCaseAsync<AcompanhamentoRequest, AcompanhamentoResponse> getAcompanhamentoBySenhaUseCaseAsync,
            IUseCaseAsync<AcompanhamentoPutRequest> putAcompanhamentoUseCaseAsync
        )
        {
            _logger = logger;
            _getAcompanhamentoBySenhaUseCase = getAcompanhamentoBySenhaUseCaseAsync;
            _putAcompanhamentoUseCaseAsync = putAcompanhamentoUseCaseAsync;
        }

        

        [HttpGet("{Senha}")]
        public async Task<IActionResult> GetAcompanhamentoBySenha([FromRoute] AcompanhamentoRequest request)
        {
            var result = await _getAcompanhamentoBySenhaUseCase.ExecuteAsync(request);

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }


        [HttpPut("{Id}")]
        public async Task<IActionResult> Put([FromRoute] Guid Id, [FromBodyAttribute] AcompanhamentoPutRequest request)
        {
            request.Id = Id;

            await _putAcompanhamentoUseCaseAsync.ExecuteAsync(request);

            return Ok();
        }

    }
}
