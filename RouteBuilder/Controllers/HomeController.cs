using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTest.Models;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewRoute()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult MyRoutes()
        {
            ViewData["Message"] = "My Routes page.";

            return View();
        }

        public IActionResult MyWalls()
        {
            ViewData["Message"] = "My Walls page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
