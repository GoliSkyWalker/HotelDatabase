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
    public partial class CustomerSignInUC : UserControl
    {
        public CustomerSignInUC()
        {
            InitializeComponent();
        }

       

        private void Bt_CreateAccount_Click(object sender, EventArgs e)
        {
            UserTypes.Customer customer = new UserTypes.Customer();
            customer.Custome_Id = Int32.Parse(customer_IdTextBox.Text);
            customer.Addr = TB_CustomerLogin_Address.Text;
            customer.Email = TB_CustomerLogin_Email.Text;
            customer.Last_name = TB_CustomerLogin_LastName.Text;
            customer.Phone_Num = Int32.Parse(TB_CustomerLogin_PhoneNum.Text);
            customer.First_Name = TB_CustomerLogin_FirstName.Text;
            customer.Pass = TB_CustomerLogin_Password.Text;

            CustomerSignInClass hh = new CustomerSignInClass();
            String log = hh.CreateAccount(customer);

            MessageBox.Show(log);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
        }

      

        private void CustomerSignInUC_Load(object sender, EventArgs e)
        {
            






        }
    }
}
