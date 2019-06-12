using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosSecao10_03_01.Entities.Enums;

namespace ExerciciosSecao10_03_01.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
