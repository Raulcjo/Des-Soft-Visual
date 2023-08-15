using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cliente
    {
        public string Nome { get; set; }
        //public int Cpf { get; set; }
        public string Email { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public string GerarRelatorio()
        {
            return this.Nome + " - " + this.Email;
        }

    }
}
