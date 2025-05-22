using System;

namespace MyApp.Models.NewsArticle
{
    public class NewsArticle
    {
        required public String Title { get; set; }
        required public String Description { get; set; }
        required public String Content { get; set; }
        required public String Url { get; set; }
        required public String Image { get; set; }
        required public DateTime PublishedAt { get; set; }
    }
}