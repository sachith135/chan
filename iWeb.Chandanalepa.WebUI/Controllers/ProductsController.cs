using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iWeb.Chandanalepa.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult All()
        {
            return View();
        }

        public ActionResult View(string link)
        {
            ViewBag.Title = "Chandanalepa Herble Beauty Cream";
            string guid = Guid.NewGuid().ToString().Replace("-", "") ;
            return View();
        }
    }
}