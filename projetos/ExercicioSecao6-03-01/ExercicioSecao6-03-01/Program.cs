using System;

namespace ExercicioSecao6_03_01 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];
            int negativeNumbers = 0;

            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' '); ;
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(vet[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        negativeNumbers++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + negativeNumbers);
        }
    }
}
