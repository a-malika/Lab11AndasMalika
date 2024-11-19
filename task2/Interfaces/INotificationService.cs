using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public interface INotificationService
    {
        void SendNotification(int userId, string message);
    }
}
