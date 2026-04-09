using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

var app = builder.Build();

// Configure pipeline
app.MapControllers();
app.Urls.Add("http://0.0.0.0:80");
app.MapGet("/", () => "My App is Running 🚀");
app.Run();