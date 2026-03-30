using Testing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();//GetProducts();
    }
}
