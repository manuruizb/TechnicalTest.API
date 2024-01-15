using Microsoft.AspNetCore.Mvc;

namespace TechnicalTest.Application
{
    [Route("[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly AreaService _areaService;
        public AreaController(AreaService areaService)
        {
            _areaService = areaService;
        }

        [HttpGet]
        [Route("GetAreasByCountry")]
        public async Task<IActionResult> GetAreasByCountry([FromQuery] Guid CountryId)
        {
            var res = await _areaService.GetAreasByCountry(CountryId);
            return new OkObjectResult(res);
        }
    }
}
