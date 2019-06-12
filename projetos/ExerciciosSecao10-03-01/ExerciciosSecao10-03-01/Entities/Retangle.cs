using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosSecao10_03_01.Entities.Enums;

namespace ExerciciosSecao10_03_01.Entities
{
    class Retangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
