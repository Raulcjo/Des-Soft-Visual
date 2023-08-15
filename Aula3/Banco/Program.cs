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
            //Criar cliente 1 e 2, e conta 1 e 2
            ContaCorrente c1 = new ContaCorrente();
            Cliente cliente1 = new Cliente();
            Console.WriteLine("Digite o nome do Cliente: ");
            cliente1.Nome = Console.ReadLine();
            c1.Titular = cliente1;
            Console.WriteLine("Digite o Saldo inicial da conta: ");
            c1.Saldo = double.Parse(Console.ReadLine());

            ContaCorrente c2 = new ContaCorrente();
            Cliente cliente2 = new Cliente();
            Console.WriteLine("Digite o nome do Clinete 2: ");
            cliente2.Nome = Console.ReadLine();
            c2.Titular = cliente2;
            Console.WriteLine("Digite o Saldo da conta 2: ");
            c2.Saldo = double.Parse(Console.ReadLine());

            //Testar PIX
            Console.WriteLine("Digite o valor que será transferido do Cliente 1: " + c1.Titular.Nome 
                + " para o cliente 2: " + c2.Titular.Nome );
            double valor = double.Parse(Console.ReadLine());
            if(c1.Pix(valor, c2))
            {
                Console.WriteLine("Pix realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("ERRO! Pix NÂO foi realizado!");
            }

            Console.WriteLine("O Saldo do Cliente 1 é " + c1.Saldo);
            Console.WriteLine("O Saldo do Cliente 2 é " + c2.Saldo);

            Console.ReadLine();
        }
    }
}
