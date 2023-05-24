using AutoMapper;
using modelo.Application.Models;
using modelo.Domain.Entities;

namespace modelo.Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WeatherForecastResponse, WeatherForecast>().ReverseMap();
        }
    }
}
