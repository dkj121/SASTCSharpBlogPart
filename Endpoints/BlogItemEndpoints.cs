using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SASTCsharpBlogPart.Models;

namespace SASTCsharpBlogPart.Endpoints
{
	public static class BlogItemEndpoints
	{
		public static void MapBlogItemEndpoints(this IEndpointRouteBuilder routes)
		{
			var group = routes.MapGroup("/api/blogitem").WithTags(nameof(BlogItem));

			group.MapGet("/", async (BlogItemContext db) =>
			{
				return await db.BlogItem.ToListAsync();
			})
			.WithName("GetAllBlogItems");

			group.MapGet("/{id}", async Task<Results<Ok<BlogItem>, NotFound>> (int id, BlogItemContext db) =>
			{
				return await db.BlogItem.AsNoTracking()
					.FirstOrDefaultAsync(model => model.Id == id)
					is BlogItem model
						? TypedResults.Ok(model)
						: TypedResults.NotFound();
			})
			.WithName("GetBlogItemById");

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

			group.MapPost("/", async (BlogItem blogitem, BlogItemContext db) =>
			{
				db.BlogItem.Add(blogitem);
				await db.SaveChangesAsync();
				return TypedResults.Created($"/api/blogitem/{blogitem.Id}", blogitem);
			})
			.WithName("CreateBlogItem");

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
