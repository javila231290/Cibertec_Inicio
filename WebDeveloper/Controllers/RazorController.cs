using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.ActionFilters;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [LogActionFilter]
    [RoutePrefix("Razor")]
    public class RazorController : Controller
    {
        // GET: Razor
        [Route]
        public ActionResult Index()
        {
            var client = new List<Client>
            {
                new Client {ID=1, Name="Cesar", LastName="Ninahuanca De Luna", DateCreation = DateTime.Now},
                new Client {ID=2, Name="Diego", LastName="Luna de Ninahuanca", DateCreation = DateTime.Now },
                new Client {ID=3, Name="Edgar", LastName="Villegas", DateCreation = DateTime.Now },
                new Client {ID=4, Name="Jesus", LastName="Avila", DateCreation = DateTime.Now },
                new Client {ID=5, Name="Lucho", LastName="Grados", DateCreation = DateTime.Now },
                new Client {ID=6, Name="Lucho", LastName="Grados", DateCreation = DateTime.Now },
                new Client {ID=7, Name="Lucho", LastName="Grados", DateCreation = DateTime.Now },
                new Client {ID=8, Name="Lucho", LastName="Grados", DateCreation = DateTime.Now },
                new Client {ID=9, Name="Lucho", LastName="Grados", DateCreation = DateTime.Now },
                new Client {ID=10, Name="Lucho", LastName="Grados", DateCreation = DateTime.Now },
                new Client {ID=11, Name="Lucho", LastName="Grados", DateCreation = DateTime.Now },
            };
            return View(client);
        }

        public ActionResult Product()
        {
            var productData = new ProductData();
            return View(productData.GetFakeProducts());

        }

        [Route("EntryDate/{date:DateTime}")]
        public ActionResult EntryDate(DateTime date)
        {
            ViewBag.Date = date.ToShortDateString();
            return View();
        }

        [Route("Entry/{id:int}")]
        public string EntryId(int id)
        {
            return id.ToString();
        }
    }
}