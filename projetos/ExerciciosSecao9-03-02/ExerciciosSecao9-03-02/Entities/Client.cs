﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao9_03_02.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return "Client: " + Name + "(" + BirthDate.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}
