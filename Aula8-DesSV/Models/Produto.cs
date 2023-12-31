﻿using System.ComponentModel.DataAnnotations;

namespace Aula8_DesSV.Models
{
    public class Produto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome é obrigatório")]
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
    }
}
