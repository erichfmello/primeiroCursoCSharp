using System;

namespace AreaTrianguloOrientadaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Area de X = " + areaX.ToString("F4"));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4"));
            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            } else if(areaX == areaY)
            {
                Console.WriteLine("Areas iguais");
            } else
            {
                Console.WriteLine("Maior area: Y");
            }
        }
    }
}
