using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MyApp.Models.NewsArticle;

class NewsApiType {
    public int TotalArticles { get; set; } = 0;
    public List<NewsArticle> Articles { get; set; } = [];
}

public class NewsApiClient : INewsApiClient
{
    private readonly HttpClient _httpClient;

    //NOTE: The api key is stored in user-secrets for the development environment. In production, we would set it using environment variables, in something like AWS Secrets Manager.
    private readonly string _apiKey = "";
    
    public NewsApiClient(HttpClient httpClient, IConfiguration config)
    {
        _httpClient = httpClient;
        //NOTE: Get the secret API key from user-secrets (dev) or envinroment (prod) variables
        _apiKey = config["GNewsApiKey"]; 
    }

    public async Task<List<NewsArticle>> GetTopNewsFromExternalApiAsync()
    {
        //NOTE: Access the appropriate API for GNEWS and parse the result as json
        NewsApiType? response = await _httpClient.GetFromJsonAsync<NewsApiType>($"top-headlines?category=general&lang=en&country=us&max=10&apikey={_apiKey}");
        
        return response?.Articles ?? [];
    }

    public async Task<List<NewsArticle>> GetNewsViaSearch(string searchString)
    {
        //NOTE: Make sure the search string we are passing to GNews is safley encoded to get correct results from the API
        string safeQuery = Uri.EscapeDataString(searchString);
        var response = await _httpClient.GetFromJsonAsync<NewsApiType>($"search?q={safeQuery}&lang=en&country=us&max=10&apikey={_apiKey}");
        return response?.Articles ?? [];
    }
}