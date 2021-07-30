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
            _db = db;
        }
        public ActionResult Index()
        {
            var model = _db.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Restaurant Register ASP NET MVC5 Application. Injection Dependency Autofac.Mvc5";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contato para entrevista:";

            return View();
        }

        public ActionResult Account()
        {
            ViewBag.Message = "AccountTeste.";

            return View();
        }

    }
}