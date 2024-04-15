using BachelorproefBlazorScanner.Domain.Scans;
using BachelorproefBlazorScanner.Persistence;
using BachelorproefBlazorScanner.Shared.Scans;
using Microsoft.EntityFrameworkCore;

namespace BachelorproefBlazorScanner.Services.Scans;

public class ScanService : IScanService
{
    private readonly ScannerDbContext _scannerDbContext;

    public ScanService(ScannerDbContext scannerDbContext)
    {
        _scannerDbContext = scannerDbContext;
    }

    public async Task<IEnumerable<Scan>> GetScansAsync()
    {
        var query = _scannerDbContext.Set<Scan>().AsQueryable();
        return await query.ToListAsync();
    }

    public async Task<Scan> CreateScanAsync(Scan scan)
    {
        _scannerDbContext.Set<Scan>().Add(scan);
        await _scannerDbContext.SaveChangesAsync();
        return scan;
    }
}
