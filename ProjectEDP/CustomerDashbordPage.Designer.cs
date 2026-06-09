namespace ProjectEDP
{
    partial class CustomerDashbord
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
            this.reserveLbl = new System.Windows.Forms.Label();
            this.ServiceLbl = new System.Windows.Forms.Label();
            this.pickupChkBox = new System.Windows.Forms.CheckBox();
            this.DeliveryChkBox = new System.Windows.Forms.CheckBox();
            this.SpecialChkBox = new System.Windows.Forms.CheckBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.morningRB = new System.Windows.Forms.RadioButton();
            this.eveningRB = new System.Windows.Forms.RadioButton();
            this.nightRB = new System.Windows.Forms.RadioButton();
            this.TimeSlotGpBox = new System.Windows.Forms.GroupBox();
            this.DetailsLbl = new System.Windows.Forms.Label();
            this.TimeSlotGpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reserveLbl
            // 
            this.reserveLbl.AutoSize = true;
            this.reserveLbl.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLbl.Location = new System.Drawing.Point(315, 34);
            this.reserveLbl.Name = "reserveLbl";
            this.reserveLbl.Size = new System.Drawing.Size(509, 59);
            this.reserveLbl.TabIndex = 0;
            this.reserveLbl.Text = "Make A Reservation";
            this.reserveLbl.Click += new System.EventHandler(this.reserveLbl_Click);
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Location = new System.Drawing.Point(48, 192);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(129, 16);
            this.ServiceLbl.TabIndex = 1;
            this.ServiceLbl.Text = "Select Service Type";
            // 
            // pickupChkBox
            // 
            this.pickupChkBox.AutoSize = true;
            this.pickupChkBox.Location = new System.Drawing.Point(51, 222);
            this.pickupChkBox.Name = "pickupChkBox";
            this.pickupChkBox.Size = new System.Drawing.Size(73, 20);
            this.pickupChkBox.TabIndex = 2;
            this.pickupChkBox.Text = "Pickup ";
            this.pickupChkBox.UseVisualStyleBackColor = true;
            // 
            // DeliveryChkBox
            // 
            this.DeliveryChkBox.AutoSize = true;
            this.DeliveryChkBox.Location = new System.Drawing.Point(51, 248);
            this.DeliveryChkBox.Name = "DeliveryChkBox";
            this.DeliveryChkBox.Size = new System.Drawing.Size(79, 20);
            this.DeliveryChkBox.TabIndex = 3;
            this.DeliveryChkBox.Text = "Delivery";
            this.DeliveryChkBox.UseVisualStyleBackColor = true;
            // 
            // SpecialChkBox
            // 
            this.SpecialChkBox.AutoSize = true;
            this.SpecialChkBox.Location = new System.Drawing.Point(51, 274);
            this.SpecialChkBox.Name = "SpecialChkBox";
            this.SpecialChkBox.Size = new System.Drawing.Size(139, 20);
            this.SpecialChkBox.TabIndex = 4;
            this.SpecialChkBox.Text = "Speciality Laundry";
            this.SpecialChkBox.UseVisualStyleBackColor = true;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(444, 248);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(204, 58);
            this.AddressTxtBox.TabIndex = 5;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(441, 222);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(123, 16);
            this.AddressLbl.TabIndex = 6;
            this.AddressLbl.Text = "Enter Your Address";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(52, 310);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(36, 16);
            this.DateLbl.TabIndex = 7;
            this.DateLbl.Text = "Date";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(51, 329);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(225, 22);
            this.dateTimePickerOrder.TabIndex = 8;
            // 
            // morningRB
            // 
            this.morningRB.AutoSize = true;
            this.morningRB.Location = new System.Drawing.Point(6, 21);
            this.morningRB.Name = "morningRB";
            this.morningRB.Size = new System.Drawing.Size(116, 20);
            this.morningRB.TabIndex = 10;
            this.morningRB.TabStop = true;
            this.morningRB.Text = "8:00 - 11:00 AM";
            this.morningRB.UseVisualStyleBackColor = true;
            // 
            // eveningRB
            // 
            this.eveningRB.AutoSize = true;
            this.eveningRB.Location = new System.Drawing.Point(6, 47);
            this.eveningRB.Name = "eveningRB";
            this.eveningRB.Size = new System.Drawing.Size(123, 20);
            this.eveningRB.TabIndex = 11;
            this.eveningRB.TabStop = true;
            this.eveningRB.Text = "12:00 - 14:00 PM";
            this.eveningRB.UseVisualStyleBackColor = true;
            // 
            // nightRB
            // 
            this.nightRB.AutoSize = true;
            this.nightRB.Location = new System.Drawing.Point(6, 73);
            this.nightRB.Name = "nightRB";
            this.nightRB.Size = new System.Drawing.Size(123, 20);
            this.nightRB.TabIndex = 12;
            this.nightRB.TabStop = true;
            this.nightRB.Text = "16:00 - 20:00 PM";
            this.nightRB.UseVisualStyleBackColor = true;
            // 
            // TimeSlotGpBox
            // 
            this.TimeSlotGpBox.Controls.Add(this.morningRB);
            this.TimeSlotGpBox.Controls.Add(this.nightRB);
            this.TimeSlotGpBox.Controls.Add(this.eveningRB);
            this.TimeSlotGpBox.Location = new System.Drawing.Point(51, 370);
            this.TimeSlotGpBox.Name = "TimeSlotGpBox";
            this.TimeSlotGpBox.Size = new System.Drawing.Size(200, 100);
            this.TimeSlotGpBox.TabIndex = 13;
            this.TimeSlotGpBox.TabStop = false;
            this.TimeSlotGpBox.Text = "Pick Time Slot";
            // 
            // DetailsLbl
            // 
            this.DetailsLbl.AutoSize = true;
            this.DetailsLbl.Location = new System.Drawing.Point(441, 192);
            this.DetailsLbl.Name = "DetailsLbl";
            this.DetailsLbl.Size = new System.Drawing.Size(108, 16);
            this.DetailsLbl.TabIndex = 14;
            this.DetailsLbl.Text = "Delivery Details :";
            // 
            // CustomerDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1144, 634);
            this.Controls.Add(this.DetailsLbl);
            this.Controls.Add(this.TimeSlotGpBox);
            this.Controls.Add(this.dateTimePickerOrder);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.AddressTxtBox);
            this.Controls.Add(this.SpecialChkBox);
            this.Controls.Add(this.DeliveryChkBox);
            this.Controls.Add(this.pickupChkBox);
            this.Controls.Add(this.ServiceLbl);
            this.Controls.Add(this.reserveLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerDashbord";
            this.Text = "Customer Dashbord";
            this.TimeSlotGpBox.ResumeLayout(false);
            this.TimeSlotGpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reserveLbl;
        private System.Windows.Forms.Label ServiceLbl;
        private System.Windows.Forms.CheckBox pickupChkBox;
        private System.Windows.Forms.CheckBox DeliveryChkBox;
        private System.Windows.Forms.CheckBox SpecialChkBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.RadioButton morningRB;
        private System.Windows.Forms.RadioButton eveningRB;
        private System.Windows.Forms.RadioButton nightRB;
        private System.Windows.Forms.GroupBox TimeSlotGpBox;
        private System.Windows.Forms.Label DetailsLbl;
    }
}