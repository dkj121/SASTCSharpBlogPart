using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SASTCsharpBlogPart.Models
{
	[Table("Blogs")]
	public class BlogItem
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		public string Title { get; set; } = string.Empty;
		[Required]
		public string Author { get; set; } = string.Empty;
		public string? Description { get; set; }
		[Required]
		public Uri Content { get; set; } = new Uri("https://example.com");
		[Required]
		public DateTime CreatedAt { get; set; }
		[Required]
		public DateTime UpdatedAt { get; set; }
	}
}
