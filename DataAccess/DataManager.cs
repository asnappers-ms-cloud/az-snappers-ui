using az_snappers_ui.Models;
using azure_snappers_sal;
using azure_snappers_sal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace az_snappers_ui.DataAccess
{
    internal class DataManager
    {
        internal static PlaceDetails GetDetails()
        {
            ServiceAccess sa = new ServiceAccess();
            var result = sa.GetHouseDetails();
            var placeDetails = copyObject(result);


            return placeDetails;

        }

        private static PlaceDetails copyObject(HouseDetails hd)
        {
            PlaceDetails pd = new PlaceDetails
            {
                Address = hd.Address,
                APR = hd.APR,
                DemographicDetails = hd.DemographicDetails,
                DisplayName = hd.DisplayName,
                HealthWellnessDetails = hd.HealthWellnessDetails,
                HikingDetails = hd.HikingDetails,
                //ImageUrls= new ImageData { Name= hd.ImageUrls.},
                IsPreapproved = hd.IsPreapproved,
                HouseCost = hd.HouseCost,
                Id = hd.Id,
                Latitude = hd.Latitude,
                Longitude = hd.Longitude,
                NatureRating = hd.NatureRating,
                NeighborhoodId = hd.NeighborhoodId,
                SafetyRating = hd.SafetyRating,
                SchoolDetails = hd.SchoolDetails,
                SchoolRating = hd.SchoolRating,
                ShoppingDetails = hd.ShoppingDetails,
                Zipcode = hd.Zipcode
            };

            var ImageUrls = new List<ImageData>();
            foreach (var imageurl in hd.ImageUrls)
            {
                var imgData = new ImageData { Name = imageurl };
                ImageUrls.Add(imgData);
            }
            pd.ImageUrls = ImageUrls;
            return pd;


        }
    }
}