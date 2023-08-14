using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modelo.Application.Models.PagamentoModel;
using modelo.Application.UseCases;

namespace modelo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PagamentoController : ControllerBase
    {
        private readonly IUseCaseAsync<PagamentoGetRequest, Tuple<string, Guid>> _getUseCase;

        public PagamentoController(IUseCaseAsync<PagamentoGetRequest, Tuple<string, Guid>> getUseCase)
        {
            _getUseCase = getUseCase;
        }

        [HttpGet("StatusPagamento/{IdPedido}")]
        public async Task<IActionResult> AtualizaPagamento([FromRoute] Guid IdPedido)
        {
            try
            {
                var result = await _getUseCase.ExecuteAsync(new PagamentoGetRequest { IdPedido = IdPedido });
                return Ok(new
                {
                    Status = result.Item1,
                    PagamentoId = result.Item2
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}