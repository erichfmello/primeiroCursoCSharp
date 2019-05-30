using System;

namespace ExercicioSecao6_02_01 {
    class Program {
        static void Main(string[] args) {
            Estudante[] estudantes = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int j = int.Parse(Console.ReadLine());
                estudantes[j] = new Estudante(j, nome, email);
                Console.WriteLine("");
            }

            for (int i = 0; i < 10; i++) {
                if (estudantes[i] != null) {
                    Console.WriteLine(estudantes[i].ToString());
                }
            }
        }
    }
}
