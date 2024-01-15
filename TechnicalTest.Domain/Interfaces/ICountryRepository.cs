namespace TechnicalTest.Domain
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Countries>> GetAllCountries();
    }
}
