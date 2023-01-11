using PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities
{
    public class Departement
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Departement_id { get; set; }
        public string DepartementName { get; set; }

        [JsonIgnore]
        public List<User> Users { get; set; }


    }
}
