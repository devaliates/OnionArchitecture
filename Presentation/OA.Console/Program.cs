
using Microsoft.Extensions.DependencyInjection;

using OA.Application;
using OA.Console;
using OA.Infrastructure;

var services = new ServiceCollection();

services
    .AddSingleton<Startup>()
    .AddApplicationServices()
    .AddInfrastructureServices();


var serviceProvider = services.BuildServiceProvider();

serviceProvider.GetService<Startup>();