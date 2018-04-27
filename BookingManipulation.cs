using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security.Cryptography;


namespace HotelDataBase
{

    public class BookingManipulation
    {

        public const string CONNECTION_STRING = "Data Source=DESKTOP-BD9CASU\\SQLEXPRESS;"
            + "Initial Catalog = HotelModel ;"
            + " Integrated Security = True";

        static TableTypes.Booking bookingInstance;

        public string addBooking(TableTypes.Booking booking)
        {
            string log = "";
            
            BookingManipulation.bookingInstance = booking;
            log += AddBookingToSqlTables(booking);
            return log;
        }

        private string AddBookingToSqlTables(HotelDataBase.TableTypes.Booking booking)
        {
           
            return runQuery(constructQuery(booking));
           
        }



        private string constructQuery(object queryObject)
        {
                TableTypes.Booking booking = (TableTypes.Booking)queryObject;
            string a = "insert into Booking (Customer_id ,Hotel_id,Room_id,Booking_Date,Checkin_Date,No_Of_Nights) " +
                    "values(" + bookingInstance.Customer_id + ","
                    + bookingInstance.Hotel_id +  "," + bookingInstance.Room_id + ", '1998-03-13' , '1998-03-13' , " + bookingInstance.No_of_Nights + ");";

            Console.Write(a);
            return a;
        
        }

        private string runQuery(string query)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = CONNECTION_STRING;

            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
                return "Query " + query + "was successfully executed";
            }

            catch (Exception ex)
            {

                Console.WriteLine("Can not open connection ! " + ex.Message);
                return "sql request error , Booking management failed ";

            }
        }

    }


}