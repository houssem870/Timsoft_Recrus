using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public interface IDepartmentService
    {
        public Departement AddDepartement(string DepartementName);
        public string RemoveDepartement(int id);

        public Departement updateDepartmentById(Departement departement, int idDep);
    }
}
