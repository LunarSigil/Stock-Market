using System.Text.Json.Serialization;

namespace Stock_Market.Models
{
    public class Branding
    {
        [JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }
        [JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }
    }
}