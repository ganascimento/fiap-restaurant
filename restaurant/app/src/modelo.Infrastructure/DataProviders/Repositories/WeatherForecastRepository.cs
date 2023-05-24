using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class WeatherForecastRepository : RepositoryBase<WeatherForecast,Guid>, IWeatherForecastGateway
    {
        public WeatherForecastRepository(DBContext dbContext) : base(dbContext){ }
    }
}
