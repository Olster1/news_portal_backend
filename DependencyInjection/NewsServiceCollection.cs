using Microsoft.Extensions.DependencyInjection;
using MyApp.Services;
using MyApp.Services.Interfaces;

public static class NewsServiceCollectionExtensions
{
    public static IServiceCollection AddNewsServices(this IServiceCollection services)
    {
        services.AddScoped<INewsService, NewService>();
        services.AddHttpClient<INewsApiClient, NewsApiClient>(client =>
        {
            //NOTE: This is the base address for the gnews api. If the base api changes, change it here.
            client.BaseAddress = new Uri("https://gnews.io/api/v4/");
        });

        return services;
    }
}