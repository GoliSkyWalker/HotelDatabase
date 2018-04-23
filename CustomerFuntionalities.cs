using System;

using System.Data.SqlClient;
using HotelDataBase;

namespace HotelDataBaseProj
{
    public class CustomerFuntionalities
    {
        public const string CONNECTION_STRING = "Data Source=LOCALHOST;" +
                                                "Initial Catalog=HotelModel;" +
                                                "User id=SA;" +
                                                "Password=f3l!Xkjil;";
        
        
        
        public String FindReservervableHotels(DateManagement reserveDates)
        {
            return "";
        }

        public string SearchHotelsByCity(string cityName)
        {
            string query = "select name from Hotel"
                           + "where city = '" + cityName + "'";
            return runQuery(query);
        }


        public string SearchHotelsbyName(string HotelName)
        {
            string query = "select name from Hotel"
                           + "where Hotel = '" + HotelName + "'";
            return runQuery(query);
        }

        public string enterReservationIntoBookingTable(UserTypes.Customer customer,int roomNumber , TableTypes.Hotel hotel , TableTypes.Payment payment , DateManagement reserveDates)
        {

            string query =
                "insert into Booking (Customer_Id , Room_Id , Hotel_Id , Payment_Id , Booking_Date , Checkin_Date  , No_Of_Nights)"
                + "VALUEs                (" + customer.Custome_Id + "," + roomNumber + "," + hotel.Hotel_Id + "," +
                payment.PaymentID + "," + "'" + reserveDates.enteranceDate + "'" + "," +"'" +
                reserveDates.enteranceDate + "'" + "," + reserveDates.ReservationDuration + ")";
            return runQuery(query);
        }


        private string runQuery(string query)
        {
            SqlConnection conn = new SqlConnection();
            string log ="";
            conn.ConnectionString = CONNECTION_STRING;
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                SqlDataReader reader = command.ExecuteReader();
               
                log += "command   "+query + "   executed";
                conn.Close();
            }

            catch (Exception ex)

            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
                log += query + " failed execution";
            }

            return log;

        }
        
        
        
       
    }
}