using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("BlogItemContext") ?? throw new InvalidOperationException("Connection string 'BlogItemContext' not found.");

builder.Services.AddDbContext<BlogItemContext>(options => options.UseSqlite(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.MapBlogItemEndpoints();

app.Run();
