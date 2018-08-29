using ClientDev.Models;
using ClientDev.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientDev
{

    public class ProductView
    {

        public Int32 ProductID { get; set; }
        public String Name { get; set; }
        public Decimal Price { get; set; }
        public String Category { get; set; }

        public ProductView()
        { }

        public ProductView(Product product)
        {
            this.ProductID = product.ProductID;
            this.Name = product.Name;
            this.Price = product.Price;
            this.Category = product.Category;
        }

        public Product ToProduct()
        {
            return new Product()
            {
                ProductID = this.ProductID,
                Name = this.Name,
                Price = this.Price,
                Category = this.Category,
            };
        }
    }

    public class ProductController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<ProductView> Get()
        {
            return new Repository().Products.Select(item => new ProductView(item));
        }

        // GET api/<controller>/5
        public ProductView Get(Int32 id)
        {
            return new Repository().Products.Where(item => item.ProductID == id).Select(item => new ProductView(item)).FirstOrDefault();
        }

        // POST api/<controller>
        public void Post([FromBody]ProductView value)
        {
            new Repository().AddProduct(value.ToProduct());
        }

        // PUT api/<controller>/5
        public void Put(Int32 id, [FromBody]ProductView value)
        {
            Repository repo = new Repository();
            Product current = repo.Products.Where(item => item.ProductID == id).FirstOrDefault();
            if (current == null)
            {
                new Repository().SaveProduct(value.ToProduct());
            }
        }

        // DELETE api/<controller>/5
        public void Delete(Int32 id)
        {
            Repository repository = new Repository();
            var value = repository.Products.Where(item => item.ProductID == id).FirstOrDefault();
            if (value != null)
            {
                repository.DeleteProduct(value);
            }
        }
    }
}