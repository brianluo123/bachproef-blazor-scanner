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

    [HttpPost]
    public async Task<IActionResult> CreateScan([FromBody] ScanDto.Create scanDto)
    {
        var scanId = await _scanService.CreateScanAsync(scanDto);
        return Ok(scanId);
    }
}
