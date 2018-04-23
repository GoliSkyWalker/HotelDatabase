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
    public partial class HotelDatabase : UserControl
    {
        public HotelDatabase()
        {
            InitializeComponent();
        }

        private void hotelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hotelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelModelDataSet);
          
                
           
        }
        private void HotelDatabases_Load(object sender, EventArgs e)
        {
            this.hotelTableAdapter.Fill(this.hotelModelDataSet.Hotel);
        }


    }
}
