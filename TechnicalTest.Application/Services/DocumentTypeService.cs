using TechnicalTest.Domain;

namespace TechnicalTest.Application
{
    public class DocumentTypeService
    {
        private readonly IDocumentTypeRepository _documentTypeRepository;

        public DocumentTypeService(IDocumentTypeRepository documentTypeRepository)
        {
            _documentTypeRepository = documentTypeRepository;
        }

        public async Task<Result<List<DocumentTypes>>> GetAllDocuments() {
            try
            {
                var res = await _documentTypeRepository.GetAllDocuments();
                return new Result<List<DocumentTypes>>()
                {
                    Data = res.ToList(),
                    Success = true
                };
            }
            catch (Exception e)
            {
                throw new ArgumentException(message: e.Message);
            }
        }
    }
}
