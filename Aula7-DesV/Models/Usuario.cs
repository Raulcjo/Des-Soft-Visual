using System.ComponentModel.DataAnnotations;

namespace VendasAPI.Models
{
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Nome { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatório")]
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        [Required(ErrorMessage = "Senha é obrigatória")]
        public string? Password { get; set; }


    }
}
