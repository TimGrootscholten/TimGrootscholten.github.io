namespace koishowweb.Models
{
    public class Temperatures
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public Sensor Sensor { get; set; } = new();
        public double Temperature { get; set; }
    }
}
