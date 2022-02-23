using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azure_snappers_sal.Model
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
        public float NumberOfBeds { get; set; }
        public float NumberOfBath { get; set; }
        public float LivingAreaSqFt { get; set; }
        public float TotalAreaSqFt { get; set; }
    }
}
