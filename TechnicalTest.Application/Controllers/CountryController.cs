using Microsoft.AspNetCore.Mvc;

namespace TechnicalTest.Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly CountryService _countryService;
        public CountryController(CountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet]
        [Route("GetAllCountries")]
        public async Task<IActionResult> GetAllCountries()
        {
            var res = await _countryService.GetAllCountries();
            return new OkObjectResult(res);
        }
    }
}
