using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDataBase
{
     public class TableTypes
    {
        public class Hotel
        {
            public int Hotel_Id { set; get; }
            public string Name { set; get; }
            public string Addr { set; get; }
            public string City { set; get; }
            public int Phone_Num { set; get; }
        }

        public class Room
        {
            public int Room_Id { set; get; }
            public int Hotel_ID { set; get; }
            public string Room_Type { set; get; }
            public string Room_Description { set; get; }
           
        }
        

        public class RoomType
        {
            public int Room_Type { set; get; }
            public string HotelPrice { set; get; }
        }


        public class Booking
        {
            public int Booking_id { set; get; }
            public int Customer_id { set; get; }
            public int Room_id { set; get; }
            public int Hotel_id { set; get; }
            public int Payment_id { set; get; }
            public DateTime Booking_Date { set; get; }
            public DateTime Checkin_Date { set; get; }
            public int No_of_Nights { set; get; }

                
        }

    }


}
