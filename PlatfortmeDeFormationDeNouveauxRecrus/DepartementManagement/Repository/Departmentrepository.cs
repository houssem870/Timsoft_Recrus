using PlatfortmeDeFormationDeNouveauxRecrus.DataBase;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Repository
{
    public class Departmentrepository : IDepartmentRepository 
    {
        private readonly DataBaseContext dataBase;

        public Departmentrepository(DataBaseContext dataBase)
        {
            this.dataBase = dataBase;
        }

        public Departement AddDepartement(string DepartementName)
        {
            Departement dbDepartement = new Departement();
            dbDepartement.DepartementName = DepartementName;
            dbDepartement.Users = new List<User> { };
            dataBase.Add(dbDepartement);
            dataBase.SaveChanges();
            return dbDepartement;
        }

        public Departement GetCurrentDepartement()
        {
            throw new NotImplementedException();
        }

        public Departement GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        public Departement GetDepartementById(int id)
        {
            throw new NotImplementedException();
        }

        public Departement RemoveDepartement(Departement departement)
        {
            throw new NotImplementedException();
        }

        public Departement UpdateDepartement(Departement departement)
        {
            throw new NotImplementedException();
        }

    }
}
