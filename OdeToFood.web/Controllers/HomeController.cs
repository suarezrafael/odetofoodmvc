using OdeToFood.Data.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.web.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData _db;
        public HomeController(IRestaurantData db)
        {
            _db = new InMemoryRestaurantData();
        }
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}