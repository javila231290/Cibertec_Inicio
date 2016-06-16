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

            var product = new List<Product>
            {
                new Product {Description="Zapatos Calimon", Category="Calzado", Price=310, Registry=DateTime.Now},
                new Product {Description="Casaca Cuerina", Category="Vestuario", Price=220, Registry=DateTime.Now},
                new Product {Description="Televisor Samsumg 35''", Category="Electro", Price=2500, Registry=DateTime.Now},
                new Product {Description="Pelota Adedos", Category="Deporte", Price=55, Registry=DateTime.Now},
                new Product {Description="Leche Gloria", Category="Abarrotes", Price=15, Registry=DateTime.Now},
            };

            client.ForEach(c => context.Clients.Add(c));
            product.ForEach(c => context.Products.Add(c));
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                
            }            
        }
    }
}
