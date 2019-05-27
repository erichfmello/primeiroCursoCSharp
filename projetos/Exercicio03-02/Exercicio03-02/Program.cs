using System;

namespace Exercicio03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            double x, y;
            x = double.Parse(vet[0]);
            y = double.Parse(vet[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }
                    else
                    {
                        Console.WriteLine("quarto");
                    }
                }
                else
                {
                    if (y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else
                    {
                        Console.WriteLine("terceiro");
                    }
                }

                vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0]);
                y = double.Parse(vet[1]);
            }
        }
    }
}
