using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Result> Results { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
