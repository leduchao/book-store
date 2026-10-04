using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Modules.Catalog.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}
