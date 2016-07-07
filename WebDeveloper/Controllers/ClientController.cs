using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        //private ClientData _client = new ClientData();
        private ClientData _client;
        // GET: Client
        public ClientController(ClientData client)
        {
            _client = client;
        }

        public ActionResult Index()
        {           
            return View(_client.GetList());
        }

        public ActionResult Create()
        {
            return View(new Client());
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {                        
            if (ModelState.IsValid)
            {
                _client.Add(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            //Client client = _client.GetList().Where(s => s.ID == id).FirstOrDefault();
            var client = _client.GetClientById(id);
            if (client == null)
                return RedirectToAction("Index");
            return View(client);
        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _client.Update(client);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id = 0)
        {
            //Client client = _client.GetList().Where(s => s.ID == id).FirstOrDefault();
            var client = _client.GetClientById(id);
            if (client == null)
                return RedirectToAction("Index");
            return View(client);
        }

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if (_client.Delete(client) > 0)
                return RedirectToAction("Index");
            return View();
        }
    }
}