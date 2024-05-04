using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace economus_cpp.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        public string email { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir este campo")]
        public string senha { get; set; }
    }
}
