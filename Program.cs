using System;

namespace gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string refrigerante;
            Console.Write("Digite refrigerante: ");
            refrigerante = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine($"{refrigerante}!!!".ToUpper());
            Console.Write("\n");
            Console.WriteLine("Precione enter para sair");
            Console.ReadKey();
        }
    }
}
