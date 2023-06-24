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

namespace modelo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcompanhamentoController : ControllerBase
    {
        private readonly ILogger<AcompanhamentoController> _logger;
        private readonly IUseCaseAsync<AcompanhamentoRequest, AcompanhamentoResponse> _getAcompanhamentoBySenhaUseCase;
        public AcompanhamentoController(
            ILogger<AcompanhamentoController> logger,
            IUseCaseAsync<AcompanhamentoRequest, AcompanhamentoResponse> getAcompanhamentoBySenhaUseCaseAsync
        )
        {
            _logger = logger;
            _getAcompanhamentoBySenhaUseCase = getAcompanhamentoBySenhaUseCaseAsync;
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


        //[HttpPut("{Id}")]
        //public async Task<IActionResult> Put([FromQuery] Guid Id, [FromBodyAttribute] AcompanhamentoPutRequest request)
        //{
        //    request.Id = Id;

        //    await _putUseCase.ExecuteAsync(request);

        //    return Ok();
        //}

    }
}
