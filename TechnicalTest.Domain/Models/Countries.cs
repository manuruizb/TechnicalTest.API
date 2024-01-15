namespace TechnicalTest.Domain
{
    public class Countries
    {
        public Countries()
        {
            Country = string.Empty;
        }

        public Guid CountryId { get; set; }
        public string Country { get; set; }
    }
}
