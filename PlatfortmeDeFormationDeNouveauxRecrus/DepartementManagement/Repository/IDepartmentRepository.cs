using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface IDepartmentRepository
    {
        Departement GetCurrentDepartement();
        public Departement AddDepartement(string DepartementName);
        public Departement UpdateDepartement(Departement departement);
        public Departement RemoveDepartement(Departement departement);
        public Departement GetDepartementById(int id);
    }
}
