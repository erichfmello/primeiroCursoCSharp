using System;

namespace ExercicioDeFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int quartos;
            double preco;
            string[] vet;

            Console.WriteLine("Entre com o nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu ultimo nome, idade e altura(Mesma linha)");
            vet = Console.ReadLine().Split(' ');
            string sobreNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("\n\nVocê digitou");
            Console.WriteLine($"{nome}");
            Console.WriteLine(quartos);
            Console.WriteLine($"{preco:F2}");
            Console.WriteLine(sobreNome);
            Console.WriteLine(idade);
            Console.WriteLine($"{altura:F2}");
        }
    }
}
