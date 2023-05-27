using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.Extensions
{
    public static class AutoMapperExtensions
    {
        public static void RegisterAutoMapper(this IServiceCollection serviceCollection)
        {
            var autoMapper = new MapperConfiguration(c =>
            {
                c.AddProfile<Application.Mappers.AutoMapperProfile>();
            });
            serviceCollection.AddSingleton(autoMapper.CreateMapper());
        }
    }
}
