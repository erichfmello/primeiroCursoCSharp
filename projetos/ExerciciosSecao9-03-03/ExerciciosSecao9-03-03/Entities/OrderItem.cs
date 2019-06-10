using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosSecao9_03_03.Entities;

namespace ExerciciosSecao9_03_03.Entities
{
    class OrderItem
    {
        public int Quantity { get; private set; }
        public double Price { get; private set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Price.ToString("F2") + " Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2");
        }
    }
}
