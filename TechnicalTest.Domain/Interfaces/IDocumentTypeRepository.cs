namespace TechnicalTest.Domain
{
    public interface IDocumentTypeRepository
    {
        Task<IEnumerable<DocumentTypes>> GetAllDocuments();
    }
}
