using System.Data;
using HotelDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Web;

namespace HotelDataBaseProj
{
    // a class to create info for customrer to login
    public class CustomerLogin
    {
        public const string CONNECTION_STRING = "Data Source=DESKTOP-SSOCU79;"
              + "Initial Catalog = HotelModel ;"
              + " Integrated Security = True";

        public string CreateAccount(UserTypes.Customer newCustomer)
        {
            string log = "";


            if (checkForDuplicate(newCustomer))
                log += EnterIntoCustomerTable(newCustomer);
            else
            {
                return "customer already exists";
            }

            return "customer " + newCustomer.First_Name + "has an account now.";


        }

        private string EnterIntoCustomerTable(UserTypes.Customer newCustomer)
        {
            string query = "insert into customers (Customer_Id  ,First_name, Last_name, Addrs, Phone_no, Email,Pass)" +
                           "values  ("+ newCustomer.Custome_Id+",'"+ newCustomer.First_Name + "', '" + newCustomer.Last_name+ "' , '" + newCustomer.Addr + "'" +
                           " ," + newCustomer.Phone_Num + ",'" +newCustomer.Email+ "','" +newCustomer.Pass+ "' );";
            return runInsertNewSignUpQuery(query);
        }
        private bool checkForDuplicate(UserTypes.Customer newCustomer)
        {
            string qurey = "Select * From Customers where email = '" + newCustomer.Email + "'";
            return runCheckDuplicateQuery(qurey);


        }
        private string runInsertNewSignUpQuery(string query)
        {
            string log = "";
            SqlConnection conn2 = new SqlConnection();

            conn2.ConnectionString = CONNECTION_STRING;
            try
            {
                conn2.Open();
                SqlCommand command = new SqlCommand(query, conn2);
                command.ExecuteNonQuery();
                command.Dispose();
                
                log += "insert new sigh up customer query executed";
                conn2.Close();
            }

            catch (Exception ex)

            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
                log += "opetration add new customer failed with error" + ex.Message;
            }

            return log;
        }

       

        private bool runCheckDuplicateQuery(string query)
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
                while (reader.Read())
                {
                    if (!reader.HasRows)
                    {
                        return true;
                    }
                    else
                        return false;


                }
                log += "command executed";
                conn.Close();
            }

            catch (Exception ex)

            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
                return false;
            }

            return true;

        }
    }
}