using Microsoft.EntityFrameworkCore;
using SASTCsharpBlogPart.Endpoints;
using SASTCsharpBlogPart.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("BlogItemContext")
	?? throw new InvalidOperationException("Connection string 'BlogItemContext' not found.");

builder.Services.AddDbContext<BlogItemContext>(options => options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

await app.InitializeAsync();
app.MapBlogItemEndpoints();

app.Run();
