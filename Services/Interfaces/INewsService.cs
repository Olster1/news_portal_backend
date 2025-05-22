using System.Collections.Generic;
using MyApp.Models.NewsArticle;

namespace MyApp.Services.Interfaces
{
    public interface INewsService
    {
        Task<IEnumerable<NewsArticle>> GetLatestNews();
        Task<IEnumerable<NewsArticle>> GetNewsViaSearch(string searchString);
    }
}