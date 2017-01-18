using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carpoolmodels;
using System.Data;

namespace CarpoolDAO
{
    public class RideDAO
    {
        SqlConnection connection;
        string connectionString = "Data Source=DESKTOP-IAITL0O\\SQLEXPRESS;Initial Catalog=Carpool;User ID=sa; Password=vijaya22";

        public List<Ride> SaveRide(Ride ride)
        {
            
            return GetRides();
        }
        public List<Ride> GetRides()
        {
            
            List<Ride> rides = new List<Ride>();
            SqlCommand command = new SqlCommand("select * from Rides, Employees where Rides.Empid = Employees.Id");
            command.CommandType = CommandType.Text;
            connection = new SqlConnection(connectionString);
            connection.Open();
            command.Connection = connection;
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Ride ride = new Ride();
                    ride.id = int.Parse(reader[0].ToString());
                    ride.Source = reader[2].ToString();
                    ride.Destination = reader[3].ToString();
                    ride.Ride_Date = DateTime.Parse(reader[4].ToString());
                    ride.Ride_Time = DateTime.Parse(reader[5].ToString());
                    ride.EmpName = reader[7].ToString();
                    ride.Email = reader[8].ToString();
                    ride.Phone = reader[9].ToString();
                    rides.Add(ride);
                   
                }
            }
            catch (SqlException ex)
            {
                Console.Out.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            return rides;
        }
        public Ride GetRide(int rideId)
        {
            Ride ride = new Ride();
            return ride;
        }

    }
}
