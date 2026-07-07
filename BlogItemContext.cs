using Microsoft.EntityFrameworkCore;
using SASTCsharpBlogPart.Models;
public class BlogItemContext(DbContextOptions<BlogItemContext> options) : DbContext(options)
{
    public DbSet<BlogItem> BlogItem { get; set; } = default!;
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<BlogItem>())
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = DateTime.UtcNow;
                entry.Entity.UpdatedAt = DateTime.UtcNow;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdatedAt = DateTime.UtcNow;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}
