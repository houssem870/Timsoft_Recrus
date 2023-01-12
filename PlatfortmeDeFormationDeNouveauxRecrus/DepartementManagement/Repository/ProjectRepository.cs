using Microsoft.AspNetCore.Mvc;
using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DataBaseContext dataBase;
        public ProjectRepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Project AddProject(string description)
        {
            Project proj = new Project();
            proj.Description = description;
            dataBase.Projects.Add(proj);
            dataBase.SaveChanges();
            return proj;
        }


       public Project RemoveProject(long IdProject)
        {
            var proj = dataBase.Projects.Where(p => p.IdProject == IdProject).FirstOrDefault();
            if (proj == null)
            {
                throw new Exception("Project Not found !!");
            }

            dataBase.Projects.Remove(proj);
            dataBase.SaveChanges();
            return proj;
        } 

        public Project UpdateProject(long IdProject, string Description)
        {
            // proj = await dataBase.Projects.FirstOrDefaultAsync(p => p.IdProject == IdProject);
            var proj = dataBase.Projects.Where(p => p.IdProject == IdProject).FirstOrDefault() ;
            if (proj == null)
            {
                throw new Exception("Project Not found !!");
            }
            proj.Description = Description;
            
            dataBase.Update(proj);
            dataBase.SaveChanges();
            return proj;


        }
    }
}
