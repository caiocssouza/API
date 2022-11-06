using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Viagem.Models
{
    [Table("Destino")]
    public class Destino
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Informe o id do cliente")]
        [StringLength(50)]
        public String estado { get; set; }
        public String pais { get; set; }

    }
}
