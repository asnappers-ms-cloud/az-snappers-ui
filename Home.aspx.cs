using az_snappers_ui.DataAccess;
using az_snappers_ui.Models;
//using azure_snappers_sal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace az_snappers_ui
{
    public partial class Home : System.Web.UI.Page
    {
        public List<Img> gallery =
            new List<Img>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var res = getDetails();
                setLabels(res);

                //gallery.Add(new Img() { Name = "https://www.w3schools.com/bootstrap/la.jpg" });
                //gallery.Add(new Img() { Name = "https://www.w3schools.com/bootstrap/chicago.jpg" });
                //gallery.Add(new Img() { Name = "https://www.w3schools.com/bootstrap/ny.jpg" });
                rptGallery.DataSource = getImageData(res);
                rptGallery.DataBind();
            }
        }

        private static PlaceDetails getDetails()
        {
            var result = DataManager.GetDetails();
            return result;
        }

        private void setLabels(PlaceDetails res)
        {

            lblPrice.Text = "$"+res.HouseCost.ToString();
            lblAddress.Text = res.Address;
            lblSqFt.Text = res.LivingAreaSqFt.ToString()+" sqft";
            lblBath.Text = res.NumberOfBath.ToString()+ " Bath";
            lblBed.Text = res.NumberOfBeds.ToString()+" Bed";

            lblLotSize.Text = res.TotalAreaSqFt.ToString();

            lblSchoolRating.Text = res.SchoolRating.ToString();
            lblShopping.Text = res.ShoppingDetails;
            lblSafetyRating.Text = res.SafetyRating.ToString();
        }

        private static List<ImageData> getImageData(PlaceDetails res)
        {
            //var res = getDetails();
            var imageUrls = res.ImageUrls;
            if (imageUrls == null)
            {
                //Todo: Need to make a provison for showing some default 'Image not found' image in this case.
                imageUrls = new List<ImageData>();
            }
            else
            {
                //Fix THis!

            }
            return imageUrls;
        }

        public class Img
        {
            public string Name { get; set; }
        }
    }
}