using System;

namespace ExercicioSecao4_03_01 {
    class Program {
        static void Main(string[] args) {
            double cotacaoDoDolar, quantidadeDeDolares;
            double valorASerPago;

            Console.Write("Qual a cotação do dólar? R$");
            cotacaoDoDolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar? $");
            quantidadeDeDolares = double.Parse(Console.ReadLine());

            valorASerPago = ConversorDeMoeda.ValorASerPago(cotacaoDoDolar, quantidadeDeDolares);

            Console.WriteLine("Valor a ser pago em reais = R$" + valorASerPago.ToString("F2"));
        }
    }
}
