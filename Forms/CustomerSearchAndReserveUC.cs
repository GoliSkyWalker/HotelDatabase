using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelDataBaseProj;

namespace HotelDataBase
{
    public partial class CustomerSearchAndReserveUC : UserControl
    {
        CustomerFuntionalities customerFuntionalities = new CustomerFuntionalities();
        public CustomerSearchAndReserveUC()
        {
            InitializeComponent();
        }

        private void BT_Search_By_Name_Click(object sender, EventArgs e)
        {

            List<TableTypes.Hotel> hotelList= customerFuntionalities.SearchHotelsbyName(TB_Search_By_Name.Text);
            DG_Hotel_By_Name.DataSource = hotelList;
        }

        private void BT_Search_By_City_Name_Click(object sender, EventArgs e)
        {
            List<TableTypes.Hotel> hotelList = customerFuntionalities.SearchHotelsByCity(TB_Search_By_City.Text);
            DG_Hotel_By_City.DataSource = hotelList;
        }

      

        private void BT_Check_unreseved_Rooms_Click(object sender, EventArgs e)
        {

            List<TableTypes.Room> rooms =customerFuntionalities.FindReservervableRooms(new DateManagement( DateTime.Parse(DT_Booking.Text)
                , DateTime.Parse(DT_CheckIn.Text)));
            DG_Available_Room.DataSource = rooms;
        }
    }
}
