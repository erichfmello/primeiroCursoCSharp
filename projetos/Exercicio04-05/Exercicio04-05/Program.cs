using System;

namespace Exercicio04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 0; i < n; i++)
            {
                if (n == 0)
                {
                    fatorial = 1;
                } else
                {
                    fatorial = fatorial * (n - i);
                }
            }

            Console.WriteLine(fatorial);
        }
    }
}
