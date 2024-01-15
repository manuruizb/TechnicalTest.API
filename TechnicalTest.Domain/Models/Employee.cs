namespace TechnicalTest.Domain
{
    public class Employee
    {
        public Employee()
        {
            Names = string.Empty;
            LastName = string.Empty;
            DocumentNumber = string.Empty;
            DocumentType = string.Empty;
            Country = string.Empty;
            Area = string.Empty;
            SubArea = string.Empty;

        }

        public Guid EmployeeId { get; set; }
        public string Names { get; set; }
        public string LastName { get; set; }
        public string DocumentNumber { get; set; }
        public Guid DocumentTypeId { get; set; }
        public string DocumentType { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CountryId { get; set; }
        public string Country { get; set; }
        public Guid AreaId { get; set; }
        public string Area { get; set; }
        public Guid SubAreaId { get; set; }
        public string SubArea { get; set; }
        public string CreatedDateString { get; set; }
    }
}
