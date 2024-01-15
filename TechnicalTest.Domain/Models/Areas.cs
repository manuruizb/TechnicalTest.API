namespace TechnicalTest.Domain
{
    public class Areas
    {
        public Areas()
        {
            Area = string.Empty;
        }
        public Guid AreaId { get; set; }
        public string Area { get; set; }
        public Guid CountryId { get; set; }
    }
}
