using System;

namespace ExercicioSecao4_02_02 {
    class Program {
        static void Main(string[] args) {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: $");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: $");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + funcionario.ToString());

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados: " + funcionario.ToString());
        }
    }
}
