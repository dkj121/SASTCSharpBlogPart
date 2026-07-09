using Microsoft.EntityFrameworkCore;
using SASTCsharpBlogPart.Models;

namespace SASTCsharpBlogPart.Data
{
	public static class BlogItemSeeder
	{
		public static async Task InitializeAsync(this WebApplication app)
		{
			using var scope = app.Services.CreateScope();

			var context = scope.ServiceProvider
				.GetRequiredService<BlogItemContext>();

			await context.Database.EnsureCreatedAsync();

			if (await context.BlogItem.AnyAsync())
			{
				return;
			}

			context.BlogItem.AddRange(
				new BlogItem
				{
					Title = "安装你的第一套 .NET 环境",
					Author = "DKJ",
					Description = "安装你的第一套 .NET 环境",
					Content = new Uri("/wwwroot/blogs/安装你的第一套 .NET 环境.md", UriKind.Relative),
				},
				new BlogItem
				{
					Title = "ASP.NET Core Docs",
					Author = "DKJ",
					Description = "ASP.NET Core Docs",
					Content = new Uri("/wwwroot/blogs/ASP.NET Core Docs.md", UriKind.Relative)
				},
				new BlogItem
				{
					Title = "一套基于 WSL 部署 Linux 发行版的方法",
					Author = "DKJ",
					Description = "一套基于 WSL 部署 Linux 发行版的方法",
					Content = new Uri("/wwwroot/blogs/一套基于 WSL 部署 Linux 发行版的方法.md", UriKind.Relative)
				}
			);

			await context.SaveChangesAsync();
		}
	}

}
