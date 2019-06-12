using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao11_01_01.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
