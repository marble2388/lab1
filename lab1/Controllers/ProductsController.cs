using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab1.Models;

namespace lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            //create typed list of product using detials model
            var details = new List<Detail>();
            details.Add(new Detail { Name = "Laptop" });
            details.Add(new Detail { Name = "Tablet" });
            details.Add(new Detail { Name = "Desktop" });
            return View(details);
        }
        //GET: Product Details
        public ActionResult Details(string details)
        {
            ViewBag.Details = details;
            return View();
        }


    }
}