using AutoMapper;
using modelo.Application.Models.CategoriaModel;
using modelo.Application.Models.ClienteModel;
using modelo.Application.Models.ProdutoModel;
using modelo.Domain.Entities;

namespace modelo.Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClienteResponse, Cliente>().ReverseMap();
            CreateMap<ClientePostRequest, Cliente>().ReverseMap();

            CreateMap<CategoriaResponse, Categoria>().ReverseMap();

            CreateMap<ProdutoResponse, Produto>().ReverseMap();
            CreateMap<ProdutoPostRequest, Produto>().ReverseMap();
            CreateMap<ProdutoPutRequest, Produto>().ReverseMap();
        }
    }
}
