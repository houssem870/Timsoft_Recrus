using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities.DTO;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;
using static PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository.DocumentRepository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class DocumentRepository : IDocumentRepository
    {

        private readonly DataBaseContext dataBase;

        public DocumentRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Document AddDocument(DocumentDTO document)
        {
            Document dbDocument = new Document();
            dbDocument.Description = document.Description;
            dbDocument.PieceJointe = document.PieceJointe;
            dataBase.Add(dbDocument);
            dataBase.SaveChanges();
            return dbDocument;
        }



        public Document GetCurrentDocumentt()
        {
            throw new NotImplementedException();
        }

        public Document GetDocumenttById(int id)
        {
            throw new NotImplementedException();
        }

        public Document RemoveDocument(Document document
)
        {
            throw new NotImplementedException();
        }



        public Document UpdateDocument(Document document)
        {
            throw new NotImplementedException();
        }


    }

}
