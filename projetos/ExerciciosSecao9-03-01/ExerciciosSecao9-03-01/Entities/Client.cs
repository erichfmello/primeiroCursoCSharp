﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao9_03_01.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; private set; }

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
            return "Client: " + Name + " (" + BirthDate.Date.ToString() + ") - " + Email;
        }
    }
}
