using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
