using EF_IntegrationTest_Demo.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_IntegrationTest_Demo_Tests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestInitialize]
        public void setup()
        {
            MyContext context = new MyContext();
            context.Database.Initialize(true);  //very important, it makes db initialize before every test!!
        }

        [TestMethod]
        public void Test_GetAddProduct()
        {
            MyContext context = new MyContext();
            ProductRepository productRepository = new ProductRepository(context);
            productRepository.addProduct(new Product { Name = "p3", Description = "desc3" });
            Assert.AreEqual(2, productRepository.getProducts().Count);
        }

        [TestMethod]
        public void Test_GetProducts()
        {
            MyContext context = new MyContext();
            ProductRepository productRepository = new ProductRepository(context);
            Assert.AreEqual(1, productRepository.getProducts().Count);
        }

    }
}
