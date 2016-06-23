using System;
using System.Collections.Generic;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ProductData : BaseDataAccess<Product>
    {

        public Product GetProductById (int? id)
        {
            //return GetList().Where(s => s.ID == id).FirstOrDefault();
            using (var dbContext = new WebContextDb())
            {
                //return dbContext.Clients.FirstOrDefault(x => x.ID == id);
                return dbContext.Products.Find(id);
            }
        }

        public List<Product> GetFakeProducts()
        {
            var product = new List<Product>
            {
                new Product { ID=1, Description="Cerveza Cristal", Category = "Bebida", Price = 3.0, Registry=DateTime.Now },
                new Product { ID=2, Description="Cerveza Pilsen", Category = "Bebida", Price = 0.0, Registry = null },
                new Product { ID=3, Description="Cerveza Brahma", Category = "Bebida", Price = 0.0, Registry=DateTime.Now },
                new Product { ID=4, Description="Cerveza Franca", Category = "Bebida", Price = 1.5, Registry = null },
                new Product { ID=5, Description="Cerveza Cusqueña", Category = "Bebida", Price = 4.5, Registry=DateTime.Now }
            };
            return product;
        }
    }
}
