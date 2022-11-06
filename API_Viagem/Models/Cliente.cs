using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Viagem.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Informe o id do cliente")]
        [StringLength(50)]
        public String nome { get; set; }
        public String telefone { get; set; }

    }
}
