﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcMovie.Controllers
    {
        public class HelloWorldController : Controller
        {
            public ActionResult Index()
            {
                return View();
            }

            // Passing parameter information from the URL to the controller
            public ActionResult Welcome(string name, int numTimes = 1)
            {
                ViewBag.Message = "Hello " + name;
                ViewBag.NumTimes = numTimes;

                return View();
            }
        }
    }