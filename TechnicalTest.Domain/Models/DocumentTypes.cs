namespace TechnicalTest.Domain
{
    public class DocumentTypes
    {
        public DocumentTypes()
        {
            DocumentType = string.Empty;
        }

        public Guid DocumentTypeId { get; set; }
        public string DocumentType { get; set; }
    }
}
