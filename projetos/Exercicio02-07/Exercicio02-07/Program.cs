using System;

namespace Exercicio02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double x, y;
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

            if (x == 0 || y == 0)
            {
                if (x == y)
                {
                    Console.WriteLine("Origem");
                } else if (x == 0)
                {
                    Console.WriteLine("Eixo x");
                } else
                {
                    Console.WriteLine("Eixo y");
                }
            } else if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("Q1");
                } else
                {
                    Console.WriteLine("Q4");
                }
            } else
            {
                if (y > 0)
                {
                    Console.WriteLine("Q2");
                }
                else
                {
                    Console.WriteLine("Q3");
                }
            }
        }
    }
}
