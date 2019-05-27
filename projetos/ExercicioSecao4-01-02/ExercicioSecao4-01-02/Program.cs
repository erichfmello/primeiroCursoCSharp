using System;

namespace ExercicioSecao4_01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1, f2;
            f1 = new Funcionarios();
            f2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            f2.Salario = double.Parse(Console.ReadLine());

            double media = (f1.Salario + f2.Salario) / 2;
            Console.WriteLine("Salario medio = " + media.ToString("F2"));
        }
    }
}
