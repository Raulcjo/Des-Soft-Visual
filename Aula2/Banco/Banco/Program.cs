using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente();
            c1.titular = "012345678900";
            c1.saldo = 100.00;

            c1.Depositar(-1);
            Console.WriteLine("Saldo de " + c1.titular + " é " + c1.saldo);
            c1.Depositar(200);
            Console.WriteLine("Saldo de " + c1.titular + " é " + c1.saldo);
            c1.Sacar(350);
            Console.WriteLine("Saldo de " + c1.titular + " é " + c1.saldo);
            c1.Sacar(50);
            Console.WriteLine("Saldo de " + c1.titular + " é " + c1.saldo);

            Console.ReadLine();
        }
    }
}
