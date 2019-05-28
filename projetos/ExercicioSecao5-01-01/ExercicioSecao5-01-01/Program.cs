using System;

namespace ExercicioSecao5_01_01 {
    class Program {
        static void Main(string[] args) {
            int numeroConta;
            string nomeConta;
            char haveraDepositoInicial;
            double depositoInicial;

            Console.Write("Entre o número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            nomeConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            haveraDepositoInicial = char.Parse(Console.ReadLine());
            Banco banco;

            if(haveraDepositoInicial == 's') {
                Console.Write("Entre com o valor de depósito inicial: R$");
                depositoInicial = double.Parse(Console.ReadLine());
                banco = new Banco(numeroConta, nomeConta, depositoInicial);
                Console.WriteLine(banco.ToString());
            } else {
                banco = new Banco(numeroConta, nomeConta);
                Console.WriteLine(banco.ToString());
            }

            Console.Write("Entre um valor para depósito: R$");
            banco.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine(banco.ToString());

            Console.Write("Entre com um valor para saque: R$");
            banco.Saque(double.Parse(Console.ReadLine()));
            Console.WriteLine(banco.ToString());
        }
    }
}
