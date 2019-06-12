using System;
using ExerciciosSecao10_03_01.Entities.Enums;
using ExerciciosSecao10_03_01.Entities;
using System.Collections.Generic;

namespace ExerciciosSecao10_03_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1} data:");
                Console.Write("Retangle os Circle (r/c)? ");
                string typeOfShape = Console.ReadLine();

                if(typeOfShape == "r")
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes.Add(new Retangle(color, width, height));
                } else if(typeOfShape == "c")
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color color = Enum.Parse<Color>(Console.ReadLine());
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    shapes.Add(new Circle(color, radius));
                }
                else
                {
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape areas in shapes)
            {
                Console.WriteLine(areas.Area().ToString("F2"));
            }
        }
    }
}
