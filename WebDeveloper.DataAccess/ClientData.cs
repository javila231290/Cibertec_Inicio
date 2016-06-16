using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ClientData : BaseDataAccess<Client>
    {
        
        public Client GetClientById (int? id)
        {
            using (var dbContext = new WebContextDb())
            {
                return GetList().Where(s => s.ID == id).FirstOrDefault();
            }
        }
    }
}
