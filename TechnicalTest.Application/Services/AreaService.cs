using TechnicalTest.Domain;

namespace TechnicalTest.Application
{
    public class AreaService
    {
        private readonly IAreaRepository _areaRepository;
        public AreaService(IAreaRepository areaRepository)
        {
            _areaRepository = areaRepository;
        }

        public async Task<Result<List<Areas>>> GetAreasByCountry(Guid CountryId)
        {
            try
            {
                var res = await _areaRepository.GetAreasByCountry(CountryId);
                return new Result<List<Areas>>()
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
