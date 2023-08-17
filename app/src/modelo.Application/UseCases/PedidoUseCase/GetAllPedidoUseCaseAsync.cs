using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using modelo.Application.Enums;
using modelo.Application.Models.PedidoModel;
using modelo.Domain.Entities;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases.PedidoUseCase
{
    public class GetAllPedidoUseCaseAsync : IUseCaseIEnumerableAsync<IEnumerable<PedidoDetalhadoResponse>>
    {
        private readonly IPedidoGateway _gateway;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;

        public GetAllPedidoUseCaseAsync(IPedidoGateway gateway, IMapper mapper, IMemoryCache memoryCache)
        {
            _gateway = gateway;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }

        public async Task<IEnumerable<PedidoDetalhadoResponse>> ExecuteAsync()
        {
            if (!_memoryCache.TryGetValue(CacheKeys.TodosPedidos, out IEnumerable<Pedido> cacheValue))
            {
                var result = await _gateway.GetPedidosDetalhados();
                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(10));
                _memoryCache.Set(CacheKeys.TodosPedidos, result, cacheEntryOptions);

                return _mapper.Map<IEnumerable<PedidoDetalhadoResponse>>(result);
            }

            return _mapper.Map<IEnumerable<PedidoDetalhadoResponse>>(cacheValue);
        }
    }
}
