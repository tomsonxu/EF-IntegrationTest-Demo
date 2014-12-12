using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_IntegrationTest_Demo.Core
{
    public interface IProductRepository
    {
        void addProduct(Product product);
        List<Product> getProducts();
    }
}
