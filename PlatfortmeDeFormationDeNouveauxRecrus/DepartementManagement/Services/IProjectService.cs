using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface IProjectService
    {
        public Project AddProject(string description);
        public Project RemoveProject(long IdProject);
        public Project UpdateProject(long IdProject, string Description);
    }
}
