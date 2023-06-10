using AutoMapper;
using modelo.Application.Models;
using modelo.Domain.Entities;
using System.Collections.Generic;

namespace modelo.Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WeatherForecastResponse, WeatherForecast>().ReverseMap();
            CreateMap<ClienteResponse, Cliente>().ReverseMap();
            CreateMap<CategoriaResponse, Categoria>().ReverseMap();
            CreateMap<ProdutoResponse, Produto>().ReverseMap();
            //CreateMap<IEnumerable<ProdutoResponse>, IEnumerable<Produto>>().ReverseMap();
            //CreateMap<IEnumerable<Produto>, IEnumerable<ProdutoResponse>>().ReverseMap();
        }
    }
}
