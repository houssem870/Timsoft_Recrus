using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities;

namespace PlatfortmeDeFormationDeNouveauxRecrus.DepartementManagement.Entities
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Document_id { get; set; }
        public string Description { get; set; }
        public string PieceJointe { get; set; }
       
        public Project? Project  { get; set; }


    }
  
}  
