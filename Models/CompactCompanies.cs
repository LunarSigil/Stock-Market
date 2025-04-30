using System.Text.Json.Serialization;

namespace Stock_Market.Models
{
    public class CompactCompanies
    {
        [JsonPropertyName("results")]
        public List<CompactCompany> Companies { get; set; }
    }
}