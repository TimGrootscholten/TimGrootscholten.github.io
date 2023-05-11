namespace koishowweb.Models
{
    public class Sensor
    {
        public string SensorId { get; set; } = string.Empty;
        public double Offset { get; set; }
        public string ColorCode { get; set; } = string.Empty;
        public string SensorName { get; set; } = string.Empty;
        public Vat Vat { get; set; } = new();
    }
}
