using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class OrderService : IOrderService
    {
        private readonly IProductService _productService;
        private readonly IPaymentService _paymentService;
        private readonly INotificationService _notificationService;
        private readonly List<Order> _orders;
        private int _orderIdCounter;
        public OrderService(IProductService productService, IPaymentService paymentService, INotificationService notificationService)
        {
            _productService = productService;
            _paymentService = paymentService;
            _notificationService = notificationService;
            _orders = new List<Order>();
            _orderIdCounter = 1;
        }
        public Order CreateOrder(int userId, List<int> productIds)
        {
            var products = _productService.GetProducts().Where(p => productIds.Contains(p.Id)).ToList();
            if (!products.Any())
            {
                throw new Exception("Выбранные товары не найдены.");
            }
            var order = new Order(_orderIdCounter++, userId, products, "Created");
            decimal totalAmount = products.Sum(p => p.Price);
            if (_paymentService.ProcessPayment(order.Id, totalAmount))
            {
                order.Status = "Paid";
                _notificationService.SendNotification(userId, "Ваш заказ успешно оплачен.");
            }
            else
            {
                order.Status = "Payment Failed";
                _notificationService.SendNotification(userId, "Платеж не прошел.");
            }
            _orders.Add(order);
            return order;
        }
        public Order GetOrderStatus(int orderId)
        {
            return _orders.FirstOrDefault(o => o.Id == orderId) ?? new Order(orderId, -1, null, "Not Found");
        }
    }
}
