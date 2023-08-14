using Microsoft.AspNetCore.Mvc;
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

        public ProdutoController(IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>> getByCategoriauseCase,
            IUseCaseIEnumerableAsync<IEnumerable<ProdutoResponse>> getAlluseCase,
            IUseCaseAsync<ProdutoPostRequest> postUseCase,
            IUseCaseAsync<ProdutoPutRequest> putUseCase,
            IUseCaseAsync<ProdutoDeleteRequest> deleteUseCase)
        {
            _getByCategoriauseCase = getByCategoriauseCase;
            _getAlluseCase = getAlluseCase;
            _postUseCase = postUseCase;
            _putUseCase = putUseCase;
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

        [HttpGet("{CategoriaId}")]
        public async Task<IActionResult> GetProdutoByCategoriaId([FromRoute] ProdutoRequest request)
        {
            try
            {
                var result = await _getByCategoriauseCase.ExecuteAsync(request);

                if (result != null)
                    return Ok(result);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost()]
        public async Task<IActionResult> Post([FromBodyAttribute] ProdutoPostRequest request)
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

        [HttpPut("{Id}")]
        public async Task<IActionResult> Put([FromRoute] Guid Id, [FromBodyAttribute] ProdutoPutRequest request)
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

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] ProdutoDeleteRequest request)
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
