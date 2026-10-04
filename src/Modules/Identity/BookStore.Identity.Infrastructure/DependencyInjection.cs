using BookStore.Identity.Application;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Identity.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentityModule(this IServiceCollection services)
    {
        services.AddApplication();
        return services;
    }
}
