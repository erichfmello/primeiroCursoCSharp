using System;

namespace ExercicioSecao6_03_02 {
    class Program {
        static void Main(string[] args) {
            string[] vet = Console.ReadLine().Split(' ');
            int m = int.Parse(vet[0]);
            int n = int.Parse(vet[1]);
            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++) {
                string[] vetMatris = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(vetMatris[j]);
                }
            }

            int numberSearch = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (numberSearch == mat[i, j]) {
                        if (i == 0) {
                            if (j == 0) {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Right: " + mat[i, j + 1]);
                                Console.WriteLine("Down: " + mat[i + 1, j]);
                            } else if (j <= n-1) {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Left: " + mat[i, j - 1]);
                                Console.WriteLine("Right: " + mat[i, j + 1]);
                                Console.WriteLine("Down: " + mat[i + 1, j]);
                            } else {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Left: " + mat[i, j - 1]);
                                Console.WriteLine("Down: " + mat[i + 1, j]);
                            }
                        } else if (i <= m-1) {
                            if (j == 0) {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Right: " + mat[i, j + 1]);
                                Console.WriteLine("Up: " + mat[i - 1, j]);
                                Console.WriteLine("Down: " + mat[i + 1, j]);
                            } else if (j <= n-1) {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Left: " + mat[i, j - 1]);
                                Console.WriteLine("Right: " + mat[i, j + 1]);
                                Console.WriteLine("Up: " + mat[i - 1, j]);
                                Console.WriteLine("Down: " + mat[i + 1, j]);
                            } else {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Left: " + mat[i, j - 1]);
                                Console.WriteLine("Up: " + mat[i - 1, j]);
                                Console.WriteLine("Down: " + mat[i + 1, j]);
                            }
                        } else {
                            if (j == 0) {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Right: " + mat[i, j + 1]);
                                Console.WriteLine("Up: " + mat[i - 1, j]);
                            } else if (j <= n-1) {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Left: " + mat[i, j - 1]);
                                Console.WriteLine("Right: " + mat[i, j + 1]);
                                Console.WriteLine("Up: " + mat[i - 1, j]);
                            } else {
                                Console.WriteLine("Position " + i + ", " + j);
                                Console.WriteLine("Left: " + mat[i, j - 1]);
                                Console.WriteLine("Up: " + mat[i - 1, j]);
                            }
                        }
                    }
                }
            }
        }
    }
}
