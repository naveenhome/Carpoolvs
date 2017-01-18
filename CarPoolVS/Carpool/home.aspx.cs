using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarpoolService;

namespace Carpool
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RideService rideService = new RideService();
            RideView.DataSource = rideService.GetRides();
            RideView.DataBind();
        }
    }
}