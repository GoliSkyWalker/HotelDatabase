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
    public partial class CustomerSignInUC : UserControl
    {
        public CustomerSignInUC()
        {
            InitializeComponent();
        }

       

        private void Bt_CreateAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yeah lol");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
        }
    }
}
