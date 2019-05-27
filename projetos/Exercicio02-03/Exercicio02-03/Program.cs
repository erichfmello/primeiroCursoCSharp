using System;

namespace Exercicio02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet;
            int a, b;
            vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a < b)
            {
                if (b % a == 0)
                {
                    Console.WriteLine("São Multiplos");
                } else
                {
                    Console.WriteLine("Não são multiplos");
                }
            } else
            {
                if (a % b == 0)
                {
                    Console.WriteLine("São Multiplos");
                }
                else
                {
                    Console.WriteLine("Não são multiplos");
                }
            }
        }
    }
}
