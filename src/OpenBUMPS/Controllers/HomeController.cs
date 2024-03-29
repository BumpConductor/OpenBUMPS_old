﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace OpenBUMPS.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BUMPs()
        {
            ViewData["Message"] = "BUMPS page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
