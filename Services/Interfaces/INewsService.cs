using System.Collections.Generic;
using MyApp.Models.NewsArticle;

namespace MyApp.Services.Interfaces
{
    public interface INewsService
    {
        Task<IEnumerable<NewsArticle>> GetLatestNews(int numberOfArticles);
        Task<IEnumerable<NewsArticle>> GetNewsViaSearch(string searchString);
    }
}