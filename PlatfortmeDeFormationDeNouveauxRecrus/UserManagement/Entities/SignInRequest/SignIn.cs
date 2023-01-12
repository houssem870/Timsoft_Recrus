using System.Data.SqlTypes;
using System.ComponentModel.DataAnnotations;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities.SignInRequest
{
    public class SignIn
    {
        [Required]
        public  string  UserName { get; set; } 
        [Required]
        public string Password { get; set; }    

    }
}
