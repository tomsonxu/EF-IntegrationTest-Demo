using EF_IntegrationTest_Demo.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_IntegrationTest_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DbInitializer());
            MyContext context = new MyContext();
            IProductRepository p = new ProductRepository(context);
            Console.WriteLine("product count: " + p.getProducts().Count);
            Console.ReadLine();
        }
    }
}
