namespace BachelorproefBlazorScanner.Shared.Scans;

public abstract class ScanDto
{
    public class Index
    {
        public string Barcode { get; set; }
        public string Zone { get; set; }
        public string Destination { get; set; }
    }

    public class Create
    {
        public string Barcode { get; set; }
        public string Zone { get; set; }
        public string Destination { get; set; }
    }
}
