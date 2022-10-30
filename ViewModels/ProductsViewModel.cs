using NET_Framework.DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NET_Framework.ViewModels
{
    public class ProductsViewModel
    {
        public List<Product> Product { get; set; }
        public Company Company { get; set; }
    }
}