namespace Stock_Market.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string? LogoURL { get; set; }
        public string Currency { get; set; }
        public string Market { get; set; }
        public bool IsActive { get; set; }
    }
}