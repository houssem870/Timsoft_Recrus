using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Document_id { get; set; }
        public string Description { get; set; }
        public string PieceJointe { get; set; }


    }
}
