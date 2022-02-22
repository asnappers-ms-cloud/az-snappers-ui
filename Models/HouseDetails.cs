using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace az_snappers_ui.Models
{
    public class HouseDetails
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Zipcode { get; set; }
        public string[] ImageUrls { get; set; }
        public int NeighborhoodId { get; set; }
        public int SchoolRating { get; set; }
        public string SchoolDetails { get; set; }
        public int SafetyRating { get; set; }
        public string DemographicDetails { get; set; }
        public int NatureRating { get; set; }
        public string HikingDetails { get; set; }
        public string ShoppingDetails { get; set; }
        public string HealthWellnessDetails { get; set; }
        public float HouseCost { get; set; }
        public bool IsPreapproved { get; set; }
        public string APR { get; set; }
        public string DisplayName { get; set; }
    }

    /*
     {
	"Id": 3,
	"Address": "57 Ainsworth Ave, East Brunswick, NJ 08816, USA",
	"Latitude": "40.4709205",
	"Longitude": "-74.4047807",
	"Zipcode": "08816",
	"ImageUrls": [
		"https://propsearchblob.blob.core.windows.net/query-property/40.4709205,-74.4047807.jpg"
	],
	"NeighborhoodId": 1,
	"Zipcode": "08816",
	"SchoolRating": 9,
	"SchoolDetails": "Elementary - School A; Middle - School B, High - School C",
	"SafetyRating": 93,
	"DemographicDetails": "Good diversity of ethnicity and race",
	"NatureRating": 58,
	"HikingDetails": "Good hiking trails within a few iles",
	"ShoppingDetails": "Lots of shopping areas and close to major highways",
	"HealthWellnessDetails": "Lots of Gyms and Spas in the area",
	"HouseCost": 5000000.0,
	"IsPreapproved": true,
	"APR": "4.60",
	"DisplayName": "Morgan Stanley Private Bank, National Association - Fixed Rate, 30 Years"
}
     */

}

