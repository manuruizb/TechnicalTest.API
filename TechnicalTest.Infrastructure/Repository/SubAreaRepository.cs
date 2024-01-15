using System.Data;
using TechnicalTest.Domain;

namespace TechnicalTest.Infrastructure
{
    public class SubAreaRepository : ISubAreaRepository
    {
        private readonly IDataAccessRepository _dataAccessRepository;
        public SubAreaRepository(IDataAccessRepository dataAccessRepository)
        {
            _dataAccessRepository = dataAccessRepository;
        }
        public async Task<IEnumerable<SubAreas>> GetSubAreasByArea(Guid AreaId)
        {
            return await _dataAccessRepository.Execute<SubAreas>("SP_GetSubAreasByArea", new { AreaId }, CommandType.StoredProcedure);
        }
    }
}
