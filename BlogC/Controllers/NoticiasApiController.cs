using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticiasApiController : ControllerBase
    {

        [HttpGet("GetApiNetCore")]
        public async Task<IActionResult> GetProductAsync()
        {
            string url = "https://gnews.io/api/v4/search?q=covid&token=0a3b039204dab7cc14e30831ba2c9537";
            string apiResponse = "";
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return Ok(apiResponse);
        }
    }
}
