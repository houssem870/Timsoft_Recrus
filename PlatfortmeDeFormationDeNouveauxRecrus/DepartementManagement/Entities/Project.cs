
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProject { get; set; }
        public string? Description { get; set; }

        [NotMapped]
        [JsonIgnore]
        public List<Document> Documents { get; set; }
    }

}

