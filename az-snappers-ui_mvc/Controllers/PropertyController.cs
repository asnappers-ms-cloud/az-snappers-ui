using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace az_snappers_ui_mvc.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
