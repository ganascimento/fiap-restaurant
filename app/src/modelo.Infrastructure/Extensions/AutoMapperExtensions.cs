using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

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
