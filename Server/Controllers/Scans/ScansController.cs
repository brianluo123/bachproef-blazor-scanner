using BachelorproefBlazorScanner.Domain.Scans;
using BachelorproefBlazorScanner.Shared.Scans;
using Microsoft.AspNetCore.Mvc;

namespace BachelorproefBlazorScanner.Server.Controllers.Scans;

[ApiController]
[Route("api/[controller]")]
public class ScansController : ControllerBase
{
    private readonly IScanService _scanService;

    public ScansController(IScanService scanService)
    {
        _scanService = scanService;
    }

    [HttpGet]
    public async Task<IActionResult> GetScans()
    {
        var scans = await _scanService.GetScansAsync();
        return Ok(scans);
    }

    [HttpPost]
    public async Task<IActionResult> CreateScan([FromBody] Scan scan)
    {
        var newScan = await _scanService.CreateScanAsync(scan);
        return Ok(newScan);
    }
}
