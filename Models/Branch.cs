using System;

namespace IdenfitGuardware.Client.Models
{
    public class Branch  {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int Radius { get; set; }
        public decimal Phone { get; set; }
        public string Email { get; set; }
        public string ExecutiveName { get; set; }
        public decimal? Phone2 { get; set; }
        public short Gmt { get; set; }
        public string ZipCode { get; set; }
    }
}
