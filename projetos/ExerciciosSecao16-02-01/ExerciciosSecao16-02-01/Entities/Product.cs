﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao16_02_01.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", $" + Price.ToString();
        }
    }
}
