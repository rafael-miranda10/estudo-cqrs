using Microsoft.Extensions.DependencyInjection;
using Shop.API.Data.Context;
using Shop.API.Data.Repository;
using Shop.API.Domain.Interfaces;

namespace Shop.API.IoC
{
    public static class CustomerModule
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<CustomerContext>();
        }
    }
}
