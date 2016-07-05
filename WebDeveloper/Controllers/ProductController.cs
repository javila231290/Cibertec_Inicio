using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Model;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Controllers
{
    public class ProductController : Controller
    {
        //private ProductData _product = new ProductData();
        private ProductData _product;
        // GET: Product

        public ProductController(ProductData product)
        {
            _product = product;
        }
        public ActionResult Index()
        {
            return View(_product.GetList());
        }

        public ActionResult Create()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.Add(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id = 0)
        {
            var product = _product.GetProductById(id);
            if (product == null)
                return RedirectToAction("Index");
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _product.Update(product);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id=0)
        {
            var product = _product.GetProductById(id);
            if (product == null)
                return RedirectToAction("Index");
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {            
            if (_product.Delete(product) > 0)
                return RedirectToAction("Index");
            return View();
        }
    }
}