using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }
        public Project AddProject(string description)
        {
            return projectRepository.AddProject(description);
        }

     /*   public Task<string> RemoveProject(long IdProject)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateProject(long IdProject, string Description)
        {
            throw new NotImplementedException();
        }*/
    }
}
