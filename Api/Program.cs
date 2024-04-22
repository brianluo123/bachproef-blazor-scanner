using BachelorproefBlazorScanner.Persistence;
using BachelorproefBlazorScanner.Services.Scans;
using BachelorproefBlazorScanner.Shared.Scans;
using Microsoft.Azure.Functions.Worker;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services => {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddScoped<IScanService, ScanService>();
        services.AddDbContext<ScannerDbContext>(options =>
        {
            options.UseSqlServer("Server=tcp:mysqlserverblazorscanner.database.windows.net,1433;Initial Catalog=BachelorproefBlazorScanner;Persist Security Info=False;User ID=brianluo123;Password=sqlDB99*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        });

    })
    .Build();

host.Run();
