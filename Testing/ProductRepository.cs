using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing
{
    public class ProductRepository : IProductRepository//make sure this class inherits from the IProductRepository interface.
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)//constructor.
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()//GetProducts()//used hotkey Ctrl + . to have VSC pprovide me with suggerstions that helped me to validate my impleemntation of the ProductRepository class, since it conforms to the IProductRepository interface, but it was showing a red squiggly line underneath,
        {//stubbed out method from the interface this class is deriving from.
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");//("Select * from products");//looks like SQL to me.... so why isn;t all fo the font capitalized?
        }
    }
}
