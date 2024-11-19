using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class NotificationService : INotificationService
    {
        public void SendNotification(int userId, string message)
        {
            Console.WriteLine($"Уведомление для пользователя {userId}: {message}");
        }
    }
}
