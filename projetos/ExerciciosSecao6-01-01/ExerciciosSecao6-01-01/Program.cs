using System;

namespace ExerciciosSecao6_01_01 {
    class Program {
        static void Main(string[] args) {
            double[] alturas;
            double media = 0;
            int n;
            n = int.Parse(Console.ReadLine());
            alturas = new double[n];

            for (int i = 0; i < n; i++) {
                alturas[i] = double.Parse(Console.ReadLine());
                media += alturas[i];
            }
            media = media / n;
            Console.WriteLine("Altura média: " + media.ToString("F2"));
        }
    }
}
