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

        [HttpGet("search")]
        public async Task<IActionResult> Get([FromQuery] string query)
        {
            var news = await _newsService.GetNewsViaSearch(query);
            return Ok(news);
        }


        [HttpGet("latest")]
        public async Task<IActionResult> GetList([FromQuery] int n)
        {
            var news = await _newsService.GetLatestNews(n);
            return Ok(news);
        }
    }
}