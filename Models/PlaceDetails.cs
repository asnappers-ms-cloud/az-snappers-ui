using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace az_snappers_ui.Models
{
    internal class PlaceDetails
    {
        internal int Id { get; set; }
        internal string Address { get; set; }
        internal string Latitude { get; set; }
        internal string Longitude { get; set; }
        internal string Zipcode { get; set; }
        internal List<ImageData> ImageUrls { get; set; }
        internal int NeighborhoodId { get; set; }
        internal int SchoolRating { get; set; }
        internal string SchoolDetails { get; set; }
        internal int SafetyRating { get; set; }
        internal string DemographicDetails { get; set; }
        internal int NatureRating { get; set; }
        internal string HikingDetails { get; set; }
        internal string ShoppingDetails { get; set; }
        internal string HealthWellnessDetails { get; set; }
        internal float HouseCost { get; set; }
        internal bool IsPreapproved { get; set; }
        internal string APR { get; set; }
        internal string DisplayName { get; set; }
    }
}