using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface IDocumentRepository
    {
        Document GetCurrentDocumentt();
        public Document AddDocument(DocumentDTO documentForm);
        public Document UpdateDocument(Document document);
        public Document RemoveDocument(Document document);
        public Document GetDocumenttById(int id);
    }
}
