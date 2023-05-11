namespace koishowweb.Models
{
    public class Vat
    {
        public string VatId { get; set; }
        public string VatName { get; set; } = string.Empty;
        public double RequestedTemperature { get; set; }
        public double Capacity { get; set; }
    }
}
