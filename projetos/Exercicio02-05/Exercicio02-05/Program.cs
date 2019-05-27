using System;

namespace Exercicio02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabela = new string[,] { { "1", "Dog", "4.0" }, { "2", "X-Salada", "4.50" }, { "3", "X-Bacon", "5.00" }, { "4", "Torrada", "2.00" }, { "5", "Refri", "1.50" } };
            string[] vet;
            int codigo, quantidade;
            double total = 0;

            Console.WriteLine("Código\t\tNome\t\tPreço");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tabela[i, j] + "\t\t");
                }
                Console.WriteLine("");
            }

            vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            for (int i = 0; i < 5; i++)
            {
                if (codigo == int.Parse(tabela[i,0]))
                {
                    total = quantidade * double.Parse(tabela[i, 2]);
                    break;
                }
            }
            Console.WriteLine($"Total: R${total:F2}");
        }
    }
}
