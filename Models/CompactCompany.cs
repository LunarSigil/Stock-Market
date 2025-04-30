using System.Text.Json.Serialization;

namespace Stock_Market.Models
{
    public class CompactCompany
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}