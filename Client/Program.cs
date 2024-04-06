using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BachelorproefBlazorScanner.Client;
using BachelorproefBlazorScanner.Shared.Scans;
using BachelorproefBlazorScanner.Client.Pages.Shipments;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IScanService, ScanService>();

await builder.Build().RunAsync();
