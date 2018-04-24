namespace HotelDataBase
{
    partial class CustomerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerSearchAndReserveUC1 = new HotelDataBase.CustomerSearchAndReserveUC();
            this.SuspendLayout();
            // 
            // customerSearchAndReserveUC1
            // 
            this.customerSearchAndReserveUC1.Location = new System.Drawing.Point(22, 12);
            this.customerSearchAndReserveUC1.Name = "customerSearchAndReserveUC1";
            this.customerSearchAndReserveUC1.Size = new System.Drawing.Size(1080, 485);
            this.customerSearchAndReserveUC1.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 570);
            this.Controls.Add(this.customerSearchAndReserveUC1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomerSearchAndReserveUC customerSearchAndReserveUC1;
    }
}