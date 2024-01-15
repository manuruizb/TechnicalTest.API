using System.Data;
using TechnicalTest.Domain;

namespace TechnicalTest.Infrastructure
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IDataAccessRepository _dataAccessRepository;
        public DocumentTypeRepository(IDataAccessRepository dataAccessRepository)
        {
            _dataAccessRepository = dataAccessRepository;
        }

        public async Task<IEnumerable<DocumentTypes>> GetAllDocuments()
        {
            return await _dataAccessRepository.Execute<DocumentTypes>("SP_GetAllDocuments", null!, CommandType.StoredProcedure);
        }
    }
}
