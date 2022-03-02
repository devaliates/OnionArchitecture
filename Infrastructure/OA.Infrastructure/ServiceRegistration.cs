using Microsoft.Extensions.DependencyInjection;

using OA.Application.Products;
using OA.Infrastructure.Products;

namespace OA.Infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services
            .AddSingleton<IProductRepository, FakeProductRepository>();

        return services;
    }
}
