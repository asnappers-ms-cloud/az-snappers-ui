using azure_snappers_sal.Controller;
using azure_snappers_sal.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azure_snappers_sal.Mock
{
    internal class MockDataProvider : IDataProvider

    {
        public HouseDetails GetDetails()
        {
            var jsonString = @"{'Id':3,'Address':'57 Ainsworth Ave, East Brunswick, NJ 08816, USA','Latitude':'40.4709205','Longitude':'-74.4047807','Zipcode':'08816','ImageUrls':['https://propsearchblob.blob.core.windows.net/query-property/40.4709205,-74.4047807.jpg', 'https://www.w3schools.com/bootstrap/la.jpg', 'https://www.w3schools.com/bootstrap/chicago.jpg'],'NeighborhoodId':1,'Zipcode':'08816','SchoolRating':9,'SchoolDetails':'Elementary - School A; Middle - School B, High - School C','SafetyRating':93,'DemographicDetails':'Good diversity of ethnicity and race','NatureRating':58,'HikingDetails':'Good hiking trails within a few iles','ShoppingDetails':'Lots of shopping areas and close to major highways','HealthWellnessDetails':'Lots of Gyms and Spas in the area','HouseCost':5000000.0,'IsPreapproved':true,'APR':'4.60','DisplayName':'Morgan Stanley Private Bank, National Association - Fixed Rate, 30 Years'}";
            //var details = new HouseDetails();
            var details = JsonConvert.DeserializeObject<HouseDetails>(jsonString);
            return details;
        }
    }
}
