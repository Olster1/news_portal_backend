/*NOTE: 
This is my tests 
*/
// using Xunit;
// using Microsoft.AspNetCore.Mvc;
// using System.Threading.Tasks;
// using MyApp.Controllers.News;
// using MyApp.Models.NewsArticle;

// public class NewsControllerTests
// {
//     [Fact]
//     public async Task Get_WithQuery_ReturnsOkWithArticles()
//     {
//         // Arrange
//         var fakeService = new FakeNewsService();
//         var controller = new NewsController(fakeService);
//         var testQuery = "testing";

//         // Act
//         var result = await controller.Get(testQuery);

//         // Assert
//         var okResult = Assert.IsType<OkObjectResult>(result);
//         var articles = Assert.IsAssignableFrom<List<NewsArticle>>(okResult.Value);
//         Assert.Single(articles);
//         Assert.Contains(testQuery, articles[0].Title);
//         Assert.Equal(testQuery, fakeService.LastSearchQuery);
//     }

//     [Fact]
//     public async Task GetList_WithN_ReturnsOkWithArticles()
//     {
//         // Arrange
//         var fakeService = new FakeNewsService();
//         var controller = new NewsController(fakeService);
//         int n = 5;

//         // Act
//         var result = await controller.GetList(n);

//         // Assert
//         var okResult = Assert.IsType<OkObjectResult>(result);
//         var articles = Assert.IsAssignableFrom<List<NewsArticle>>(okResult.Value);
//         Assert.Single(articles);
//         Assert.Contains(n.ToString(), articles[0].Title);
//         Assert.Equal(n, fakeService.LastLatestNewsCount);
//     }
// }