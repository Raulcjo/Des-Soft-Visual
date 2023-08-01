using System; //"using" é a mesma coisa que "import" em java
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Olá mundo! Projeto Visual Studio!");
            //Console.WriteLine("A aplicação já terminou, aperte ENTER para finalizar");
            //Console.ReadLine();

            Console.WriteLine("Digite um número: ");
            //cast
            double valorS = 12.9;
            int valorInt = (int)valorS;

            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("O número " + valor + " é par");
            }
            else
            {
                Console.WriteLine("O número " + valor + " é impar");
            }

            Console.ReadLine();
        }
    }
}
