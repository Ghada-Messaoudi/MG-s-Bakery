using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryFP.Models;

namespace BakeryFP.Controllers
{
    public class SaleController : Controller
    {
        private BakeryEntities db = new BakeryEntities();

        // GET: Sale
        public ActionResult Index()
        {
            List<Product> products = (List<Product>)Session["ShoppingCart"];
            return View(products);
        }
    }
}