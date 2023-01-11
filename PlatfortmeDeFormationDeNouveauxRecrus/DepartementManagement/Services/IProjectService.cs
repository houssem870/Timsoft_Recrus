using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface IProjectService
    {
        public Project AddProject(string description);
       // public Task<string> RemoveProject(long IdProject);
        //public Task<string> UpdateProject(long IdProject, string Description);
    }
}
