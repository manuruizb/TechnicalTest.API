using Microsoft.AspNetCore.Mvc;

namespace TechnicalTest.Application
{
    [Route("[controller]")]
    [ApiController]
    public class SubAreaController : ControllerBase
    {
        private readonly SubAreaService _subAreaService;
        public SubAreaController(SubAreaService subAreaService)
        {
            _subAreaService = subAreaService;
        }

        [HttpGet]
        [Route("GetSubAreasByArea")]
        public async Task<IActionResult> GetSubAreasByArea([FromQuery] Guid AreaId)
        {
            var res = await _subAreaService.GetSubAreasByArea(AreaId);
            return new OkObjectResult(res);
        }
    }
}
