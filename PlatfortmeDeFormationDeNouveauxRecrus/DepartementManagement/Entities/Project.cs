using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdProject { get; set; }
        public string? Description { get; set; }
    }
}

