using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.Functions.Worker;
using System.Net;
using BachelorproefBlazorScanner.Shared.Scans;
using BachelorproefBlazorScanner.Domain.Scans;
using System.Text.Json;

namespace Api;

public class ScanFunction
{
    private readonly IScanService _scanService;

    public ScanFunction(IScanService scanService)
    {
        _scanService = scanService;
    }

    [Function("GetScans")]
    public HttpResponseData GetScans([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
    {
        var result = _scanService.GetScansAsync();
      
        var response = req.CreateResponse(HttpStatusCode.OK);
        response.WriteAsJsonAsync(result.Result);

        return response;
    }

    [Function("CreateScan")]
    public async Task<HttpResponseData> CreateScanAsync([HttpTrigger(AuthorizationLevel.Anonymous, "post")] HttpRequestData req, [FromBody] Scan scan)
    {
        var result = _scanService.CreateScanAsync(scan);

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.WriteAsJsonAsync(result.Result);

        return response;
    }

}
