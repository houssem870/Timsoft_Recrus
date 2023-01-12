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

           public Project RemoveProject(long IdProject)
           {
            return projectRepository.RemoveProject(IdProject);
        }

        public Project UpdateProject(long IdProject, string Description)
        {
            return projectRepository.UpdateProject(IdProject,Description);
        }
    }
}
