﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Movie()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Customers()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}