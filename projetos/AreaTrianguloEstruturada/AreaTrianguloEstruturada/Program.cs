using System;

namespace AreaTrianguloEstruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo x");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo y");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area de x = " + areaX.ToString("F4"));
            Console.WriteLine("Area de y = " + areaY.ToString("F4"));
            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            } else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}
