using BachelorproefBlazorScanner.Domain.Common;

namespace BachelorproefBlazorScanner.Domain.Scans;

public class Scan : Entity
{
    private string barcode = default!;
    public string Barcode { get; set; }

    private string zone = default!;
    public string Zone { get; set; }

    private string destination = default!;
    public string Destination { get; set; }

    private Scan() { }

    public Scan(string barcode, string zone, string destination)
    {
        Barcode = barcode;
        Zone = zone;
        Destination = destination;
    }
}
