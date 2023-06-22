using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using modelo.Application.Enums;
using modelo.Application.Models.PedidoModel;
using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using modelo.Domain.ValueObjects;
using System.Linq;

namespace modelo.Application.UseCases.PedidoUseCase
{
    public class GetPedidoBySenhaUseCaseAsync : IUseCaseIEnumerableAsync<PedidoRequest, PedidoDetalhadoPorSenhaResponse>
    {
        private readonly IPedidoGateway _gateway;
        private readonly IMapper _mapper;
        private readonly IMemoryCache _memoryCache;

        public GetPedidoBySenhaUseCaseAsync(IPedidoGateway gateway, IMapper mapper, IMemoryCache memoryCache)
        {
            _gateway = gateway;
            _mapper = mapper;
            _memoryCache = memoryCache;
        }

        public async Task<PedidoDetalhadoPorSenhaResponse> ExecuteAsync(PedidoRequest request)
        {
            var key = CacheKeys.CategoriaProduto + request.Senha;

            PedidoDetalhadoPorSenhaResponse PedidoDetalhadoPorSenha = new PedidoDetalhadoPorSenhaResponse();

            if (!_memoryCache.TryGetValue(key, out IEnumerable<PedidoDetalhadoDto> cacheValue))
            {
                var result = await _gateway.GetPedidoBySenhaUseCaseAsync(request.Senha);

                PedidoDetalhadoPorSenha.Pedido = result.ToList();

                PedidoDetalhadoPorSenha.ValorTotal = result.ToList().Sum(sum => sum.Valor);

                var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(20));
                _memoryCache.Set(key, PedidoDetalhadoPorSenha, cacheEntryOptions);

                return PedidoDetalhadoPorSenha;
            }

            return _mapper.Map<PedidoDetalhadoPorSenhaResponse>(cacheValue);
        }
    }
}
