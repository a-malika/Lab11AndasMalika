using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Products { get; set; }
        public string Status { get; set; }
        public Order(int id, int userId, List<Product> products, string status)
        {
            Id = id;
            UserId = userId;
            Products = products;
            Status = status;
        }
    }
}
