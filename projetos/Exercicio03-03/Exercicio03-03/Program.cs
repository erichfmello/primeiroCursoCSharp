using System;

namespace Exercicio03_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int dieser = 0;
            int x;

            x = int.Parse(Console.ReadLine());

            while (x != 4)
            {
                if (x == 1)
                {
                    alcool++;
                }
                else if (x == 2)
                {
                    gasolina++;
                } else if (x == 3)
                {
                    dieser++;
                } else
                {
                    Console.WriteLine("Código inválido");
                }

                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Disel: " + dieser);
        }
    }
}
