using MySql.EntityFrameworkCore.Extensions;
using System.ComponentModel.DataAnnotations;

namespace VendasAPI.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string nome { get; set; }
        public string descricao { get; set; }
        [Required(ErrorMessage = "Código de barras é obrigatório")]
        public int codigoBarras { get; set; }
        [Required(ErrorMessage="Preço é obrigatório")]
        public double? preco { get; set; }  
        public int estoque {  get; set; }

        

    }
}
