using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface IProjectRepository
    {
        public Project AddProject(string description);
         public Project RemoveProject(long IdProject); 
        public Project UpdateProject(long IdProject, string Description);

    }
}