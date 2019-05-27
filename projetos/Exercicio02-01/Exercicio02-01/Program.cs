using System;

namespace Exercicio02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Negativo");
            } else
            {
                Console.WriteLine("Não Negativo");
            }
        }
    }
}
