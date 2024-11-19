using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public interface IOrderService
    {
        Order CreateOrder(int userId, List<int> productIds);
        Order GetOrderStatus(int orderId);
    }
}
