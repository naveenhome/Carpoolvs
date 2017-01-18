using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpoolmodels
{
    public class Ride
    {
        public int id { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime Ride_Date { get; set; }
        public DateTime Ride_Time { get; set; }
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
