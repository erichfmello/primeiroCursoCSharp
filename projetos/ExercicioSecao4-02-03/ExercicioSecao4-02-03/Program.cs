using System;

namespace ExercicioSecao4_02_03 {
    class Program {
        static void Main(string[] args) {
            Boletim boletim = new Boletim();

            Console.Write("Nome do aluno: ");
            boletim.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            boletim.nota1 = double.Parse(Console.ReadLine());
            boletim.nota2 = double.Parse(Console.ReadLine());
            boletim.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine(boletim.ToString());
        }
    }
}
