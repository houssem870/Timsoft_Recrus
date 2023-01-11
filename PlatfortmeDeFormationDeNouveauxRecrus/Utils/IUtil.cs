using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities.SignInRequest;

namespace PlatfortmeDeFormationDeNouveauxRecrus.Utils
{
    public interface IUtil
    {
        public bool verifyPassword(SignIn signIn);
        public bool verifyUserName(SignIn signIn);
        public string GenerateToken(SignIn signIn);
    }
}
