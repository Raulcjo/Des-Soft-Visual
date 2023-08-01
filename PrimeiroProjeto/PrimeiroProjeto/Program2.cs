using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Program2
    {
        //Caixa Eletronico
        //Usuário digita um valor e imprime quantas notas 
        //Considere que o caixa só tem nota de 100, 50, 20, 10, 5 e 2;
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor que deseja sacar: ");
            double saque = double.Parse(Console.ReadLine());
            if (saque > 100)
            {
                double resultado = saque - (100 * 1);
                if(resultado > 100)
                {
                    resultado -= (100 * 2);
                }
            }



        }
    }
}
