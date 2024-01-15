namespace TechnicalTest.Domain
{
    public interface IAreaRepository
    {
        Task<IEnumerable<Areas>> GetAreasByCountry(Guid CountryId);
    }
}
