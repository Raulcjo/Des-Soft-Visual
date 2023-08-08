using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receber uma idade e acompanhante (bool)
             * só entra maior de 18 acompanhado.
             */

            /*
            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Acompanhado? false - Não | true - Sim");
            bool acompanhado = bool.Parse(Console.ReadLine());
            
            if(idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Acesso autorizado!");
            }
            else
            {
                Console.WriteLine("Acesso NÃO autorizado!");
            }
            Console.ReadLine();//Aguarda uma tecla para encerrar
            */

            /*
            Console.WriteLine("Digite um valor do saque: ");
            double saque = double.Parse(Console.ReadLine());
            int[] notas = new int[] { 100, 50, 20, 10, 5, 2 };
            for (int i = 0; i < notas.Length; i++)
            {
                int qtdNotas = (int) saque / notas[i];
                saque = saque -  (qtdNotas * notas[i]);
                Console.WriteLine("Notas de " + notas[i] + ": " + 
                    qtdNotas);
            }
            Console.ReadLine();//Aguarda uma tecla para encerrar
            */

            /*
            //Coloque na tela os multiplos de 3 entre o 1 até 100;
            int num = 0, limite = 100;
            for (int i = 0; i < num; i++)
            {
                num = num + 1;
                if (num % 3 == 0 && num < limite)
                {
                    Console.WriteLine("O número " + num + " é multiplo de 3");
                }
            } 

            //Outra maneira de fazer:
            while(num <= limite)
            {
              if (num % 3 == 0 && num < limite)
                {
                   Console.WriteLine("O número " + num + " é multiplo de 3");
                }
                num++;
            }
            Console.ReadLine();//Aguarda uma tecla para encerrar
            */

            /*
            Console.WriteLine("Digite um número que deseja saber a tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            int[] tabuada = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < tabuada.Length; i++)
            {
                Console.WriteLine("Tabuada do " + numero + " x " + tabuada[i] + " : " + numero * tabuada[i]);

            }
            Console.ReadLine();//Aguarda uma tecla para encerrar

            //Outra maneira de fazer: 
            Console.WriteLine("Digite um número que deseja saber a tabuada: ");
            int numero = int.Parse(Console.ReadLine());
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Tabuada do " + numero + " x " + tabuada[i] + " : " + numero * tabuada[i]);
            }
            while (i < 10);
            Console.ReadLine();//Aguarda uma tecla para encerrar
            */


        }
    }
}
