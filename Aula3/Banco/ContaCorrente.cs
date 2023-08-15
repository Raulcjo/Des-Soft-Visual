using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }
        //prop + <TAB>*2
        int Numero { get; set; }
        int Agencia { get; set; }
        public double Saldo
        {
            get { return Saldo; } 
            set { Saldo = value; }
        }


        public bool Sacar(double valor)
        {
            if(Saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }

        public bool Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
                return true;
            }
            else
            {
                Console.WriteLine("O valor do dépósito de ser maior que 0.00");
                return false;
            }
        }

        public bool Pix(double valor, ContaCorrente contaDestino)
        {

            if (contaDestino != null && Sacar(valor))
            {
                return contaDestino.Depositar(valor);
            }
            return false;
        }

    }
}
