namespace HotelDataBase
{
    partial class CustomerSignInUC
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
            this.button1 = new System.Windows.Forms.Button();
            this.Bt_CreateAccount = new System.Windows.Forms.Button();
            this.TB_CustomerLogin_LastName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TB_CustomerLogin_FirstName = new System.Windows.Forms.TextBox();
            this.TB_CustomerLogin_Password = new System.Windows.Forms.TextBox();
            this.TB_CustomerLogin_Email = new System.Windows.Forms.TextBox();
            this.TB_CustomerLogin_PhoneNum = new System.Windows.Forms.TextBox();
            this.TB_CustomerLogin_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_CreateAccount
            // 
            this.Bt_CreateAccount.Location = new System.Drawing.Point(178, 254);
            this.Bt_CreateAccount.Name = "Bt_CreateAccount";
            this.Bt_CreateAccount.Size = new System.Drawing.Size(75, 23);
            this.Bt_CreateAccount.TabIndex = 1;
            this.Bt_CreateAccount.Text = "Create account";
            this.Bt_CreateAccount.UseVisualStyleBackColor = true;
            this.Bt_CreateAccount.Click += new System.EventHandler(this.Bt_CreateAccount_Click);
            // 
            // TB_CustomerLogin_LastName
            // 
            this.TB_CustomerLogin_LastName.Location = new System.Drawing.Point(169, 109);
            this.TB_CustomerLogin_LastName.Name = "TB_CustomerLogin_LastName";
            this.TB_CustomerLogin_LastName.Size = new System.Drawing.Size(100, 20);
            this.TB_CustomerLogin_LastName.TabIndex = 2;
           
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TB_CustomerLogin_FirstName
            // 
            this.TB_CustomerLogin_FirstName.Location = new System.Drawing.Point(169, 83);
            this.TB_CustomerLogin_FirstName.Name = "TB_CustomerLogin_FirstName";
            this.TB_CustomerLogin_FirstName.Size = new System.Drawing.Size(100, 20);
            this.TB_CustomerLogin_FirstName.TabIndex = 4;
            // 
            // TB_CustomerLogin_Password
            // 
            this.TB_CustomerLogin_Password.Location = new System.Drawing.Point(169, 213);
            this.TB_CustomerLogin_Password.Name = "TB_CustomerLogin_Password";
            this.TB_CustomerLogin_Password.Size = new System.Drawing.Size(100, 20);
            this.TB_CustomerLogin_Password.TabIndex = 5;
            // 
            // TB_CustomerLogin_Email
            // 
            this.TB_CustomerLogin_Email.Location = new System.Drawing.Point(169, 187);
            this.TB_CustomerLogin_Email.Name = "TB_CustomerLogin_Email";
            this.TB_CustomerLogin_Email.Size = new System.Drawing.Size(100, 20);
            this.TB_CustomerLogin_Email.TabIndex = 6;
            // 
            // TB_CustomerLogin_PhoneNum
            // 
            this.TB_CustomerLogin_PhoneNum.Location = new System.Drawing.Point(169, 161);
            this.TB_CustomerLogin_PhoneNum.Name = "TB_CustomerLogin_PhoneNum";
            this.TB_CustomerLogin_PhoneNum.Size = new System.Drawing.Size(100, 20);
            this.TB_CustomerLogin_PhoneNum.TabIndex = 7;
            // 
            // TB_CustomerLogin_Address
            // 
            this.TB_CustomerLogin_Address.Location = new System.Drawing.Point(169, 135);
            this.TB_CustomerLogin_Address.Name = "TB_CustomerLogin_Address";
            this.TB_CustomerLogin_Address.Size = new System.Drawing.Size(100, 20);
            this.TB_CustomerLogin_Address.TabIndex = 8;
            // 
            // CustomerSignInUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TB_CustomerLogin_Address);
            this.Controls.Add(this.TB_CustomerLogin_PhoneNum);
            this.Controls.Add(this.TB_CustomerLogin_Email);
            this.Controls.Add(this.TB_CustomerLogin_Password);
            this.Controls.Add(this.TB_CustomerLogin_FirstName);
            this.Controls.Add(this.TB_CustomerLogin_LastName);
            this.Controls.Add(this.Bt_CreateAccount);
            this.Controls.Add(this.button1);
            this.Name = "CustomerSignInUC";
            this.Size = new System.Drawing.Size(446, 433);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bt_CreateAccount;
        private System.Windows.Forms.TextBox TB_CustomerLogin_LastName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TB_CustomerLogin_FirstName;
        private System.Windows.Forms.TextBox TB_CustomerLogin_Password;
        private System.Windows.Forms.TextBox TB_CustomerLogin_Email;
        private System.Windows.Forms.TextBox TB_CustomerLogin_PhoneNum;
        private System.Windows.Forms.TextBox TB_CustomerLogin_Address;
    }
}
