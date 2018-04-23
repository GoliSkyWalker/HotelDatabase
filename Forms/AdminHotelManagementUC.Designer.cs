using System;

namespace HotelDataBase
{
    partial class AdminHotelManagementUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label staff_IdLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label dOBLabel;
            System.Windows.Forms.Label addrsLabel;
            System.Windows.Forms.Label phone_noLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passLabel;
            System.Windows.Forms.Label room_IdLabel;
            System.Windows.Forms.Label room_TypeLabel;
            System.Windows.Forms.Label room_DescriptionLabel;
            this.Button_Add_Hotel = new System.Windows.Forms.Button();
            this.Hotel_id = new System.Windows.Forms.TextBox();
            this.Hotel_Employee_DataGrid = new System.Windows.Forms.DataGridView();
            this.Hotel_DataGrid = new System.Windows.Forms.DataGridView();
            this.Hotel_Staff_ID = new System.Windows.Forms.TextBox();
            this.Hotel_Staff_First_Name = new System.Windows.Forms.TextBox();
            this.Hotel_Staff_LastName = new System.Windows.Forms.TextBox();
            this.Hotel_Phone_Num = new System.Windows.Forms.TextBox();
            this.Hotel_City = new System.Windows.Forms.TextBox();
            this.Hotel_Address = new System.Windows.Forms.TextBox();
            this.Hotel_Name = new System.Windows.Forms.TextBox();
            this.Hotel_Staff_Pass = new System.Windows.Forms.TextBox();
            this.Hotel_Staff_EmailAddresss = new System.Windows.Forms.TextBox();
            this.Hotel_Staff_PhoneNum = new System.Windows.Forms.TextBox();
            this.Hotel_Staff_Address = new System.Windows.Forms.TextBox();
            this.Button_Add_HotelEmp = new System.Windows.Forms.Button();
            this.Hotel_Description = new System.Windows.Forms.TextBox();
            this.Hotel_Room_Type = new System.Windows.Forms.TextBox();
            this.Hotel_Room_ID = new System.Windows.Forms.TextBox();
            this.Button_Add_Room = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Hotel_Staff_DOB = new System.Windows.Forms.DateTimePicker();
            this.hotelModelDataSet = new HotelDataBase.HotelModelDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new HotelDataBase.HotelModelDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new HotelDataBase.HotelModelDataSetTableAdapters.TableAdapterManager();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            staff_IdLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            dOBLabel = new System.Windows.Forms.Label();
            addrsLabel = new System.Windows.Forms.Label();
            phone_noLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passLabel = new System.Windows.Forms.Label();
            room_IdLabel = new System.Windows.Forms.Label();
            room_TypeLabel = new System.Windows.Forms.Label();
            room_DescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_Employee_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelModelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // staff_IdLabel
            // 
            staff_IdLabel.AutoSize = true;
            staff_IdLabel.Location = new System.Drawing.Point(544, 28);
            staff_IdLabel.Name = "staff_IdLabel";
            staff_IdLabel.Size = new System.Drawing.Size(44, 13);
            staff_IdLabel.TabIndex = 47;
            staff_IdLabel.Text = "Staff Id:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(544, 54);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(58, 13);
            first_nameLabel.TabIndex = 48;
            first_nameLabel.Text = "First name:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(544, 80);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(59, 13);
            last_nameLabel.TabIndex = 49;
            last_nameLabel.Text = "Last name:";
            // 
            // dOBLabel
            // 
            dOBLabel.AutoSize = true;
            dOBLabel.Location = new System.Drawing.Point(544, 107);
            dOBLabel.Name = "dOBLabel";
            dOBLabel.Size = new System.Drawing.Size(33, 13);
            dOBLabel.TabIndex = 50;
            dOBLabel.Text = "DOB:";
            // 
            // addrsLabel
            // 
            addrsLabel.AutoSize = true;
            addrsLabel.Location = new System.Drawing.Point(544, 132);
            addrsLabel.Name = "addrsLabel";
            addrsLabel.Size = new System.Drawing.Size(37, 13);
            addrsLabel.TabIndex = 51;
            addrsLabel.Text = "Addrs:";
            // 
            // phone_noLabel
            // 
            phone_noLabel.AutoSize = true;
            phone_noLabel.Location = new System.Drawing.Point(544, 158);
            phone_noLabel.Name = "phone_noLabel";
            phone_noLabel.Size = new System.Drawing.Size(56, 13);
            phone_noLabel.TabIndex = 52;
            phone_noLabel.Text = "Phone no:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(544, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 53;
            emailLabel.Text = "Email:";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new System.Drawing.Point(544, 210);
            passLabel.Name = "passLabel";
            passLabel.Size = new System.Drawing.Size(33, 13);
            passLabel.TabIndex = 54;
            passLabel.Text = "Pass:";
            // 
            // room_IdLabel
            // 
            room_IdLabel.AutoSize = true;
            room_IdLabel.Location = new System.Drawing.Point(2, 345);
            room_IdLabel.Name = "room_IdLabel";
            room_IdLabel.Size = new System.Drawing.Size(50, 13);
            room_IdLabel.TabIndex = 62;
            room_IdLabel.Text = "Room Id:";
            // 
            // room_TypeLabel
            // 
            room_TypeLabel.AutoSize = true;
            room_TypeLabel.Location = new System.Drawing.Point(-3, 371);
            room_TypeLabel.Name = "room_TypeLabel";
            room_TypeLabel.Size = new System.Drawing.Size(65, 13);
            room_TypeLabel.TabIndex = 64;
            room_TypeLabel.Text = "Room Type:";
            // 
            // room_DescriptionLabel
            // 
            room_DescriptionLabel.AutoSize = true;
            room_DescriptionLabel.Location = new System.Drawing.Point(-3, 399);
            room_DescriptionLabel.Name = "room_DescriptionLabel";
            room_DescriptionLabel.Size = new System.Drawing.Size(94, 13);
            room_DescriptionLabel.TabIndex = 65;
            room_DescriptionLabel.Text = "Room Description:";
            // 
            // Button_Add_Hotel
            // 
            this.Button_Add_Hotel.Location = new System.Drawing.Point(24, 169);
            this.Button_Add_Hotel.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Add_Hotel.Name = "Button_Add_Hotel";
            this.Button_Add_Hotel.Size = new System.Drawing.Size(77, 19);
            this.Button_Add_Hotel.TabIndex = 3;
            this.Button_Add_Hotel.Text = "Add Hotel";
            this.Button_Add_Hotel.UseVisualStyleBackColor = true;
            this.Button_Add_Hotel.Click += new System.EventHandler(this.Button_Add_Hotel_Click);
            // 
            // Hotel_id
            // 
            this.Hotel_id.Location = new System.Drawing.Point(66, 31);
            this.Hotel_id.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_id.Name = "Hotel_id";
            this.Hotel_id.Size = new System.Drawing.Size(76, 20);
            this.Hotel_id.TabIndex = 4;
            // 
            // Hotel_Employee_DataGrid
            // 
            this.Hotel_Employee_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hotel_Employee_DataGrid.Location = new System.Drawing.Point(815, 2);
            this.Hotel_Employee_DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Employee_DataGrid.Name = "Hotel_Employee_DataGrid";
            this.Hotel_Employee_DataGrid.RowTemplate.Height = 24;
            this.Hotel_Employee_DataGrid.Size = new System.Drawing.Size(302, 228);
            this.Hotel_Employee_DataGrid.TabIndex = 5;
            // 
            // Hotel_DataGrid
            // 
            this.Hotel_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hotel_DataGrid.Location = new System.Drawing.Point(164, 2);
            this.Hotel_DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_DataGrid.Name = "Hotel_DataGrid";
            this.Hotel_DataGrid.RowTemplate.Height = 24;
            this.Hotel_DataGrid.Size = new System.Drawing.Size(302, 233);
            this.Hotel_DataGrid.TabIndex = 0;
            // 
            // Hotel_Staff_ID
            // 
            this.Hotel_Staff_ID.Location = new System.Drawing.Point(610, 28);
            this.Hotel_Staff_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Staff_ID.Name = "Hotel_Staff_ID";
            this.Hotel_Staff_ID.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Staff_ID.TabIndex = 7;
            // 
            // Hotel_Staff_First_Name
            // 
            this.Hotel_Staff_First_Name.Location = new System.Drawing.Point(610, 51);
            this.Hotel_Staff_First_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Staff_First_Name.Name = "Hotel_Staff_First_Name";
            this.Hotel_Staff_First_Name.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Staff_First_Name.TabIndex = 8;
            // 
            // Hotel_Staff_LastName
            // 
            this.Hotel_Staff_LastName.Location = new System.Drawing.Point(610, 76);
            this.Hotel_Staff_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Staff_LastName.Name = "Hotel_Staff_LastName";
            this.Hotel_Staff_LastName.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Staff_LastName.TabIndex = 9;
            // 
            // Hotel_Phone_Num
            // 
            this.Hotel_Phone_Num.Location = new System.Drawing.Point(66, 122);
            this.Hotel_Phone_Num.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Phone_Num.Name = "Hotel_Phone_Num";
            this.Hotel_Phone_Num.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Phone_Num.TabIndex = 11;
            // 
            // Hotel_City
            // 
            this.Hotel_City.Location = new System.Drawing.Point(66, 99);
            this.Hotel_City.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_City.Name = "Hotel_City";
            this.Hotel_City.Size = new System.Drawing.Size(76, 20);
            this.Hotel_City.TabIndex = 12;
            // 
            // Hotel_Address
            // 
            this.Hotel_Address.Location = new System.Drawing.Point(66, 76);
            this.Hotel_Address.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Address.Name = "Hotel_Address";
            this.Hotel_Address.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Address.TabIndex = 13;
            // 
            // Hotel_Name
            // 
            this.Hotel_Name.Location = new System.Drawing.Point(66, 54);
            this.Hotel_Name.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Name.Name = "Hotel_Name";
            this.Hotel_Name.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Name.TabIndex = 14;
            // 
            // Hotel_Staff_Pass
            // 
            this.Hotel_Staff_Pass.Location = new System.Drawing.Point(610, 208);
            this.Hotel_Staff_Pass.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Staff_Pass.Name = "Hotel_Staff_Pass";
            this.Hotel_Staff_Pass.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Staff_Pass.TabIndex = 18;
            // 
            // Hotel_Staff_EmailAddresss
            // 
            this.Hotel_Staff_EmailAddresss.Location = new System.Drawing.Point(610, 184);
            this.Hotel_Staff_EmailAddresss.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Staff_EmailAddresss.Name = "Hotel_Staff_EmailAddresss";
            this.Hotel_Staff_EmailAddresss.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Staff_EmailAddresss.TabIndex = 17;
            // 
            // Hotel_Staff_PhoneNum
            // 
            this.Hotel_Staff_PhoneNum.Location = new System.Drawing.Point(610, 157);
            this.Hotel_Staff_PhoneNum.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Staff_PhoneNum.Name = "Hotel_Staff_PhoneNum";
            this.Hotel_Staff_PhoneNum.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Staff_PhoneNum.TabIndex = 16;
            // 
            // Hotel_Staff_Address
            // 
            this.Hotel_Staff_Address.Location = new System.Drawing.Point(610, 132);
            this.Hotel_Staff_Address.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Staff_Address.Name = "Hotel_Staff_Address";
            this.Hotel_Staff_Address.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Staff_Address.TabIndex = 15;
            // 
            // Button_Add_HotelEmp
            // 
            this.Button_Add_HotelEmp.Location = new System.Drawing.Point(711, 197);
            this.Button_Add_HotelEmp.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Add_HotelEmp.Name = "Button_Add_HotelEmp";
            this.Button_Add_HotelEmp.Size = new System.Drawing.Size(82, 33);
            this.Button_Add_HotelEmp.TabIndex = 19;
            this.Button_Add_HotelEmp.Text = "Add Emp";
            this.Button_Add_HotelEmp.UseVisualStyleBackColor = true;
            this.Button_Add_HotelEmp.Click += new System.EventHandler(this.Button_Add_HotelEmp_Click);
            // 
            // Hotel_Description
            // 
            this.Hotel_Description.Location = new System.Drawing.Point(96, 392);
            this.Hotel_Description.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Description.Name = "Hotel_Description";
            this.Hotel_Description.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Description.TabIndex = 22;
            // 
            // Hotel_Room_Type
            // 
            this.Hotel_Room_Type.Location = new System.Drawing.Point(96, 368);
            this.Hotel_Room_Type.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Room_Type.Name = "Hotel_Room_Type";
            this.Hotel_Room_Type.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Room_Type.TabIndex = 21;
            // 
            // Hotel_Room_ID
            // 
            this.Hotel_Room_ID.Location = new System.Drawing.Point(96, 345);
            this.Hotel_Room_ID.Margin = new System.Windows.Forms.Padding(2);
            this.Hotel_Room_ID.Name = "Hotel_Room_ID";
            this.Hotel_Room_ID.Size = new System.Drawing.Size(76, 20);
            this.Hotel_Room_ID.TabIndex = 20;
            // 
            // Button_Add_Room
            // 
            this.Button_Add_Room.Location = new System.Drawing.Point(40, 464);
            this.Button_Add_Room.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Add_Room.Name = "Button_Add_Room";
            this.Button_Add_Room.Size = new System.Drawing.Size(79, 19);
            this.Button_Add_Room.TabIndex = 23;
            this.Button_Add_Room.Text = "Add Room";
            this.Button_Add_Room.UseVisualStyleBackColor = true;
            this.Button_Add_Room.Click += new System.EventHandler(this.Button_Add_Room_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "hotel id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "phone num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "city";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "address";
            // 
            // Hotel_Staff_DOB
            // 
            this.Hotel_Staff_DOB.Location = new System.Drawing.Point(583, 102);
            this.Hotel_Staff_DOB.Name = "Hotel_Staff_DOB";
            this.Hotel_Staff_DOB.Size = new System.Drawing.Size(200, 20);
            this.Hotel_Staff_DOB.TabIndex = 29;
            // 
            // hotelModelDataSet
            // 
            this.hotelModelDataSet.DataSetName = "HotelModelDataSet";
            this.hotelModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hotelModelDataSet;
            this.employeeBindingSource.CurrentChanged += new System.EventHandler(this.employeeBindingSource_CurrentChanged);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.HotelTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.Room_typeTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelDataBase.HotelModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.AutoGenerateColumns = false;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.employeeDataGridView.DataSource = this.employeeBindingSource;
            this.employeeDataGridView.Location = new System.Drawing.Point(216, 263);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(300, 220);
            this.employeeDataGridView.TabIndex = 66;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Staff_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Staff_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn4.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Addrs";
            this.dataGridViewTextBoxColumn5.HeaderText = "Addrs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Phone_no";
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone_no";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Pass";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pass";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Hotel_Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Hotel_Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // AdminHotelManagementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(room_IdLabel);
            this.Controls.Add(room_TypeLabel);
            this.Controls.Add(room_DescriptionLabel);
            this.Controls.Add(staff_IdLabel);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(dOBLabel);
            this.Controls.Add(addrsLabel);
            this.Controls.Add(phone_noLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(passLabel);
            this.Controls.Add(this.Hotel_Staff_DOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Add_Room);
            this.Controls.Add(this.Hotel_Description);
            this.Controls.Add(this.Hotel_Room_Type);
            this.Controls.Add(this.Hotel_Room_ID);
            this.Controls.Add(this.Button_Add_HotelEmp);
            this.Controls.Add(this.Hotel_Staff_Pass);
            this.Controls.Add(this.Hotel_Staff_EmailAddresss);
            this.Controls.Add(this.Hotel_Staff_PhoneNum);
            this.Controls.Add(this.Hotel_Staff_Address);
            this.Controls.Add(this.Hotel_Name);
            this.Controls.Add(this.Hotel_Address);
            this.Controls.Add(this.Hotel_City);
            this.Controls.Add(this.Hotel_Phone_Num);
            this.Controls.Add(this.Hotel_Staff_LastName);
            this.Controls.Add(this.Hotel_Staff_First_Name);
            this.Controls.Add(this.Hotel_Staff_ID);
            this.Controls.Add(this.Hotel_Employee_DataGrid);
            this.Controls.Add(this.Hotel_id);
            this.Controls.Add(this.Button_Add_Hotel);
            this.Controls.Add(this.Hotel_DataGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminHotelManagementUC";
            this.Size = new System.Drawing.Size(1167, 561);
            this.Load += new System.EventHandler(this.AdminHotelManagementUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_Employee_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hotel_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelModelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion
        private System.Windows.Forms.Button Button_Add_Hotel;
        private System.Windows.Forms.TextBox Hotel_id;
        private System.Windows.Forms.DataGridView Hotel_Employee_DataGrid;
        private System.Windows.Forms.DataGridView Hotel_DataGrid;
        private System.Windows.Forms.TextBox Hotel_Staff_ID;
        private System.Windows.Forms.TextBox Hotel_Staff_First_Name;
        private System.Windows.Forms.TextBox Hotel_Staff_LastName;
        private System.Windows.Forms.TextBox Hotel_Phone_Num;
        private System.Windows.Forms.TextBox Hotel_City;
        private System.Windows.Forms.TextBox Hotel_Address;
        private System.Windows.Forms.TextBox Hotel_Name;
        private System.Windows.Forms.TextBox Hotel_Staff_Pass;
        private System.Windows.Forms.TextBox Hotel_Staff_EmailAddresss;
        private System.Windows.Forms.TextBox Hotel_Staff_PhoneNum;
        private System.Windows.Forms.TextBox Hotel_Staff_Address;
        private System.Windows.Forms.Button Button_Add_HotelEmp;
        private System.Windows.Forms.TextBox Hotel_Description;
        private System.Windows.Forms.TextBox Hotel_Room_Type;
        private System.Windows.Forms.TextBox Hotel_Room_ID;
        private System.Windows.Forms.Button Button_Add_Room;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Hotel_Staff_DOB;
        private HotelModelDataSet hotelModelDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HotelModelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private HotelModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}
