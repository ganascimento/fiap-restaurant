using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelo.Application.Models.ProdutoModel;
using modelo.Application.UseCases;
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
        private readonly IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>> _getByCategoriauseCase;
        private readonly IUseCaseIEnumerableAsync<IEnumerable<ProdutoResponse>> _getAlluseCase;
        private readonly IUseCaseAsync<ProdutoPostRequest> _postUseCase;
        private readonly IUseCaseAsync<ProdutoPutRequest> _putUseCase;
        private readonly IUseCaseAsync<ProdutoDeleteRequest> _deleteUseCase;
        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger,
            IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>> getByCategoriauseCase,
            IUseCaseIEnumerableAsync<IEnumerable<ProdutoResponse>> getAlluseCase,
            IUseCaseAsync<ProdutoPostRequest> postUseCase,
            IUseCaseAsync<ProdutoPutRequest> putUseCase,
            IUseCaseAsync<ProdutoDeleteRequest> deleteUseCase)
        {
            _logger = logger;
            _getByCategoriauseCase = getByCategoriauseCase;
            _getAlluseCase = getAlluseCase;
            _postUseCase = postUseCase;
            _putUseCase = putUseCase;
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

        [HttpGet("{CategoriaId}")]
        public async Task<IActionResult> GetProdutoByCategoriaId([FromQuery] ProdutoRequest request)
        {
            var result = await _getByCategoriauseCase.ExecuteAsync(request);

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpPost()]
        public async Task<IActionResult> Post([FromBodyAttribute] ProdutoPostRequest request)
        {
            await _postUseCase.ExecuteAsync(request);

            return Ok();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put([FromQuery] Guid Id, [FromBodyAttribute] ProdutoPutRequest request)
        {
            request.Id = Id;

            await _putUseCase.ExecuteAsync(request);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] ProdutoDeleteRequest request)
        {
            await _deleteUseCase.ExecuteAsync(request);

            return Ok();
        }
    }
}
