using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

using az_snappers_ui_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace az_snappers_ui_mvc.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult Index()
        {
            var url = "https://az2-property-service.azurewebsites.net/property";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            var lstProperty = new List<Property>();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                lstProperty = JsonConvert.DeserializeObject<List<Property>>(result);
            }

            //Console.WriteLine(httpResponse.StatusCode);


            //var lstProperty = new List<Property>() { new Property { Id = 1, Address = "New Delhi, Delhi, Delhi" }, new Property { Id = 2, Address = "3005 Merrywood Dr, EDison, NJ, 08817" }, new Property { Id = 3, Address = "1 NYP, New York, 10004, USA" } };
            //ViewBag.Message = lstProperty;
            return View(lstProperty);
        }

        public IActionResult Details()
        {

            //var lstProperty = new List<Property>() { new Property { Id = "sdcasd", Address = "New Delhi, Delhi, Delhi" }, new Property { Id = "a22asd", Address = "3005 Merrywood Dr, EDison, NJ, 08817" }, new Property { Id = "jbj79", Address = "1 NYP, New York, 10004, USA" } };
            ////ViewBag.Message = lstProperty;
            //return View(lstProperty);
            return Redirect("https://az-snappers-ui-housedetail.azurewebsites.net/Home.aspx");
        }


    }
}
