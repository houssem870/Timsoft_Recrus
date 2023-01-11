using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities.SignInRequest;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.UserServices
{
    public interface IUserService
    {
        public string SignIn(SignIn signIn);
        public User AddUser(UserForm user);
        string GetMyName();
        public List<string> GetRoles();

        public User GetUserById(int id);
        public List<User> GetAllUsers();
        public User AddRoles(List<string> roles, int userId);

    }
}
