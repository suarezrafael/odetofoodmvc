﻿using OdeToFood.web.Models;
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
        public ActionResult Index()
        {
            var model = new GreatingViewModel() { Message = ConfigurationManager.AppSettings["message"]};
            return View(model);
        }
    }
}