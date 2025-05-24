using System.Collections.Generic;
using System.Threading.Tasks;
using MyApp.Models.NewsArticle;
using MyApp.Services.Interfaces;

public class FakeNewsService : INewsService
{
    public string LastSearchQuery { get; private set; } = "";
    public int LastLatestNewsCount { get; private set; } = 0;

    Task<IEnumerable<NewsArticle>> INewsService.GetLatestNews(int n)
    {
        NewsArticle[] articles = 
        {
            new NewsArticle { Title = "Latest news article " + n, Content = "", Description = "", Image = "", PublishedAt = new DateTime(), Url = "" }
        };

         LastLatestNewsCount = n;
        return Task.FromResult(articles.AsEnumerable());
    }

    Task<IEnumerable<NewsArticle>> INewsService.GetNewsViaSearch(string query)
    {
         LastSearchQuery = query;
        return Task.FromResult(new List<NewsArticle> 
        { 
            new NewsArticle { Title = "Fake article for " + query, Content = "", Description = "", Image = "", PublishedAt = new DateTime(), Url = "" }
        }.AsEnumerable());
    }
}