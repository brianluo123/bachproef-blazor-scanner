using BachelorproefBlazorScanner.Persistence;
using BachelorproefBlazorScanner.Services.Scans;
using BachelorproefBlazorScanner.Shared.Scans;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IScanService, ScanService>();

builder.Services.AddDbContext<ScannerDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseCors(corsPolicyBuilder => corsPolicyBuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyMethod());
app.UseRouting();

app.UseEndpoints(endpoints => {
    endpoints.MapHealthChecks("/api/healthcheck").AllowAnonymous();
    endpoints.MapControllers();
});

app.MapBlazorHub();
app.MapRazorPages();
app.MapFallbackToFile("index.html");

app.Run();
