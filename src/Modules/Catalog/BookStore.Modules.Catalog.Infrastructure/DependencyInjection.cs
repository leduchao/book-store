using BookStore.Modules.Catalog.Application;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Modules.Catalog.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddCatalogModule(this IServiceCollection services)
    {
        services.AddApplication();
        return services;
    }
}
