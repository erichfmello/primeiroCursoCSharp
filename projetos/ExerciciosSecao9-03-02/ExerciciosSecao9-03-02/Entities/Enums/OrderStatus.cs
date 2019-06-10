using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosSecao9_03_02.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
