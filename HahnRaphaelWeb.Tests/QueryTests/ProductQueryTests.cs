using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HahnRaphaelWeb.Domain.Entities;
using HahnRaphaelWeb.Domain.Queries;

namespace HahnRaphaelWeb.Tests.QueryTests
{
    [TestClass]
    public class ProductQueryTests
    {
        private List<Product> _products;

        public ProductQueryTests()
        {
            _products = new List<Product>();
            _products.Add(new Product("banana","that's a small description",1));
            _products.Add(new Product("table", "that's a small description", 20));
            _products.Add(new Product("chair", "that's a small description", 10));
            _products.Add(new Product("banana", "that's a small description", 1));
            _products.Add(new Product("sofa", "that's a small description", 200));
            _products.Add(new Product("laptop", "that's a small description",1800));
        }

        [TestMethod]
        public void ProductQuery_invalid()
        {
            var result = _products.AsQueryable()
                .Where(ProductQueries.GetAll("banana", "that's a small description", 1));
            Assert.AreEqual(false, result.Count() == 1);
        }

        [TestMethod]
        public void ProductQuery_valid()
        {
            var result = _products.AsQueryable()
                .Where(ProductQueries.GetAll("banana", "that's a small description", 1));
            Assert.AreEqual(2,result.Count());
        }
    }
}
