using System;

namespace Exercicio04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = 0, y = 0;
            double z;

            for(int i = 0; i < n; i++)
            {
                z = double.Parse(Console.ReadLine());
                if(z >= 10 && z <= 20)
                {
                    x++;
                } else
                {
                    y++;
                }
            }

            Console.WriteLine(x + " in");
            Console.WriteLine(y + " out");
        }
    }
}
