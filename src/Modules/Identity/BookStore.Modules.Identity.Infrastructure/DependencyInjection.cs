using BookStore.Modules.Identity.Application;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Modules.Identity.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentityModule(this IServiceCollection services)
    {
        services.AddApplication();
        return services;
    }
}
