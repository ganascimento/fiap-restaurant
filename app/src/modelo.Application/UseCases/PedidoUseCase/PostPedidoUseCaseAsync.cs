using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.ClienteModel;
using modelo.Application.Models.PedidoModel;
using System.Linq;
using modelo.Domain.Enums;

namespace modelo.Application.UseCases.PedidoUseCase
{
    public class PostPedidoUseCaseAsync : IUseCaseAsync<PedidoPostRequest>
    {
        private readonly IPedidoGateway _pedidoGateway;
        private readonly IAcompanhamentoGateway _AcompanhamentoGateway;
        private readonly IMapper _mapper;

        public PostPedidoUseCaseAsync(IPedidoGateway pedidoGateway, IMapper mapper, IAcompanhamentoGateway acompanhamentoGateway)
        {
            _pedidoGateway = pedidoGateway;
            _mapper = mapper;
            _AcompanhamentoGateway = acompanhamentoGateway;
        }

        public async Task ExecuteAsync(PedidoPostRequest request)
        {
            int senha = 0;

            var obj = _pedidoGateway.GetAllAsync();

            if (obj != null && obj.Result != null && obj.Result.Count() > 0)
            {
               senha = obj.Result.ToList().MaxBy(max => max.Senha).Senha;
            }

            //var insert = _mapper.Map<PedidoPostRequest, Pedido>(request);

            senha = senha + 1;

            if (request.Pedido.Count > 0)
            {
                request.Pedido.ForEach(categoria =>
                {
                    categoria.Produto.ForEach(produto =>
                    {
                        Pedido insert = new Pedido();

                        insert.CategoriaId = categoria.CategoriaId;
                        insert.ProdutoId = produto.ProdutoId;
                        insert.Senha = senha;

                        _pedidoGateway.Insert(insert);
                    });
                });

                Acompanhamento acompanhamento = new Acompanhamento();
                acompanhamento.Senha = senha;
                acompanhamento.Status = Status.Pendente.Id;
                _AcompanhamentoGateway.Insert(acompanhamento);
            }                      
        }
    }
}
