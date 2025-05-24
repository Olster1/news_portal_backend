using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyApp.Services;
using MyApp.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
IWebHostEnvironment env = builder.Environment;

String frontEndOrigin = "http://localhost:5173";

if (env.IsProduction()) { 
    //TODO: Add custom domain name for CORS
}

//NOTE: This turns CORS on for our frontend origin. If we want to make our API public we would have to think more about how we approach this. 
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(frontEndOrigin)
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

//NOTE: Add openai for our documentation
builder.Services.AddOpenApi();

builder.Services.AddControllers();

//NOTE: Initialize all the custom services we're using. 
//      If you are adding another service add it as a new function in 
//        NewsServiceCollectionExtensions in the DependencyInjection folder.
builder.Services.AddNewsServices();


var app = builder.Build();

app.MapOpenApi();

app.UseCors();
//TODO: Enable https redirection
// app.UseHttpsRedirection();

//TODO: Add Authentication middleware
// app.UseAuthentication();
// app.UseAuthorization();

app.MapControllers(); 

app.Run();