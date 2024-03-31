using BachelorproefBlazorScanner.Domain.Scans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BachelorproefBlazorScanner.Persistence.Configurations.Scans;

public class ScanConfiguration : IEntityTypeConfiguration<Scan>
{
    public void Configure(EntityTypeBuilder<Scan> builder)
    {
        builder.ToTable("scans");
        builder.HasKey(x => x.Id);
    }
}
