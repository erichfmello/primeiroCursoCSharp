using System;

namespace Exercicio01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1;
            string[] peca2;
            int codigoPeca1, quantidadePeca1, codigoPeca2, quantidadePeca2;
            double precoPeca1, precoPeca2, valorAPagar;

            peca1 = Console.ReadLine().Split(' ');
            peca2 = Console.ReadLine().Split(' ');

            codigoPeca1 = int.Parse(peca1[0]);
            quantidadePeca1 = int.Parse(peca1[1]);
            precoPeca1 = double.Parse(peca1[2]);

            codigoPeca2 = int.Parse(peca2[0]);
            quantidadePeca2 = int.Parse(peca2[1]);
            precoPeca2 = double.Parse(peca2[2]);

            valorAPagar = quantidadePeca1 * precoPeca1 + quantidadePeca2 * precoPeca2;

            Console.WriteLine($"Valor a pagar: R${valorAPagar:F2}");
        }
    }
}
