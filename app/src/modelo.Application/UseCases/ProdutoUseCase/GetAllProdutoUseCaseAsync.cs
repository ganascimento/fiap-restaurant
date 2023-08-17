using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using modelo.Application.Enums;
using modelo.Application.Models.ProdutoModel;
using modelo.Domain.Entities;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases.ProdutoUseCase
{
    public class GetAllProdutoUseCaseAsync : IUseCaseIEnumerableAsync<IEnumerable<ProdutoResponse>>
    {
        private readonly IProdutoGateway _gateway;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;

        public GetAllProdutoUseCaseAsync(IProdutoGateway gateway, IMapper mapper, IMemoryCache memoryCache)
        {
            _gateway = gateway;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }

        public async Task<IEnumerable<ProdutoResponse>> ExecuteAsync()
        {
            if (!_memoryCache.TryGetValue(CacheKeys.TodosProduto, out IEnumerable<Produto> cacheValue))
            {
                var result = await _gateway.GetAllAsync();
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(5));
                _memoryCache.Set(CacheKeys.TodosProduto, result, cacheEntryOptions);

                return _mapper.Map<IEnumerable<ProdutoResponse>>(result);
            }

            return _mapper.Map<IEnumerable<ProdutoResponse>>(cacheValue);
        }
    }
}
