using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CarpoolDAO;
using Carpoolmodels;

namespace TestCarpool
{
    [TestFixture]
    public class TestCarpoolDB
    {
        [Test]
        public void testGetRides()
        {
            RideDAO rideDAO = new RideDAO();
            //List<Ride> rides = new List<Ride>();
            var rides = rideDAO.GetRides();
            Assert.NotNull(rideDAO.GetRides());
            //Assert.AreEqual("Naveen Singh", rides[0].EmpName);
        }
    }
}
