using Microsoft.AspNetCore.Mvc;

namespace TechnicalTest.Application
{
    [Route("[controller]")]
    [ApiController]
    public class DocumentTypeController : ControllerBase
    {
        private readonly DocumentTypeService _documentTypeService;
        public DocumentTypeController(DocumentTypeService documentTypeService)
        {
            _documentTypeService = documentTypeService;
        }

        [HttpGet]
        [Route("GetAllDocuments")]
        public async Task<IActionResult> GetAllDocuments()
        {
            var res = await _documentTypeService.GetAllDocuments();
            return new OkObjectResult(res);
        }
    }
}
