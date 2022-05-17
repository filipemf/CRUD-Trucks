using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CRUD_Caminhoes.Models
{
    public class Trucks
    {
        [Key]

        [DisplayName("ID")]
        public int truckId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [DisplayName("Nome")]
        public string truckName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [DisplayName("Descição")]
        public string truckDescription { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [DisplayName("Data de Criação")]
        public string truckCreationDate { get; set; }

        
    }
}
