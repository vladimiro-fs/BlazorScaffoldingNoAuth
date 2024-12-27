namespace BlazorScaffoldingNoAuth.Data
{
    using Microsoft.EntityFrameworkCore;

    public class BlazorScaffoldingNoAuthContext : DbContext
    {
        public BlazorScaffoldingNoAuthContext (DbContextOptions<BlazorScaffoldingNoAuthContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorScaffoldingNoAuth.Models.Category> Category { get; set; } = default!;
        public DbSet<BlazorScaffoldingNoAuth.Models.Product> Product { get; set; } = default!;
    }
}
