using System.Text.Json.Serialization;

namespace Stock_Market.Models
{
    public class Company
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("branding")]
        public Branding Branding { get; set; }
        [JsonPropertyName("currency_name")]
        public string Currency { get; set; }
        [JsonPropertyName("market")]
        public string Market { get; set; }
        [JsonPropertyName("active")]
        public bool IsActive { get; set; }
    }
}