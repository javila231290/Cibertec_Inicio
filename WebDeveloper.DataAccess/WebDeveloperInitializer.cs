using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var client = new List<Client>
            {
                new Client {Name="Cesar", LastName="Ninahuanca De Luna" },
                new Client {Name="Diego", LastName="Luna de Ninahuanca" },
                new Client {Name="Edgar", LastName="Villegas" },
                new Client {Name="Jesus", LastName="Avila" },
                new Client {Name="Lucho", LastName="Grados" },
            };

            client.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();
        }
    }
}
