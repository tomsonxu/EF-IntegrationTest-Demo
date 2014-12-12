using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_IntegrationTest_Demo.Core
{
    public class MyContext : DbContext
    {
        public MyContext() : base("TestDB") { }
        public DbSet<Product> Products { get; set; }
    }
}
