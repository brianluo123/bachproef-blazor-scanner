using Microsoft.EntityFrameworkCore;

namespace BachelorproefBlazorScanner.Persistence;

public class ScannerDbContext : DbContext
{
    public ScannerDbContext(DbContextOptions<ScannerDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ScannerDbContext).Assembly);
    }
}
