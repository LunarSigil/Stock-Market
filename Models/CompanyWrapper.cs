using System.Text.Json.Serialization;

namespace Stock_Market.Models
{
    public class CompanyWrapper
    {
        [JsonPropertyName("results")]
        public Company Company { get; set; }
    }
}