using Microsoft.Extensions.DependencyInjection;
using System;
using AutoMapper;

namespace Shop.API.Mapper
{
    public static class MapperModule
    {
        public static void MapModules(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies(), ServiceLifetime.Scoped);
        }
    }
}
