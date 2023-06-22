using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaula7
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.WriteLine("Insira um valor ");

            valor = int.Parse(Console.ReadLine());

            if (valor > 1.00)
            {
                Console.WriteLine("\nValor está correto!");

            }
            Console.WriteLine("\n escolha uma opção\n Café expresso: \n Capuccino: \n Mocaccino\n Água quente: ");
            Console.ReadLine();

            if (valor > 1.00 && < 7.00)


                Console.ReadKey();

    }
}
