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
        static TableTypes.Hotel hotelInstance;

        public static string addHotel(TableTypes.Hotel hotel)
        {
            string log ="";
            //add Hotel to Hotel table
            AddHotelClass.hotelInstance = hotel;
            AddHotelClass startAddHotelInstance =  new AddHotelClass();
            log+=startAddHotelInstance.addHotelToSqlTables(hotel);
            return log;
        }
        public string StartAddEmplyees()
        {

            return "";
        }
        private string addHotelToSqlTables(HotelDataBase.TableTypes.Hotel hotel)
        {
            //create query and run it

            runQuery(constructQuery(hotel));
            return "";
        }

        private string constructQuery(object queryObject)
        {
            if (queryObject is TableTypes.Hotel)
            {
                TableTypes.Hotel hotel = (TableTypes.Hotel)queryObject;

                return "insert into Hotel(Hotel_Id, HotelName, Addrs, City, Phone_no)" +
                    "values('" + hotelInstance.Hotel_Id + "', '" + hotelInstance.Name + "', '"
                    + hotelInstance.Addr + "', '" + hotelInstance.Addr + "'," + hotelInstance.Phone_Num + ");";
            }
            
            if(queryObject is UserTypes.Employee)
            {
                UserTypes.Employee employee = (UserTypes.Employee)queryObject;
                return "insert into Employee( First_name , Last_name , DOB , Addrs , Phone_no , Email , Pass , Hotel_Id )" +
            "values('" + employee.First_Name + "', '" + employee.Last_name + "', '" + employee.Date_Of_Birth + "', '" + employee.Addr + "', '" + employee.Phone_Num + "', '" + employee.Email + "', '" +employee.Pass + "'," + hotelInstance.Hotel_Id + ")";
            }
            if (queryObject is TableTypes.Room)
            {
                TableTypes.Room room = (TableTypes.Room) queryObject;
                return "insert into Room (Room_Id  ,Hotel_ID ,Room_Type ,Room_Description)" 
                    +"values(" + room.Room_Id + "," + hotelInstance.Hotel_Id + ", '" + room.Room_Type + "', '" + room.Room_Description + "')";
            }
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
