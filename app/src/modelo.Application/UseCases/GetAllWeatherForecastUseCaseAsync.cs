using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases
{
    public class GetAllWeatherForecastUseCaseAsync :IUseCaseIEnumerableAsync<IEnumerable<WeatherForecastResponse>>
    {
        private readonly IWeatherForecastGateway weatherForecastGateway;
        private readonly IMapper mapper;


        public GetAllWeatherForecastUseCaseAsync(IWeatherForecastGateway weatherForecastGateway, IMapper mapper)
        {
            this.weatherForecastGateway = weatherForecastGateway;
            this.mapper = mapper;

        }

        public async Task<IEnumerable<WeatherForecastResponse>> ExecuteAsync()
        {
            var result = await weatherForecastGateway.GetAllAsync();

            return mapper.Map<IEnumerable<WeatherForecastResponse>>(result);
        }
    }
}
