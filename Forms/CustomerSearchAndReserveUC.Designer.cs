namespace HotelDataBase
{
    partial class CustomerSearchAndReserveUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Search_By_Name = new System.Windows.Forms.Button();
            this.BT_Search_By_City_Name = new System.Windows.Forms.Button();
            this.BT_ReserveRoom = new System.Windows.Forms.Button();
            this.TB_Search_By_Name = new System.Windows.Forms.TextBox();
            this.TB_Search_By_City = new System.Windows.Forms.TextBox();
            this.TB_HotelID = new System.Windows.Forms.TextBox();
            this.DT_Booking = new System.Windows.Forms.DateTimePicker();
            this.DT_CheckIn = new System.Windows.Forms.DateTimePicker();
            this.TB_Room_ID = new System.Windows.Forms.TextBox();
            this.DG_Hotel_By_Name = new System.Windows.Forms.DataGridView();
            this.DG_Hotel_By_City = new System.Windows.Forms.DataGridView();
            this.DG_Available_Room = new System.Windows.Forms.DataGridView();
            this.BT_Check_unreseved_Rooms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Hotel_By_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Hotel_By_City)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Available_Room)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Search_By_Name
            // 
            this.BT_Search_By_Name.Location = new System.Drawing.Point(61, 154);
            this.BT_Search_By_Name.Name = "BT_Search_By_Name";
            this.BT_Search_By_Name.Size = new System.Drawing.Size(122, 54);
            this.BT_Search_By_Name.TabIndex = 0;
            this.BT_Search_By_Name.Text = "Search By HotelName";
            this.BT_Search_By_Name.UseVisualStyleBackColor = true;
            // 
            // BT_Search_By_City_Name
            // 
            this.BT_Search_By_City_Name.Location = new System.Drawing.Point(61, 384);
            this.BT_Search_By_City_Name.Name = "BT_Search_By_City_Name";
            this.BT_Search_By_City_Name.Size = new System.Drawing.Size(122, 52);
            this.BT_Search_By_City_Name.TabIndex = 1;
            this.BT_Search_By_City_Name.Text = "Search By CityName";
            this.BT_Search_By_City_Name.UseVisualStyleBackColor = true;
            // 
            // BT_ReserveRoom
            // 
            this.BT_ReserveRoom.Location = new System.Drawing.Point(566, 375);
            this.BT_ReserveRoom.Name = "BT_ReserveRoom";
            this.BT_ReserveRoom.Size = new System.Drawing.Size(122, 52);
            this.BT_ReserveRoom.TabIndex = 3;
            this.BT_ReserveRoom.Text = "Reseerve The Room";
            this.BT_ReserveRoom.UseVisualStyleBackColor = true;
            // 
            // TB_Search_By_Name
            // 
            this.TB_Search_By_Name.Location = new System.Drawing.Point(70, 97);
            this.TB_Search_By_Name.Name = "TB_Search_By_Name";
            this.TB_Search_By_Name.Size = new System.Drawing.Size(100, 20);
            this.TB_Search_By_Name.TabIndex = 4;
            // 
            // TB_Search_By_City
            // 
            this.TB_Search_By_City.Location = new System.Drawing.Point(70, 340);
            this.TB_Search_By_City.Name = "TB_Search_By_City";
            this.TB_Search_By_City.Size = new System.Drawing.Size(100, 20);
            this.TB_Search_By_City.TabIndex = 5;
            // 
            // TB_HotelID
            // 
            this.TB_HotelID.Location = new System.Drawing.Point(566, 71);
            this.TB_HotelID.Name = "TB_HotelID";
            this.TB_HotelID.Size = new System.Drawing.Size(100, 20);
            this.TB_HotelID.TabIndex = 6;
            // 
            // DT_Booking
            // 
            this.DT_Booking.Location = new System.Drawing.Point(566, 97);
            this.DT_Booking.Name = "DT_Booking";
            this.DT_Booking.Size = new System.Drawing.Size(200, 20);
            this.DT_Booking.TabIndex = 7;
            // 
            // DT_CheckIn
            // 
            this.DT_CheckIn.Location = new System.Drawing.Point(566, 123);
            this.DT_CheckIn.Name = "DT_CheckIn";
            this.DT_CheckIn.Size = new System.Drawing.Size(200, 20);
            this.DT_CheckIn.TabIndex = 8;
            // 
            // TB_Room_ID
            // 
            this.TB_Room_ID.Location = new System.Drawing.Point(566, 340);
            this.TB_Room_ID.Name = "TB_Room_ID";
            this.TB_Room_ID.Size = new System.Drawing.Size(100, 20);
            this.TB_Room_ID.TabIndex = 9;
            // 
            // DG_Hotel_By_Name
            // 
            this.DG_Hotel_By_Name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Hotel_By_Name.Location = new System.Drawing.Point(202, 71);
            this.DG_Hotel_By_Name.Name = "DG_Hotel_By_Name";
            this.DG_Hotel_By_Name.Size = new System.Drawing.Size(240, 150);
            this.DG_Hotel_By_Name.TabIndex = 10;
            // 
            // DG_Hotel_By_City
            // 
            this.DG_Hotel_By_City.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Hotel_By_City.Location = new System.Drawing.Point(202, 302);
            this.DG_Hotel_By_City.Name = "DG_Hotel_By_City";
            this.DG_Hotel_By_City.Size = new System.Drawing.Size(240, 150);
            this.DG_Hotel_By_City.TabIndex = 11;
            // 
            // DG_Available_Room
            // 
            this.DG_Available_Room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Available_Room.Location = new System.Drawing.Point(786, 58);
            this.DG_Available_Room.Name = "DG_Available_Room";
            this.DG_Available_Room.Size = new System.Drawing.Size(240, 150);
            this.DG_Available_Room.TabIndex = 12;
            // 
            // BT_Check_unreseved_Rooms
            // 
            this.BT_Check_unreseved_Rooms.Location = new System.Drawing.Point(566, 169);
            this.BT_Check_unreseved_Rooms.Name = "BT_Check_unreseved_Rooms";
            this.BT_Check_unreseved_Rooms.Size = new System.Drawing.Size(122, 52);
            this.BT_Check_unreseved_Rooms.TabIndex = 13;
            this.BT_Check_unreseved_Rooms.Text = "Search By CityName";
            this.BT_Check_unreseved_Rooms.UseVisualStyleBackColor = true;
            this.BT_Check_unreseved_Rooms.Click += new System.EventHandler(this.BT_Check_unreseved_Rooms_Click);
            // 
            // CustomerSearchAndReserveUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BT_Check_unreseved_Rooms);
            this.Controls.Add(this.DG_Available_Room);
            this.Controls.Add(this.DG_Hotel_By_City);
            this.Controls.Add(this.DG_Hotel_By_Name);
            this.Controls.Add(this.TB_Room_ID);
            this.Controls.Add(this.DT_CheckIn);
            this.Controls.Add(this.DT_Booking);
            this.Controls.Add(this.TB_HotelID);
            this.Controls.Add(this.TB_Search_By_City);
            this.Controls.Add(this.TB_Search_By_Name);
            this.Controls.Add(this.BT_ReserveRoom);
            this.Controls.Add(this.BT_Search_By_City_Name);
            this.Controls.Add(this.BT_Search_By_Name);
            this.Name = "CustomerSearchAndReserveUC";
            this.Size = new System.Drawing.Size(1080, 485);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Hotel_By_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Hotel_By_City)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Available_Room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Search_By_Name;
        private System.Windows.Forms.Button BT_Search_By_City_Name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BT_ReserveRoom;
        private System.Windows.Forms.TextBox TB_Search_By_Name;
        private System.Windows.Forms.TextBox TB_Search_By_City;
        private System.Windows.Forms.TextBox TB_HotelID;
        private System.Windows.Forms.DateTimePicker DT_Booking;
        private System.Windows.Forms.DateTimePicker DT_CheckIn;
        private System.Windows.Forms.TextBox TB_Room_ID;
        private System.Windows.Forms.DataGridView DG_Hotel_By_Name;
        private System.Windows.Forms.DataGridView DG_Hotel_By_City;
        private System.Windows.Forms.DataGridView DG_Available_Room;
        private System.Windows.Forms.Button BT_Check_unreseved_Rooms;
    }
}
