using MyApp.Models.NewsArticle;
public interface INewsApiClient
{
    Task<List<NewsArticle>> GetTopNewsFromExternalApiAsync();
    Task<List<NewsArticle>> GetNewsViaSearch(string searchString);
}