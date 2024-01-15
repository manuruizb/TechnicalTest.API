namespace TechnicalTest.Domain
{
    public class SubAreas
    {
        public SubAreas()
        {
            SubArea = string.Empty;
        }

        public Guid SubAreaId { get; set; }
        public string SubArea { get; set; }
        public Guid AreaId { get; set; }
    }
}
