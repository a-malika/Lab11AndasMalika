using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class PaymentService : IPaymentService
    {
        public bool ProcessPayment(int orderId, decimal amount)
        {
            Console.WriteLine($"Платеж для заказа {orderId} на сумму {amount} выполнен.");
            return true;
        }
    }
}
