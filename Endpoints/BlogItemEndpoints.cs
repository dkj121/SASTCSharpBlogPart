using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SASTCsharpBlogPart.Models;

/// <summary>
/// 提供 BlogItem 相关的 API 端点。
/// </summary>
namespace SASTCsharpBlogPart.Endpoints
{
	/// <summary>
	/// 将 BlogItem 相关的 API 端点映射到路由构建器的扩展方法类。
	/// </summary>
	public static class BlogItemEndpoints
	{
		/// <summary>
		/// 将 BlogItem 相关的 API 端点映射到路由构建器。
		/// </summary>
		/// <param name="routes">路由构建器</param>
		public static void MapBlogItemEndpoints(this IEndpointRouteBuilder routes)
		{
			var group = routes.MapGroup("/api/blogitem").WithTags(nameof(BlogItem));

			/// <summary>
			/// 返回所有博客项的列表。
			/// </summary>
			/// <param name="db">数据库上下文</param>
			/// <returns>所有博客项的列表</returns>
			group.MapGet("/", async (BlogItemContext db) =>
			{
				return await db.BlogItem.ToListAsync();
			})
			.WithName("GetAllBlogItems");

			/// <summary>
			/// 根据 ID 返回特定的博客项。
			/// </summary>
			/// <param name="Task<Results<Ok<BlogItem>"></param>
			/// <param name="id">博客项的 ID</param>
			/// <param name="db">数据库上下文</param>
			/// <returns>返回特定博客项的结果</returns>
			group.MapGet("/{id}", async Task<Results<Ok<BlogItem>, NotFound>> (int id, BlogItemContext db) =>
			{
				return await db.BlogItem.AsNoTracking()
					.FirstOrDefaultAsync(model => model.Id == id)
					is BlogItem model
						? TypedResults.Ok(model)
						: TypedResults.NotFound();
			})
			.WithName("GetBlogItemById");

			/// <summary>
			/// 根据 ID 更新特定的博客项。
			/// </summary>
			/// <param name="id">博客项的 ID</param>
			/// <param name="blogitem">更新后的博客项数据</param>
			/// <param name="db">数据库上下文</param>
			/// <returns>更新的结果</returns>
			group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, BlogItem blogitem, BlogItemContext db) =>
			{
				var affected = await db.BlogItem
					.Where(model => model.Id == id)
					.ExecuteUpdateAsync(setters => setters
					.SetProperty(m => m.Id, blogitem.Id)
					.SetProperty(m => m.Title, blogitem.Title)
					.SetProperty(m => m.Author, blogitem.Author)
					.SetProperty(m => m.Description, blogitem.Description)
					.SetProperty(m => m.Content, blogitem.Content)
					.SetProperty(m => m.CreatedAt, blogitem.CreatedAt)
					.SetProperty(m => m.UpdatedAt, blogitem.UpdatedAt)
			);

				return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
			})
			.WithName("UpdateBlogItem");

			/// <summary>
			/// 创建新的博客项。
			/// </summary>
			/// <param name="blogitem">新的博客项数据</param>
			/// <param name="db">数据库上下文</param>
			/// <returns>创建博客项的结果</returns>
			group.MapPost("/", async (BlogItem blogitem, BlogItemContext db) =>
			{
				db.BlogItem.Add(blogitem);
				await db.SaveChangesAsync();
				return TypedResults.Created($"/api/blogitem/{blogitem.Id}", blogitem);
			})
			.WithName("CreateBlogItem");

			/// <summary>
			/// 根据 ID 删除特定的博客项。
			/// </summary>
			/// <param name="id">博客项的 ID</param>
			/// <param name="db">数据库上下文</param>
			/// <returns>删除博客项的结果</returns>
			group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, BlogItemContext db) =>
			{
				var affected = await db.BlogItem
					.Where(model => model.Id == id)
					.ExecuteDeleteAsync();

				return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
			})
			.WithName("DeleteBlogItem");
		}
	}
}
