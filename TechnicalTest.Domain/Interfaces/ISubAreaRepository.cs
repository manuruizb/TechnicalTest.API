namespace TechnicalTest.Domain
{
    public interface ISubAreaRepository
    {
        Task<IEnumerable<SubAreas>> GetSubAreasByArea(Guid AreaId);
    }
}
