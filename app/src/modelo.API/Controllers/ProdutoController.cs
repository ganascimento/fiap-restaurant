using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using modelo.Application.Models.ProdutoModel;
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
    public class ProdutoController : ControllerBase
    {
        private readonly IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>> getByCategoriauseCase;
        private readonly IUseCaseIEnumerableAsync<IEnumerable<ProdutoResponse>> getAlluseCase;
        private readonly IUseCaseAsync<ProdutoPostRequest> postUseCase;
        private readonly IUseCaseAsync<ProdutoPutRequest> putUseCase;
        private readonly IUseCaseAsync<ProdutoDeleteRequest> deleteUseCase;


        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger,
            IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>> getByCategoriauseCase,
            IUseCaseIEnumerableAsync<IEnumerable<ProdutoResponse>> getAlluseCase,
            IUseCaseAsync<ProdutoPostRequest> postUseCase,
            IUseCaseAsync<ProdutoPutRequest> putUseCase,
            IUseCaseAsync<ProdutoDeleteRequest> deleteUseCase)
        {
            _logger = logger;
            this.getByCategoriauseCase = getByCategoriauseCase;
            this.getAlluseCase = getAlluseCase;
            this.postUseCase = postUseCase;
            this.putUseCase = putUseCase;
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

        [HttpGet("{CategoriaId}")]
        public async Task<IActionResult> GetProdutoByCategoriaId([FromQuery] ProdutoRequest request)
        {
            var result = await getByCategoriauseCase.ExecuteAsync(request);

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpPost()]
        public async Task<IActionResult> Post([FromBodyAttribute] ProdutoPostRequest request)
        {
            await postUseCase.ExecuteAsync(request);

            return Ok();

        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put([FromQuery] Guid Id, [FromBodyAttribute] ProdutoPutRequest request)
        {
            request.Id = Id;

            await putUseCase.ExecuteAsync(request);

            return Ok();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] ProdutoDeleteRequest request)
        {
            await deleteUseCase.ExecuteAsync(request);

            return Ok();

        }
    }
}
