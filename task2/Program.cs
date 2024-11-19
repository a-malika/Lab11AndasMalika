using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    class Program
    {
        static void Main()
        {
            IUserService userService = new UserService();
            IProductService productService = new ProductService();
            IPaymentService paymentService = new PaymentService();
            INotificationService notificationService = new NotificationService();
            IOrderService orderService = new OrderService(productService, paymentService, notificationService);

            var user = userService.Register("test_user", "password");
            Console.WriteLine($"Пользователь зарегистрирован: {user.Username} (ID: {user.Id})");

            productService.AddProduct(new Product(0, "Laptop", 1200));
            productService.AddProduct(new Product(0, "Smartphone", 800));

            var products = productService.GetProducts();
            var order = orderService.CreateOrder(user.Id, products.Select(p => p.Id).ToList());
            Console.WriteLine($"Заказ создан: {order.Id}, Статус: {order.Status}");

            var status = orderService.GetOrderStatus(order.Id);
            Console.WriteLine($"Статус заказа {status.Id}: {status.Status}");
        }
    }
}
