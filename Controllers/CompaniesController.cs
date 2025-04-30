using Microsoft.AspNetCore.Mvc;
using Stock_Market.Models;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Stock_Market.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private static readonly string apiKey = "";         // INSERT POLYGON.IO API KEY
        private static List<CompactCompany> companiesShort = new List<CompactCompany>();

        [HttpGet]
        public async Task<IActionResult> GetCompaniesBySearch(string search)
        {
            string uri = @$"https://api.polygon.io/v3/reference/tickers?market=stocks&search={search}&order=asc&limit=100&sort=ticker&apiKey={apiKey}";
            Uri siteUri = new Uri(uri);
            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync(siteUri);

            CompactCompanies companies = await JsonSerializer.DeserializeAsync<CompactCompanies>(response.Content.ReadAsStream());

            JsonSerializerOptions jsonSerializerOptions = new()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            string result = JsonSerializer.Serialize(companies.Companies, jsonSerializerOptions);
            return Ok(result);
        }

        [HttpGet("{ticker}")]
        public async Task<IActionResult> GetCompany(string ticker)
        {
            string uri = @$"https://api.polygon.io/v3/reference/tickers/{ticker}?apiKey={apiKey}";
            Uri siteUri = new Uri(uri);
            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync(siteUri);

            CompanyWrapper foundCompany = await JsonSerializer.DeserializeAsync<CompanyWrapper>(response.Content.ReadAsStream());

            JsonSerializerOptions jsonSerializerOptions = new()
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            string result = JsonSerializer.Serialize(foundCompany.Company, jsonSerializerOptions);
            return Ok(result);

        }
    }
}