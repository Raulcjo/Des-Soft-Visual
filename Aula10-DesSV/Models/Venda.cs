using System.ComponentModel.DataAnnotations;

namespace Aula8_DesSV.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        //Data de agora como default
        public DateTime DataVenda { get; set; }
        public double Total { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
