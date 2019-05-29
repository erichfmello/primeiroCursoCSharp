using System;

namespace ExerciciosSecao6_01_02 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            double media = 0;

            Produtos[] p = new Produtos[n];
            
            for (int i = 0; i < n; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                p[i] = new Produtos { Nome = nome, Preco = preco };
            }

            for (int i = 0; i < n; i++) {
                media += p[i].Preco;
            }

            media = media / n;
            Console.WriteLine("Averange price = " + media.ToString("F2"));
        }
    }
}
