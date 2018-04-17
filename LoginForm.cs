using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDataBase
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HotelDataBaseProj.Login startLogin = new HotelDataBaseProj.Login();
            string log = startLogin.StartLogin(textBox1.Text, textBox2.Text);
            MessageBox.Show(log);
            if (HotelDataBaseProj.Login.UserISLoggedIN && HotelDataBaseProj.Login.userType.Equals("Admin") )
            {
                new AdminForm().Show();
                this.Hide();
            } 
            else if(HotelDataBaseProj.Login.UserISLoggedIN && HotelDataBaseProj.Login.userType.Equals("Employee"))
            {
            }
            else if(HotelDataBaseProj.Login.UserISLoggedIN && HotelDataBaseProj.Login.userType.Equals("Customer"))
            {

            }
        }
        

        private void login_CreateAccount_Click(object sender, EventArgs e)
        {
            this.customerSignInUC1.BringToFront();
            this.customerSignInUC1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerSignInUC1.Visible = true;
            this.customerSignInUC1.BringToFront();
        }
    }
}
