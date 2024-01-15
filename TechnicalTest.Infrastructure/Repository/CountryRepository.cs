using System.Data;
using TechnicalTest.Domain;

namespace TechnicalTest.Infrastructure
{
    public class CountryRepository : ICountryRepository
    {
        private readonly IDataAccessRepository _dataAccessRepository;
        public CountryRepository(IDataAccessRepository dataAccessRepository)
        {
            _dataAccessRepository = dataAccessRepository;
        }
        public async Task<IEnumerable<Countries>> GetAllCountries()
        {
            return await _dataAccessRepository.Execute<Countries>("SP_GetAllCountries", null!, CommandType.StoredProcedure);
        }
    }
}
