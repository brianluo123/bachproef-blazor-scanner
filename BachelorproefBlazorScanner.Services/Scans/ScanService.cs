using BachelorproefBlazorScanner.Domain.Scans;
using BachelorproefBlazorScanner.Persistence;
using BachelorproefBlazorScanner.Shared.Scans;

namespace BachelorproefBlazorScanner.Services.Scans;

public class ScanService : IScanService
{
    private readonly ScannerDbContext _scannerDbContext;

    public ScanService(ScannerDbContext scannerDbContext)
    {
        _scannerDbContext = scannerDbContext;
    }

    public async Task<int> CreateScanAsync(ScanDto.Create scanDto)
    {
        Scan scan = new (scanDto.Barcode, scanDto.Zone, scanDto.Destination);
        _scannerDbContext.Set<Scan>().Add(scan);
        await _scannerDbContext.SaveChangesAsync();
        return scan.Id;
    }
}
