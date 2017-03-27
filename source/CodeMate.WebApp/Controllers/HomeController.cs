﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeMate.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page1.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page1.";

            return View();
        }
    }
}