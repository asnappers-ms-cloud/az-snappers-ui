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
                gallery.Add(new Img() { Name = "https://www.w3schools.com/bootstrap/la.jpg" });
                gallery.Add(new Img() { Name = "https://www.w3schools.com/bootstrap/chicago.jpg" });
                gallery.Add(new Img() { Name = "https://www.w3schools.com/bootstrap/ny.jpg" });
                rptGallery.DataSource = gallery;
                rptGallery.DataBind();
            }
        }

        public class Img
        {
            public string Name { get; set; }
        }
    }
}