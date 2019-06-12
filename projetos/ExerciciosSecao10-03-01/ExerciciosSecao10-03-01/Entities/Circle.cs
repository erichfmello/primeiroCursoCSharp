using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosSecao10_03_01.Entities.Enums;

namespace ExerciciosSecao10_03_01.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
