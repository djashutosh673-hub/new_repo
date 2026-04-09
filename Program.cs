using MyRdsApp.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// get connection string from environment
var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.MapGet("/", () => "My App is Running 🚀");

// run on port 80
app.Urls.Add("http://0.0.0.0:80");

app.Run();