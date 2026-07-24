using Microsoft.EntityFrameworkCore;
using SASTCsharpBlogPart.Models;

namespace SASTCsharpBlogPart.Data
{
	/// <summary>
	/// 初始化数据库种子数据的扩展方法类。
	/// </summary>
	public static class BlogItemSeeder
	{
		/// <summary>
		/// 初始化数据库种子数据，如果数据库中没有任何博客项，则添加一些默认的博客项。
		/// </summary>
		/// <param name="app">WebApplication 实例</param>
		/// <returns>异步任务</returns>
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
