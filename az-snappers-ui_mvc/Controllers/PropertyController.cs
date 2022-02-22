using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using az_snappers_ui_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace az_snappers_ui_mvc.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            var lstProperty = new List<Property>(){ new Property { Id = "sdcasd", Address= "New Delhi, Delhi, Delhi"}, new Property { Id = "a22asd", Address = "3005 Merrywood Dr, EDison, NJ, 08817" }, new Property { Id = "jbj79", Address = "1 NYP, New York, 10004, USA" } };
            //ViewBag.Message = lstProperty;
            return View(lstProperty);
        }

        public IActionResult Details()
        {
            //var lstProperty = new List<Property>() { new Property { Id = "sdcasd", Address = "New Delhi, Delhi, Delhi" }, new Property { Id = "a22asd", Address = "3005 Merrywood Dr, EDison, NJ, 08817" }, new Property { Id = "jbj79", Address = "1 NYP, New York, 10004, USA" } };
            ////ViewBag.Message = lstProperty;
            //return View(lstProperty);
            return Redirect("~/");
        }


    }
}
