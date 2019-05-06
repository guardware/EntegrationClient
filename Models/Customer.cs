namespace IdenfitGuardware.Client.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal Phone { get; set; }
        public string Email { get; set; }
        public short Gmt { get; set; }
        public string ZipCode { get; set; }
        public string TaxOffice { get; set; }
        public long? TaxNo { get; set; }
        public string ExecutiveName { get; set; }
        public decimal? Phone2 { get; set; }
    }
}
