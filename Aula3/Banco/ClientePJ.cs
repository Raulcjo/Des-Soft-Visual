using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ClientePJ : Cliente //Herança simples
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        //Recebe o atributo herdado `nome` e referência o atributo na `classe pai` -> Cliente.
        ClientePJ(string nome, string cnpj) : base(nome) //'base' é 'super' em C#
        {
            Cnpj = cnpj;
        }

        public virtual string GerarRelatorio() //Sobrescrita de método da classe Cliente 
        {
            return this.RazaoSocial + " - " + this.Email;
        }

    }
}
