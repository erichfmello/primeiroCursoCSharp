using System;

namespace Exercicio04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] media;
            media = new double[n];

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0]);
                double b = double.Parse(vet[1]);
                double c = double.Parse(vet[2]);

                media[i] = (a * 2 + b * 3 + c * 5) / 10;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0:F1}", media[i]);
            }
        }
    }
}
