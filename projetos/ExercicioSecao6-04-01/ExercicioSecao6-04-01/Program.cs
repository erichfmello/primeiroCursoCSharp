using System;
using System.Collections.Generic;

namespace ExercicioSecao6_04_01 {
    class Program {
        static void Main(string[] args) {
            HashSet<int> conjuntoCursosA = new HashSet<int>();
            HashSet<int> conjuntoCursosB = new HashSet<int>();
            HashSet<int> conjuntoCursosC = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < n; i++) {
                conjuntoCursosA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < n; i++) {
                conjuntoCursosB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos? ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < n; i++) {
                conjuntoCursosC.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> novo = new HashSet<int>();
            novo.UnionWith(conjuntoCursosA);
            novo.UnionWith(conjuntoCursosB);
            novo.UnionWith(conjuntoCursosC);

            Console.WriteLine("Total de alunos: " + novo.Count);
        }
    }
}
