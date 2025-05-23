using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApp.Services.Interfaces;

namespace MyApp.Controllers.News
{
    [ApiController]
    [Route("api/news")]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;

        }

        [EndpointDescription("Retrieve news articles from a query string.")]
        [HttpGet("search")]
        public async Task<IActionResult> Get([FromQuery] string query)
        {
            var news = await _newsService.GetNewsViaSearch(query);
            return Ok(news);
        }


        [EndpointDescription("Retrieve top headline news articles. Request number of articles via the n param.")]
        [HttpGet("latest")]
        public async Task<IActionResult> GetList([FromQuery] int n)
        {
            var news = await _newsService.GetLatestNews(n);
            return Ok(news);
        }
    }
}