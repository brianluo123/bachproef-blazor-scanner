using BachelorproefBlazorScanner.Domain.Scans;
using BachelorproefBlazorScanner.Shared.Scans;
using System.Net.Http.Json;

namespace BachelorproefBlazorScanner.Client.Pages.Shipments;

public class ScanService : IScanService
{
    private readonly HttpClient client;
    private const string endpoint = "api/scans";

    public ScanService(HttpClient client)
    {
        this.client = client;
    }

    public async Task<IEnumerable<Scan>> GetScansAsync()
    {
        var response = await client.GetFromJsonAsync<IEnumerable<Scan>>(endpoint);
        return response!;
    }

    public async Task<Scan> CreateScanAsync(Scan scan)
    {
        var response = await client.PostAsJsonAsync(endpoint, scan);
        return await response.Content.ReadFromJsonAsync<Scan>();
    }
}
