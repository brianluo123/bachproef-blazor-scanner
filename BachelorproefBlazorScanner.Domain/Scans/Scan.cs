namespace BachelorproefBlazorScanner.Domain.Scans;

public class Scan
{
    public string Barcode { get; set; }
    public string Zone { get; set; }
    public string Destination { get; set; }

    public Scan(string barcode, string zone, string destination)
    {
        Barcode = barcode;
        Zone = zone;
        Destination = destination;
    }
}
