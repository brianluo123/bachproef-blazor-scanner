namespace BachelorproefBlazorScanner.Shared.Scans;

public interface IScanService
{
    Task<int> CreateScanAsync(ScanDto.Create scan);
}
