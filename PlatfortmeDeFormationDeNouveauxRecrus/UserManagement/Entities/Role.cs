using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PlatfortmeDeFormationDeNouveauxRecrus.UserManagement.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        [NotMapped]
        [JsonIgnore]
        public ICollection<User>? Users { get; set; }
    }
}
