using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Services
{
    public class Departmentservice : IDepartmentService
    {
        private readonly IDepartmentRepository _departementRepository;
        public Departmentservice(IDepartmentRepository departementRepository)
        {
            _departementRepository = departementRepository;
        }

        public Departement AddDepartement(string DepartementName)
        {
            return _departementRepository.AddDepartement(DepartementName);
        }
    }
}
