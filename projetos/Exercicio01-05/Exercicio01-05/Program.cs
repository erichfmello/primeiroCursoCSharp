using System;

namespace Exercicio01_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            double a, b, c;
            double triangulo, circulo, trapezio, quadrado, retangulo;

            valores = Console.ReadLine().Split(' ');
            a = double.Parse(valores[0]);
            b = double.Parse(valores[1]);
            c = double.Parse(valores[2]);

            triangulo = a * c / 2;
            circulo = 3.14159 * Math.Pow(c, 2);
            trapezio = (a + b) * c / 2;
            quadrado = Math.Pow(b, 2);
            retangulo = a * b;

            Console.WriteLine($"Trianculo: {triangulo:F3}");
            Console.WriteLine($"Circulo: {circulo:F3}");
            Console.WriteLine($"Trapezio: {trapezio:F3}");
            Console.WriteLine($"Quadrado: {quadrado:F3}");
            Console.WriteLine($"Retangulo: {retangulo:F3}");
        }
    }
}
