using System;

namespace Exercicio03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.WriteLine("Senha inválida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
