using az_snappers_ui_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace az_snappers_ui_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PropertyModel p  =  new PropertyModel()
            {
                Address = "3005 , merrywood dr, edison",
                Id = 1,
                ImageUrls = new List<string>() { "https://www.w3schools.com/bootstrap/la.jpg" ,"https://www.w3schools.com/bootstrap/chicago.jpg" ,"https://www.w3schools.com/bootstrap/ny.jpg" },
                Latitude = "",
                Longitude = "",
                Zipcode = ""

            };
            ViewBag.Message = p;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
