using System;

namespace Exercicio02_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet;
            int a, b, duracao;

            vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a > b)
            {
                duracao = (24 - a) + b;
            } else if (a == b)
            {
                duracao = 24;
            } else
            {
                duracao = b - a;
            }

            Console.WriteLine($"O jogo durou {duracao} hora(s)");
        }
    }
}
