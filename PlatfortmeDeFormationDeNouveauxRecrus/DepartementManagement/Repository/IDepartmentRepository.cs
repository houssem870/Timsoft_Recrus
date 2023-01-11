using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public interface IDepartmentRepository
    {
        public Departement AddDepartement(string DepartementName);
        public Departement UpdateDepartementById(Departement departement ,int DepId);
        public string RemoveDepartement(int id);
        public Departement GetDepartementById(int id);
    }
}
