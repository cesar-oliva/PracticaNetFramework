using DataLayer;
using NET_Framework.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NET_Framework.Services
{
    public class ProductRepository
    {
        public List<Product> GetAll() {
            
            using (var db = new MyContext())
            {
                return db.Products.ToList();
            }
        }

        internal void Create(Product model)
        {
            using(var db = new MyContext())
            {
                db.Products.Add(model);
                db.SaveChanges();
            }
        }
    }
}