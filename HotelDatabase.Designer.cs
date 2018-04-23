namespace HotelDataBase
{
    partial class HotelDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelDatabase));
            System.Windows.Forms.Label hotel_IdLabel;
            System.Windows.Forms.Label hotelNameLabel;
            System.Windows.Forms.Label addrsLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phone_noLabel;
            this.hotelModelDataSet = new HotelDataBase.HotelModelDataSet();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelTableAdapter = new HotelDataBase.HotelModelDataSetTableAdapters.HotelTableAdapter();
            this.tableAdapterManager = new HotelDataBase.HotelModelDataSetTableAdapters.TableAdapterManager();
            this.employeeTableAdapter = new HotelDataBase.HotelModelDataSetTableAdapters.EmployeeTableAdapter();
            this.hotelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hotelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_IdTextBox = new System.Windows.Forms.TextBox();
            this.hotelNameTextBox = new System.Windows.Forms.TextBox();
            this.addrsTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phone_noTextBox = new System.Windows.Forms.TextBox();
            this.hotelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hotel_IdLabel = new System.Windows.Forms.Label();
            hotelNameLabel = new System.Windows.Forms.Label();
            addrsLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phone_noLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelModelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingNavigator)).BeginInit();
            this.hotelBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelModelDataSet
            // 
            this.hotelModelDataSet.DataSetName = "HotelModelDataSet";
            this.hotelModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.hotelModelDataSet;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.HotelTableAdapter = this.hotelTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.Room_typeTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelDataBase.HotelModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // hotelBindingNavigator
            // 
            this.hotelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hotelBindingNavigator.BindingSource = this.hotelBindingSource;
            this.hotelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hotelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hotelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hotelBindingNavigatorSaveItem});
            this.hotelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hotelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hotelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hotelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hotelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hotelBindingNavigator.Name = "hotelBindingNavigator";
            this.hotelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hotelBindingNavigator.Size = new System.Drawing.Size(1117, 25);
            this.hotelBindingNavigator.TabIndex = 0;
            this.hotelBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // hotelBindingNavigatorSaveItem
            // 
            this.hotelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hotelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelBindingNavigatorSaveItem.Image")));
            this.hotelBindingNavigatorSaveItem.Name = "hotelBindingNavigatorSaveItem";
            this.hotelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.hotelBindingNavigatorSaveItem.Text = "Save Data";
            this.hotelBindingNavigatorSaveItem.Click += new System.EventHandler(this.hotelBindingNavigatorSaveItem_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "FK__Employee__Hotel___440B1D61";
            this.employeeBindingSource.DataSource = this.hotelBindingSource;
            // 
            // hotel_IdLabel
            // 
            hotel_IdLabel.AutoSize = true;
            hotel_IdLabel.Location = new System.Drawing.Point(79, 137);
            hotel_IdLabel.Name = "hotel_IdLabel";
            hotel_IdLabel.Size = new System.Drawing.Size(47, 13);
            hotel_IdLabel.TabIndex = 1;
            hotel_IdLabel.Text = "Hotel Id:";
            // 
            // hotel_IdTextBox
            // 
            this.hotel_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "Hotel_Id", true));
            this.hotel_IdTextBox.Location = new System.Drawing.Point(151, 134);
            this.hotel_IdTextBox.Name = "hotel_IdTextBox";
            this.hotel_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.hotel_IdTextBox.TabIndex = 2;
            // 
            // hotelNameLabel
            // 
            hotelNameLabel.AutoSize = true;
            hotelNameLabel.Location = new System.Drawing.Point(79, 163);
            hotelNameLabel.Name = "hotelNameLabel";
            hotelNameLabel.Size = new System.Drawing.Size(66, 13);
            hotelNameLabel.TabIndex = 3;
            hotelNameLabel.Text = "Hotel Name:";
            // 
            // hotelNameTextBox
            // 
            this.hotelNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "HotelName", true));
            this.hotelNameTextBox.Location = new System.Drawing.Point(151, 160);
            this.hotelNameTextBox.Name = "hotelNameTextBox";
            this.hotelNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.hotelNameTextBox.TabIndex = 4;
            // 
            // addrsLabel
            // 
            addrsLabel.AutoSize = true;
            addrsLabel.Location = new System.Drawing.Point(79, 189);
            addrsLabel.Name = "addrsLabel";
            addrsLabel.Size = new System.Drawing.Size(37, 13);
            addrsLabel.TabIndex = 5;
            addrsLabel.Text = "Addrs:";
            // 
            // addrsTextBox
            // 
            this.addrsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "Addrs", true));
            this.addrsTextBox.Location = new System.Drawing.Point(151, 186);
            this.addrsTextBox.Name = "addrsTextBox";
            this.addrsTextBox.Size = new System.Drawing.Size(100, 20);
            this.addrsTextBox.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(79, 215);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(27, 13);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(151, 212);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // phone_noLabel
            // 
            phone_noLabel.AutoSize = true;
            phone_noLabel.Location = new System.Drawing.Point(79, 241);
            phone_noLabel.Name = "phone_noLabel";
            phone_noLabel.Size = new System.Drawing.Size(56, 13);
            phone_noLabel.TabIndex = 9;
            phone_noLabel.Text = "Phone no:";
            // 
            // phone_noTextBox
            // 
            this.phone_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hotelBindingSource, "Phone_no", true));
            this.phone_noTextBox.Location = new System.Drawing.Point(151, 238);
            this.phone_noTextBox.Name = "phone_noTextBox";
            this.phone_noTextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_noTextBox.TabIndex = 10;
            // 
            // hotelDataGridView
            // 
            this.hotelDataGridView.AutoGenerateColumns = false;
            this.hotelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.hotelDataGridView.DataSource = this.hotelBindingSource;
            this.hotelDataGridView.Location = new System.Drawing.Point(346, 98);
            this.hotelDataGridView.Name = "hotelDataGridView";
            this.hotelDataGridView.Size = new System.Drawing.Size(300, 220);
            this.hotelDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Hotel_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Hotel_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HotelName";
            this.dataGridViewTextBoxColumn2.HeaderText = "HotelName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Addrs";
            this.dataGridViewTextBoxColumn3.HeaderText = "Addrs";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Phone_no";
            this.dataGridViewTextBoxColumn5.HeaderText = "Phone_no";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // HotelDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hotelDataGridView);
            this.Controls.Add(hotel_IdLabel);
            this.Controls.Add(this.hotel_IdTextBox);
            this.Controls.Add(hotelNameLabel);
            this.Controls.Add(this.hotelNameTextBox);
            this.Controls.Add(addrsLabel);
            this.Controls.Add(this.addrsTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(phone_noLabel);
            this.Controls.Add(this.phone_noTextBox);
            this.Controls.Add(this.hotelBindingNavigator);
            this.Name = "HotelDatabase";
            this.Size = new System.Drawing.Size(1117, 485);
            ((System.ComponentModel.ISupportInitialize)(this.hotelModelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingNavigator)).EndInit();
            this.hotelBindingNavigator.ResumeLayout(false);
            this.hotelBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelModelDataSet hotelModelDataSet;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private HotelModelDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private HotelModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hotelBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hotelBindingNavigatorSaveItem;
        private HotelModelDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox hotel_IdTextBox;
        private System.Windows.Forms.TextBox hotelNameTextBox;
        private System.Windows.Forms.TextBox addrsTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox phone_noTextBox;
        private System.Windows.Forms.DataGridView hotelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
