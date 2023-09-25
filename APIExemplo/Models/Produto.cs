using System.ComponentModel.DataAnnotations;

namespace APIExemplo.Models
{
    public class Produto
    {
        [Key]
        [Required (ErrorMessage="Id deve ser preenchido")]
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        [Required (ErrorMessage="Preço deve ser preenchido")]
        public double Preco { get; set; }
        public int QtnMin { get; set; }
        public string Categoria { get; set; }
        public double Tamanho { get; set;}
        public string Cor { get; set; }
    }
}
