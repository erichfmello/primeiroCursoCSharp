using System;

namespace Exercicio04_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}\t{Math.Pow(i, 2)}\t{Math.Pow(i, 3)}");
            }
        }
    }
}
