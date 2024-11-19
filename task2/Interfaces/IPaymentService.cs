using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public interface IPaymentService
    {
        bool ProcessPayment(int orderId, decimal amount);
    }
}
