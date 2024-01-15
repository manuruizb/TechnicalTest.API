using System.Data;
using TechnicalTest.Domain;

namespace TechnicalTest.Infrastructure
{
    public class AreaRepository : IAreaRepository
    {
        private readonly IDataAccessRepository _dataAccessRepository;
        public AreaRepository(IDataAccessRepository dataAccessRepository)
        {
            _dataAccessRepository = dataAccessRepository;
        }
        public async Task<IEnumerable<Areas>> GetAreasByCountry(Guid CountryId)
        {
            return await _dataAccessRepository.Execute<Areas>("SP_GetAreasByCountry", new { CountryId }, CommandType.StoredProcedure);
        }
    }
}
