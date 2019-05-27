using System;

namespace Exercicio04_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] vet;

            for(int i = 0; i < n; i++)
            {
                vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0]);
                double b = double.Parse(vet[1]);
                if (b == 0)
                {
                    Console.WriteLine("divisão impossivel");
                } else
                {
                    Console.WriteLine(a / b);
                }
            }
        }
    }
}
