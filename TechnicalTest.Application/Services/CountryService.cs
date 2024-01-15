using TechnicalTest.Domain;

namespace TechnicalTest.Application
{
    public class CountryService
    {
        private readonly ICountryRepository _countryRepository;
        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<Result<List<Countries>>> GetAllCountries()
        {
            try
            {
                var res = await _countryRepository.GetAllCountries();
                return new Result<List<Countries>>()
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
