using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Web;


namespace HotelDataBaseProj
{

    public class Login
    {
        public const string CONNECTION_STRING = "Data Source=DESKTOP-SSOCU79;"
            + "Initial Catalog = HotelModel ;"
            + " Integrated Security = True";
        //user types
        public const string ADMIN_TYPE = "Admin";
        public const string CUSTOMER_TYPE = "Customer";
        public const string EMPLOUEE_TYPE = "Employee";


        public static bool UserISLoggedIN;

        public static string userType = "";
        public HotelDataBase.UserTypes.Customer loggedContomer;
        public HotelDataBase.UserTypes.Employee loggedEmployee;




        public string StartLogin(string email, string password)
        {


            Login instane = new Login();
            //start logging
            string log = "";
            //create an instace of program
            log += instane.FetchLoginData(email, password);
            Console.WriteLine(log);
            return log;
        }

        public string FetchLoginData(string email, string password)
        {
            //open sql connection

            string log = "";
            HotelDataBaseProj.Login.UserISLoggedIN = false;


            if (email.Equals("admin") && password.Equals("admin"))
            {
                userType = ADMIN_TYPE;
                HotelDataBaseProj.Login.UserISLoggedIN = true;
                return userType + "logged in \n ";

            }

            if (!UserISLoggedIN)
            {
                userType = CUSTOMER_TYPE;
                log += runQuery(email, password);



            }
            if (!UserISLoggedIN)
            {
                userType = EMPLOUEE_TYPE;
                log += runQuery(email, password);

            }


            if (!UserISLoggedIN)
                log += "login unsuccessful";



            return log;

        }

        private string runQuery(string email, string password)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = CONNECTION_STRING;



            try

            {

                conn.Open();
                string sqlQury = ConstructQuery(email, password);

                SqlCommand command = new SqlCommand(sqlQury, conn);

                command.ExecuteNonQuery();

                command.Dispose();

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        if (userType.Equals(CUSTOMER_TYPE))
                        {


                            initiateLoggedCustomer(reader);
                            Console.WriteLine("welcome" + loggedContomer.First_Name);
                            HotelDataBaseProj.Login.UserISLoggedIN = true;
                            return "User " + loggedContomer.First_Name + " " + loggedContomer.Last_name + " with id " +
                                   loggedContomer.Custome_Id + "and user type " + userType + " is logged in.";


                        }
                        else if (userType == EMPLOUEE_TYPE)
                        {
                            initiateLoggedEmployee(reader);
                            HotelDataBaseProj.Login.UserISLoggedIN = true;

                            return "User " + loggedEmployee.First_Name + " " + loggedEmployee.Last_name + " with id " +
                                   loggedEmployee.Staff_Id + "and user type " + userType + " is logged in.";

                        }
                    }
                    else
                        return "";


                }

                Console.WriteLine(" Error in login");

                conn.Close();
            }

            catch (Exception ex)

            {

                Console.WriteLine("Can not open connection ! " + ex.Message);
                return "sql request error ";

            }

            return "login error ";

        }

        private void initiateLoggedCustomer(SqlDataReader reader)

        {

            loggedContomer = new HotelDataBase.UserTypes.Customer();
            loggedContomer.Custome_Id = Int32.Parse((string)reader["Customer_Id"].ToString());
            loggedContomer.First_Name = reader["First_name"].ToString();
            loggedContomer.Last_name = reader["Last_name"].ToString();
            loggedContomer.Addr = reader["Addrs"].ToString();
            loggedContomer.Phone_Num = Int32.Parse(reader["Phone_no"].ToString());
            loggedContomer.Email = reader["Email"].ToString();
            loggedContomer.Pass = reader["Pass"].ToString();

            // Customer_Id, First_name, Last_name, Addrs, Phone_no, Email,Pass
        }

        private void initiateLoggedEmployee(SqlDataReader reader)

        {

            loggedEmployee = new HotelDataBase.UserTypes.Employee();
            loggedEmployee.Staff_Id = Int32.Parse((string)reader["Staff_Id"].ToString());
            loggedEmployee.First_Name = reader["First_name"].ToString();
            loggedEmployee.Last_name = reader["Last_name"].ToString();
            loggedEmployee.Date_Of_Birth = reader["DOB"].ToString();
            loggedEmployee.Addr = reader["Addrs"].ToString();
            loggedEmployee.Phone_Num = Int32.Parse(reader["Phone_no"].ToString());
            loggedEmployee.Email = reader["Email"].ToString();
            loggedEmployee.Pass = reader["Pass"].ToString();
            loggedEmployee.Hotel_ID = Int32.Parse(reader["Hotel_Id"].ToString());

            // Staff_Id ,First_name ,Last_name ,DOB ,Addrs ,Phone_no ,Email ,Pass ,Hotel_Id 
        }


        private string ConstructQuery(string email, string password)
        {
            return (userType == CUSTOMER_TYPE) ? "Select * from Customers where email='" + email + "' and pass = '" + password + "'" : (userType == EMPLOUEE_TYPE) ? "Select * from Employee where email='" + email + "' and pass = '" + password + "'" : "";
        }
    }


}