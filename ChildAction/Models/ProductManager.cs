using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChildAction.Models
{
    public class ProductManager
    {
        public static List<Product> GetProducts()
        {


            List<Product> products = new List<Product> {

                new Product {Name = "Proj 1", ProductId=2, Price= 10 },
                new Product {Name = "Prod 2", ProductId=2, Price= 1023 },
                new Product {Name = "Prod 3", ProductId=2, Price= 101 }


            };
            return products;
        }
    }
}