using OdeToFood.web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.web.Controllers
{
    public class GreatingController : Controller
    {
        // GET: Greating
        public ActionResult Index(string name)
        {
            var model = new GreatingViewModel() { 
                Message = ConfigurationManager.AppSettings["message"],
                Name = name ?? "no name"
            };
            
            return View(model);
        }
    }
}