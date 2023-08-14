using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modelo.Application.Models.PagamentoModel;
using modelo.Application.UseCases;

namespace modelo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : ControllerBase
    {
        private readonly IUseCaseAsync<PagamentoPutRequest> _putUseCase;

        public WebHookController(IUseCaseAsync<PagamentoPutRequest> putUseCase)
        {
            _putUseCase = putUseCase;
        }

        [HttpPut("AtualizaPagamento/{Id}")]
        public async Task<IActionResult> AtualizaPagamento([FromRoute] Guid Id, [FromBodyAttribute] PagamentoPutRequest request)
        {
            try
            {
                request.Id = Id;
                await _putUseCase.ExecuteAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}