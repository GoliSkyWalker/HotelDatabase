using System;
namespace HotelDataBase
{
    public class UserTypes
    {

        public class Customer
        {


            public int Custome_Id { set; get; }
            public string First_Name { set; get; }
            public string Last_name { set; get; }
            public string Addr { set; get; }
            public int Phone_Num { set; get; }
            public string Email { set; get; }
            public string Pass { set; get; }
        }

        public class Employee
        {
            public int Staff_Id { set; get; }
            public string First_Name { set; get; }
            public string Last_name { set; get; }
            public string Addr { set; get; }
            public int Phone_Num { set; get; }
            public string Email { set; get; }
            public string Pass { set; get; }
            public string Hotel_ID { set; get; }

            public string Date_Of_Birth { set; get; }


        }

    }
}