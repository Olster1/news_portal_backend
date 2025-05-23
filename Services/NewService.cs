using MyApp.Models.NewsArticle;
using MyApp.Services.Interfaces;

public class NewService : INewsService
{
    private readonly INewsApiClient _newsApiClient;

    public NewService(INewsApiClient newsApiClient)
    {
        _newsApiClient = newsApiClient;
    }

    public async Task<IEnumerable<NewsArticle>> GetLatestNews(int numberOfArticles)
    {
        return await _newsApiClient.GetTopNews(numberOfArticles);
    }
    public async Task<IEnumerable<NewsArticle>> GetNewsViaSearch(string searchString)
    { 
        return await _newsApiClient.GetNewsViaSearch(searchString);
    }
}