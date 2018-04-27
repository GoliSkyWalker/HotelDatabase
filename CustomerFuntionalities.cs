using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using HotelDataBase;

namespace HotelDataBaseProj
{
    public class CustomerFuntionalities
    {
        public const string CONNECTION_STRING = "Data Source=DESKTOP-SSOCU79;"
              + "Initial Catalog = HotelModel ;"
              + " Integrated Security = True";



        public List<TableTypes.Room> FindReservervableRooms(DateManagement reserveDates)
        {
            string query ="select * from Room where Room_Id not in (select Room_Id from Booking"+
            " where '"+reserveDates.enteranceDate.ToString("yyyy-MM-dd HH:mm:ss.fff") +"'<Checkin_Date  and '"
                          +reserveDates.checkoutDate.ToString("yyyy-MM-dd HH:mm:ss.fff")+"'> Booking_Date )";
            return runRoomQuery(query);

        }

        public List<TableTypes.Hotel>  SearchHotelsByCity(string cityName)
        {
            string query = "select * from Hotel"
                           + " where city = '" + cityName + "'";
            return runHotelQuery(query);
        }


        public List<TableTypes.Hotel> SearchHotelsbyName(string HotelName)
        {
            string query = "select * from Hotel"
                           + " where HotelName = '" + HotelName + "'";
            return runHotelQuery(query );
        }

        public void enterReservationIntoBookingTable(UserTypes.Customer customer,int roomNumber , TableTypes.Hotel hotel , TableTypes.Payment payment , DateManagement reserveDates)
        {

            string query =
                "insert into Booking (Customer_Id , Room_Id , Hotel_Id , Payment_Id , Booking_Date , Checkin_Date  , No_Of_Nights)"
                + "VALUEs                (" + customer.Custome_Id + "," + roomNumber + "," + hotel.Hotel_Id + "," +
                payment.PaymentID + "," + "'" + reserveDates.enteranceDate + "'" + "," +"'" +
                reserveDates.enteranceDate + "'" + "," + reserveDates.ReservationDuration + ")";
            
             runHotelQuery(query  ); //dummy value
        }


        private List<TableTypes.Hotel> runHotelQuery(string query  )
        {
            List<TableTypes.Hotel> returnList = new List<TableTypes.Hotel>();
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
               
                
                while (reader.Read())
                {



                    
                    TableTypes.Hotel temp = new TableTypes.Hotel();
                   temp.Hotel_Id = Int32.Parse(reader["Hotel_Id"].ToString());
                    temp.Name = reader["HotelName"].ToString();
                    temp.Addr = reader["Addrs"].ToString();
                    temp.City = reader["City"].ToString();
                    temp.Phone_Num = Int32.Parse(reader["Phone_no"].ToString());
                    returnList.Add(temp);

                }
// Now you have a list of arrays that you can iterate over
                
                log += "command   "+query + "   executed";
                conn.Close();
            }

            catch (Exception ex)

            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
                log += query + " failed execution";
            }

            Console.WriteLine((log));
            return returnList;
        }
        
        
        private List<TableTypes.Room> runRoomQuery(string query  )
        {
            List<TableTypes.Room> returnList = new List<TableTypes.Room>();
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
               
                
                while (reader.Read())
                {
                    
                    TableTypes.Room temp = new TableTypes.Room();

                        temp.Hotel_ID = Int32.Parse(reader["Hotel_Id"].ToString());
                    temp.Room_Description = reader["Room_Description"].ToString();
                    temp.Room_Id = Int32.Parse(reader["Room_Id"].ToString());
                    temp.Room_Type = reader["Room_Type"].ToString();
               
                    
                    returnList.Add(temp);
                }
// Now you have a list of arrays that you can iterate over
                
                log += "command   "+query + "   executed";
                conn.Close();
            }

            catch (Exception ex)

            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
                log += query + " failed execution";
            }

            Console.WriteLine((log));
            return returnList;
        }

        
        
       
    }
}