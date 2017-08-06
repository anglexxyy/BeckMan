using BeckMan.Del;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BeckMan.WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        BeckManDBContext dbContext = new BeckManDBContext();

        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            return dbContext.Product;
        }

        // GET: api/Product/5
        public Product Get(int id)
        {
            return dbContext.Product.FirstOrDefault(p => p.ID == id);
        }

        // POST: api/Product
        public void Post([FromBody]Product product)
        {
            dbContext.Product.Add(product);
            dbContext.SaveChanges();
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
