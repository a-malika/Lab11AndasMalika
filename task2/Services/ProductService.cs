using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory11
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;
        private int _productIdCounter;
        public ProductService()
        {
            _products = new List<Product>();
            _productIdCounter = 1;
        }
        public List<Product> GetProducts()
        {
            return _products;
        }
        public Product AddProduct(Product product)
        {
            product.Id = _productIdCounter++;
            _products.Add(product);
            return product;
        }
    }
}
