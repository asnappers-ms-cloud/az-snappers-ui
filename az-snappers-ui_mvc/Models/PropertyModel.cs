using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace az_snappers_ui_mvc.Models
{
    public class PropertyModel
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Zipcode { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}
