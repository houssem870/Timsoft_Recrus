using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities.SignInRequest;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;
using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Repository;
using PlatfortmeDeFormationDeNouveauxRecrus.Utils;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUtil _util;

        public UserService(IUserRepository userRepository , IUtil util)
        {
            _userRepository = userRepository;
            _util = util;   
        }


        public User AddRoles(List<string> roles, int userId)
        {
            return _userRepository.AddRoles(roles, userId);
        }

        public User AddUser(UserForm user)
        {
            return _userRepository.AddUser(user);
        }

        public string SignIn(SignIn signIn)
        {
            if (_util.verifyUserName(signIn) == false)
            {
                return "wrong userName";
            }

            if (_util.verifyPassword(signIn) == false)
            {
                return "wrong password ";
            }
            
                var token = _util.GenerateToken(signIn);
                return token;

            

        }
        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public string GetMyName()
        {
            throw new NotImplementedException();
        }

        public List<string> GetRoles()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
