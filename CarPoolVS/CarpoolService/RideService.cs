using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carpoolmodels;
using CarpoolDAO;

namespace CarpoolService
{
    public class RideService
    {
        public Ride SaveRide(Ride ride)
        {
            return ride;
        }

        public List<Ride> GetRides()
        {
            RideDAO rideDAO = new RideDAO();
            return rideDAO.GetRides();
        }
    }
}
