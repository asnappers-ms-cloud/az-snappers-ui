using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace az_snappers_ui_mvc.Models
{
    public class Property
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Zipcode { get; set; }
        public List<string> ImageUrls { get; set; }
        public string Price { get; set; }

        public int bed { get; set; }
        public int bath { get; set; }
        public int area { get; set; }
    }
}
