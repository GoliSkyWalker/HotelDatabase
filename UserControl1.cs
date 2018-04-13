using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDataBase
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Add_Hotel_Click(object sender, EventArgs e)
        {
            TableTypes.Hotel hotel = new TableTypes.Hotel();
            hotel.Addr = Hotel_Address.Text;
            hotel.City = Hotel_City.Text;
            hotel.Hotel_Id = Int32.Parse(Hotel_id.Text);
            hotel.Phone_Num =Int32.Parse(Hotel_Phone_Num.Text);
            hotel.Name = Hotel_Name.Text;
            string log =AddHotelClass.addHotel(hotel);
            MessageBox.Show(log);

        }

       
    }
}
