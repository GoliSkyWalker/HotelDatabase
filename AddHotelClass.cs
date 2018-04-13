using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace HotelDataBase
{

    public  class AddHotelClass
    {
        HotelDataBase.TableTypes.Hotel currentHotel;
        public const string CONNECTION_STRING = "Data Source=DESKTOP-SSOCU79;"
            +"Initial Catalog = HotelModel ;"
            +" Integrated Security = True";

        public static string addHotel(TableTypes.Hotel hotel)
        {
            string log ="";
            //add Hotel to Hotel table
            AddHotelClass startAddHotelInstance =  new AddHotelClass();
            log+=startAddHotelInstance.addHotelToSqlTables(hotel);
            return log;
        }
        private string addHotelToSqlTables(HotelDataBase.TableTypes.Hotel hotel)
        {
            //create query and run it

            runQuery(constructQuery(hotel));
            return "";
        }

        private string constructQuery(TableTypes.Hotel hotel)
        {
            return "insert into Hotel(Hotel_Id, HotelName, Addrs, City, Phone_no)" +
                    "values('" +  hotel.Hotel_Id + "', '" + hotel.Name + "', '" 
                    + hotel.Addr + "', '" + hotel.Addr + "'," + hotel.Phone_Num + ");"; 
            return "";
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

               
              //  SqlDataReader reader = command.ExecuteReader();



                

                conn.Close();
                return "Hotel added";
            }

            catch (Exception ex)

            {

                Console.WriteLine("Can not open connection ! " + ex.Message);
                return "sql request error , failed to add hotel. ";

            }

            

        }

    }

    
}
