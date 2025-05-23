using MyApp.Models.NewsArticle;
public interface INewsApiClient
{
    Task<List<NewsArticle>> GetTopNews(int numberOfArticles);
    Task<List<NewsArticle>> GetNewsViaSearch(string searchString);
}