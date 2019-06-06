using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao9_03_01.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
