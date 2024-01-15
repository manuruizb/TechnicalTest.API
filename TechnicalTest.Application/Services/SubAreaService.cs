using TechnicalTest.Domain;

namespace TechnicalTest.Application
{
    public class SubAreaService
    {
        private readonly ISubAreaRepository _subAreaRepository;
        public SubAreaService(ISubAreaRepository subAreaRepository)
        {
            _subAreaRepository = subAreaRepository;
        }

        public async Task<Result<List<SubAreas>>> GetSubAreasByArea(Guid AreaId)
        {
            try
            {
                var res = await _subAreaRepository.GetSubAreasByArea(AreaId);
                return new Result<List<SubAreas>>()
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
