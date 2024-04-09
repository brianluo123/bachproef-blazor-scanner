using BachelorproefBlazorScanner.Domain.Scans;

namespace BachelorproefBlazorScanner.Shared.Scans;

public interface IScanService
{
    Task<IEnumerable<Scan>> GetScansAsync();
    Task<Scan> CreateScanAsync(Scan scan);
}
