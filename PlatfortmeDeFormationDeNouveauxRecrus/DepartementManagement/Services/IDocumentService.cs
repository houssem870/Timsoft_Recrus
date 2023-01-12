using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface IDocumentService
    {
        public Document AddDocument(DocumentDTO document);
        public string RemoveDocument(int id);
    }
}
