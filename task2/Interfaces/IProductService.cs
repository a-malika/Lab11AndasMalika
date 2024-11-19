using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product AddProduct(Product product);
    }
}
