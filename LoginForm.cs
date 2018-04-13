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
            if(HotelDataBaseProj.Login.UserISLoggedIN)
            {
                new AdminForm().Show();
                this.Hide();
            }
        }

       
    }
}
