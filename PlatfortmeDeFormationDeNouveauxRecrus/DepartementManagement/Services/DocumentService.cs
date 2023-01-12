using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public class DocumentService : IDocumentService
    {
         
    private readonly IDocumentRepository _documentRepository;
        public DocumentService(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
        public Document AddDocument(DocumentDTO document)
        {
            return _documentRepository.AddDocument(document);
        }
        public string RemoveDocument(int id)
        {
            return _documentRepository.RemoveDocument(id);
        }

    }
}
