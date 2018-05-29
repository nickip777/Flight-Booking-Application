using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace cmpt300a7
{
    public class sqlDB
    {
        //string userId = "nip";
        //string password = "";
        //string server = "cypress";
        //string database = "nip354";
        SqlConnection connection;

        public sqlDB(){
            connection = new SqlConnection("user id=nip;" +
                                       "password=bh4nTAE2dj24Mata;" + 
                                       "server=cypress;" +
                                       "Trusted_Connection=yes;" +
                                       "database=nip354; " +
                                       "connection timeout=30");
            openConnection();
        }

        private bool openConnection(){
            try {
                connection.Open();
                Console.WriteLine("Connection Open");
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        public int getHighestPid() {
            DataTable dt = query("select MAX(passenger_id) from Passenger");
            string val = dt.Rows[0][0].ToString();
            return Convert.ToInt32(val) + 1;
        }
        public bool insertPassengers(string first, string last) {
            try {

                string cmd = "insert into Passenger values("+getHighestPid()+",'"+first+"','"+last+"',0)";
                SqlCommand myCommand = new SqlCommand(cmd, connection);
                myCommand.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        private string dateConvert(DateTime date){
            return date.Year + "-" + date.Month + "-" +date.Day;
        }

        
        private DataTable query(string cmd) {
            SqlDataReader myReader;
            try {
                DataTable dt = new DataTable();
                myReader = null;
                SqlCommand myCommand = new SqlCommand(cmd, connection);
                myReader = myCommand.ExecuteReader();
                if (myReader.HasRows) {
                    dt.Load(myReader);
                    myReader.Close();
                    return dt;
                } else {
                    Console.WriteLine("No Rows Found");
                    myReader.Close();
                    return null;
                }
                
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                return null;
            }

        }

        public int getRemainingSeats(string flight, DateTime date) {
            DataTable dt = query("select available_seats from Flight_Instance where flight_code = '" + flight + "' and depart_date = '" + dateConvert(date) + "'");
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        public DataTable getPassengers(string flight, DateTime date) {
            return query("select P.passenger_id,P.first_name,P.last_name,P.miles from Passenger P, Booking B where P.passenger_id = B.passenger_id and B.flight_code = '" + flight + "' and B.depart_date = '" + dateConvert(date) + "'");
        }

        public bool checkFlightInstance(string flight, DateTime date){
            DataTable dt = query("select * from Flight_Instance where flight_code = '" + flight + "' and depart_date = '" + dateConvert(date) + "'");
            if(dt == null){
                return false;
            }else{
                return true;
            }
        }

        public List<string> getFlightCodes(){
            List<string> list = new List<string>();
            DataTable dt = query("select flight_code from Flight");
            foreach (DataRow dr in dt.Rows) {
                list.Add(dr[0].ToString());
            }
            return list;
        }

        public List<string> getPids() {
            List<string> list = new List<string>();
            DataTable dt = query("select passenger_id from Passenger");
            foreach (DataRow dr in dt.Rows) {
                list.Add(dr[0].ToString());
            }
            return list;
        }

        public string getAirports(string flight) {
            DataTable dt = query("select departure_iata,arrival_iata from Flight where flight_code = '" + flight + "'");
            if (dt == null) {
                return null;
            } else {
                return dt.Rows[0][0] + " to " + dt.Rows[0][1];
            }
        }

        public bool checkEmptySpace(string flight, DateTime date) {
            DataTable dt = query("select available_seats from Flight_Instance where flight_code = '" + flight + "' and depart_date = '" + dateConvert(date) +"'");
            if (Convert.ToInt32(dt.Rows[0][0].ToString()) > 0) {
                return true;
            } else {
                return false;
            }
        }

        public bool insertBookings(string flight, DateTime date, string pid) {
            try {
                string cmd = "insert into Booking values('" + flight + "','" + dateConvert(date) + "','" + pid + "')";
                SqlCommand myCommand = new SqlCommand(cmd, connection);
                myCommand.ExecuteNonQuery();
                return true;
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

    }
}
