using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao10_02_02.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name + " $" + Price.ToString("F2");
        }
    }
}
