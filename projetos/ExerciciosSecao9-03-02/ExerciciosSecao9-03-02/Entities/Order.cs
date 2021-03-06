﻿using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosSecao9_03_02.Entities.Enums;

namespace ExerciciosSecao9_03_02.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItens = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItens.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItens.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem orderItem in OrderItens)
            {
                sum += orderItem.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem orderItem in OrderItens)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));

            return sb.ToString();
        }
    }
}
