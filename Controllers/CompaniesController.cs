using Microsoft.AspNetCore.Mvc;
using Stock_Market.Models;

namespace Stock_Market.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private static readonly string apiKey = "";
        private static List<CompactCompany> companiesShort = new List<CompactCompany>();

        [HttpGet]
        public async Task<IActionResult> GetCompanies(string search)
        {
            string searchTickersUri = @$"https://api.polygon.io/v3/reference/tickers?market=stocks&search={search}&order=asc&limit=100&sort=ticker&apiKey={apiKey}";
            Uri siteUri = new Uri(searchTickersUri);
            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync(siteUri);

            return Ok(response.Content.ReadAsStringAsync());

        }

    }
}