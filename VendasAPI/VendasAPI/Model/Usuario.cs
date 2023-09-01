using System.ComponentModel.DataAnnotations;

namespace VendasAPI.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage = "E-mail é obrigatório")]
        public string Email { get; set; }
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Password { get; set; }


    }
}
