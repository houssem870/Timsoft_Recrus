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


       /* public async Task<string> RemoveProject(long IdProject)
        {
            var proj = await dataBase.Projects.FindAsync(IdProject);
            if (proj == null)
                return "Project notfound in the database";
            dataBase.Projects.Remove(proj);
            await dataBase.SaveChangesAsync();
            return "Success";
        }

        public async Task<string> UpdateProject(long IdProject, string Description)
        {
            // proj = await dataBase.Projects.FirstOrDefaultAsync(p => p.IdProject == IdProject);
            var proj = await dataBase.Projects.FindAsync(IdProject);
            if (proj == null)
                return "Project notfound in the database";
            proj.Description = Description;
            await dataBase.SaveChangesAsync();
            return "Success";


        }*/
    }
}
