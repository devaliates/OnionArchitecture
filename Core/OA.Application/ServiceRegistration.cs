using MediatR;

using Microsoft.Extensions.DependencyInjection;

using OA.Application.Mapping;

namespace OA.Application;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services
            .AddAutoMapper(typeof(GeneralMapping))
            .AddMediatR(typeof(ServiceRegistration));

        return services;
    }
}
