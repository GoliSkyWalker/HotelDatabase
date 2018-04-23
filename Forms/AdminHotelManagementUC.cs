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
    public partial class AdminHotelManagementUC : UserControl
    {
        public AdminHotelManagementUC()
        {
            InitializeComponent();
        }

       

        private void Button_Add_Hotel_Click(object sender, EventArgs e)
        {
            TableTypes.Hotel hotel = new TableTypes.Hotel();
            hotel.Addr = Hotel_Address.Text;
            hotel.City = Hotel_City.Text;
            hotel.Hotel_Id = Int32.Parse(Hotel_id.Text);
            hotel.Phone_Num =Int32.Parse(Hotel_Phone_Num.Text);
            hotel.Name = Hotel_Name.Text;
            AdminHotelListManipulationClass HMInstance = new AdminHotelListManipulationClass();
            string log =HMInstance.addHotel(hotel);
            MessageBox.Show(log);

        }

        private void Button_Add_HotelEmp_Click(object sender, EventArgs e)
        {
            UserTypes.Employee Emp = new UserTypes.Employee();
            Emp.Addr = Hotel_Staff_Address.Text;
            Emp.Date_Of_Birth = Hotel_Staff_DOB.Text;
            Emp.Email = Hotel_Staff_EmailAddresss.Text;
            Emp.First_Name = Hotel_Staff_First_Name.Text;
            Emp.Last_name = Hotel_Staff_LastName.Text;
            Emp.Hotel_ID = Int32.Parse(Hotel_id.Text);
            Emp.Staff_Id = Int32.Parse(Hotel_Staff_ID.Text);
            Emp.Phone_Num = Int32.Parse( Hotel_Staff_PhoneNum.Text);
            AdminHotelListManipulationClass HMInstance = new AdminHotelListManipulationClass();
            string log = HMInstance.AddEmployeesToHotel(Emp);
            MessageBox.Show(log);
        }

        private void Button_Add_Room_Click(object sender, EventArgs e)
        {
            TableTypes.Room room = new TableTypes.Room();
            room.Hotel_ID = Int32.Parse(Hotel_id.Text);
            room.Room_Id = Int32.Parse(Hotel_Room_ID.Text);
            room.Room_Type = Hotel_Room_Type.Text;
            room.Room_Description = Hotel_Description.Text;
            AdminHotelListManipulationClass HMInstance = new AdminHotelListManipulationClass();
            string log = HMInstance.AddRoomsToHotel(room);
            MessageBox.Show(log);


        }

       

        private void AdminHotelManagementUC_Load(object sender, EventArgs e)
        {
            
        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
