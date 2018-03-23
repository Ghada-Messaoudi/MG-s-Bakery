using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BakeryFP.Models;

namespace BakeryFP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(Session["ShoppingCart"] == null){
                Session["ShoppingCart"] = new List<Product>();
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}