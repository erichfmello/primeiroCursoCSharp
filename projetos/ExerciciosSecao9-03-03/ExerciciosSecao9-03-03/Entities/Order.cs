using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosSecao9_03_03.Entities.Enums;
using ExerciciosSecao9_03_03.Entities;

namespace ExerciciosSecao9_03_03.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client;

        public Order()
        {
        }

        public Order(Client client, OrderStatus status)
        {
            Moment = DateTime.Now;
            Client = client;
            Status = status;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItems.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem orderItem in OrderItems)
            {
                sum += orderItem.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem orderItem in OrderItems)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine("Total price: " + Total().ToString("F2"));

            return sb.ToString();
        }
    }
}
