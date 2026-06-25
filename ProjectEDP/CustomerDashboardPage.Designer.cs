namespace ProjectEDP
{
    partial class CustomerDashboard
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
            this.paymentGrpBox = new System.Windows.Forms.GroupBox();
            this.CardRB = new System.Windows.Forms.RadioButton();
            this.OnlineRB = new System.Windows.Forms.RadioButton();
            this.CodRB = new System.Windows.Forms.RadioButton();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.grpSpecialtyOptions = new System.Windows.Forms.GroupBox();
            this.chkDryCleaning = new System.Windows.Forms.CheckBox();
            this.chkSensitiveSkin = new System.Windows.Forms.CheckBox();
            this.chkFolding = new System.Windows.Forms.CheckBox();
            this.chkSameDayDelivery = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeSlotGpBox.SuspendLayout();
            this.paymentGrpBox.SuspendLayout();
            this.grpSpecialtyOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // reserveLbl
            // 
            this.reserveLbl.AutoSize = true;
            this.reserveLbl.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reserveLbl.Location = new System.Drawing.Point(109, 68);
            this.reserveLbl.Name = "reserveLbl";
            this.reserveLbl.Size = new System.Drawing.Size(509, 59);
            this.reserveLbl.TabIndex = 0;
            this.reserveLbl.Text = "Make A Reservation";
            this.reserveLbl.Click += new System.EventHandler(this.reserveLbl_Click);
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ServiceLbl.Location = new System.Drawing.Point(132, 159);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(138, 18);
            this.ServiceLbl.TabIndex = 1;
            this.ServiceLbl.Text = "Select Service Type";
            // 
            // pickupChkBox
            // 
            this.pickupChkBox.AutoSize = true;
            this.pickupChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupChkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pickupChkBox.Location = new System.Drawing.Point(135, 188);
            this.pickupChkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickupChkBox.Name = "pickupChkBox";
            this.pickupChkBox.Size = new System.Drawing.Size(149, 22);
            this.pickupChkBox.TabIndex = 2;
            this.pickupChkBox.Text = "Wash Only (RM4)\r\n";
            this.pickupChkBox.UseVisualStyleBackColor = true;
            this.pickupChkBox.CheckedChanged += new System.EventHandler(this.pickupChkBox_CheckedChanged_1);
            this.pickupChkBox.Click += new System.EventHandler(this.pickupChkBox_CheckedChanged);
            // 
            // DeliveryChkBox
            // 
            this.DeliveryChkBox.AutoSize = true;
            this.DeliveryChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryChkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeliveryChkBox.Location = new System.Drawing.Point(135, 215);
            this.DeliveryChkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeliveryChkBox.Name = "DeliveryChkBox";
            this.DeliveryChkBox.Size = new System.Drawing.Size(170, 22);
            this.DeliveryChkBox.TabIndex = 3;
            this.DeliveryChkBox.Text = "Wash and Dry (RM9)\r\n";
            this.DeliveryChkBox.UseVisualStyleBackColor = true;
            this.DeliveryChkBox.Click += new System.EventHandler(this.DeliveryChkBox_CheckedChanged);
            // 
            // SpecialChkBox
            // 
            this.SpecialChkBox.AutoSize = true;
            this.SpecialChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialChkBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SpecialChkBox.Location = new System.Drawing.Point(135, 241);
            this.SpecialChkBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpecialChkBox.Name = "SpecialChkBox";
            this.SpecialChkBox.Size = new System.Drawing.Size(148, 22);
            this.SpecialChkBox.TabIndex = 4;
            this.SpecialChkBox.Text = "Speciality Laundry";
            this.SpecialChkBox.UseVisualStyleBackColor = true;
            this.SpecialChkBox.Click += new System.EventHandler(this.SpecialChkBox_CheckedChanged);
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(576, 208);
            this.AddressTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(263, 58);
            this.AddressTxtBox.TabIndex = 5;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddressLbl.Location = new System.Drawing.Point(573, 188);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(123, 16);
            this.AddressLbl.TabIndex = 6;
            this.AddressLbl.Text = "Enter Your Address";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.Transparent;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.Black;
            this.DateLbl.Location = new System.Drawing.Point(136, 277);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(84, 18);
            this.DateLbl.TabIndex = 7;
            this.DateLbl.Text = "Select Date";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(135, 295);
            this.dateTimePickerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(244, 22);
            this.dateTimePickerOrder.TabIndex = 8;
            this.dateTimePickerOrder.ValueChanged += new System.EventHandler(this.dateTimePickerOrder_ValueChanged);
            // 
            // morningRB
            // 
            this.morningRB.AutoSize = true;
            this.morningRB.Location = new System.Drawing.Point(5, 21);
            this.morningRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.morningRB.Name = "morningRB";
            this.morningRB.Size = new System.Drawing.Size(132, 22);
            this.morningRB.TabIndex = 10;
            this.morningRB.TabStop = true;
            this.morningRB.Text = "8:00 - 11:00 AM";
            this.morningRB.UseVisualStyleBackColor = true;
            // 
            // eveningRB
            // 
            this.eveningRB.AutoSize = true;
            this.eveningRB.Location = new System.Drawing.Point(5, 47);
            this.eveningRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eveningRB.Name = "eveningRB";
            this.eveningRB.Size = new System.Drawing.Size(141, 22);
            this.eveningRB.TabIndex = 11;
            this.eveningRB.TabStop = true;
            this.eveningRB.Text = "12:00 - 14:00 PM";
            this.eveningRB.UseVisualStyleBackColor = true;
            // 
            // nightRB
            // 
            this.nightRB.AutoSize = true;
            this.nightRB.Location = new System.Drawing.Point(5, 73);
            this.nightRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nightRB.Name = "nightRB";
            this.nightRB.Size = new System.Drawing.Size(141, 22);
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
            this.TimeSlotGpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeSlotGpBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeSlotGpBox.Location = new System.Drawing.Point(135, 337);
            this.TimeSlotGpBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeSlotGpBox.Name = "TimeSlotGpBox";
            this.TimeSlotGpBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeSlotGpBox.Size = new System.Drawing.Size(200, 100);
            this.TimeSlotGpBox.TabIndex = 13;
            this.TimeSlotGpBox.TabStop = false;
            this.TimeSlotGpBox.Text = "Pick Time Slot";
            // 
            // DetailsLbl
            // 
            this.DetailsLbl.AutoSize = true;
            this.DetailsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DetailsLbl.Location = new System.Drawing.Point(573, 159);
            this.DetailsLbl.Name = "DetailsLbl";
            this.DetailsLbl.Size = new System.Drawing.Size(117, 18);
            this.DetailsLbl.TabIndex = 14;
            this.DetailsLbl.Text = "Delivery Details :";
            // 
            // paymentGrpBox
            // 
            this.paymentGrpBox.Controls.Add(this.CardRB);
            this.paymentGrpBox.Controls.Add(this.OnlineRB);
            this.paymentGrpBox.Controls.Add(this.CodRB);
            this.paymentGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGrpBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paymentGrpBox.Location = new System.Drawing.Point(135, 465);
            this.paymentGrpBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentGrpBox.Name = "paymentGrpBox";
            this.paymentGrpBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentGrpBox.Size = new System.Drawing.Size(412, 48);
            this.paymentGrpBox.TabIndex = 16;
            this.paymentGrpBox.TabStop = false;
            this.paymentGrpBox.Text = "Select Payment Method";
            // 
            // CardRB
            // 
            this.CardRB.AutoSize = true;
            this.CardRB.Location = new System.Drawing.Point(255, 22);
            this.CardRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardRB.Name = "CardRB";
            this.CardRB.Size = new System.Drawing.Size(142, 22);
            this.CardRB.TabIndex = 2;
            this.CardRB.TabStop = true;
            this.CardRB.Text = "Card Credit/Debit";
            this.CardRB.UseVisualStyleBackColor = true;
            // 
            // OnlineRB
            // 
            this.OnlineRB.AutoSize = true;
            this.OnlineRB.Location = new System.Drawing.Point(81, 21);
            this.OnlineRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OnlineRB.Name = "OnlineRB";
            this.OnlineRB.Size = new System.Drawing.Size(161, 22);
            this.OnlineRB.TabIndex = 1;
            this.OnlineRB.TabStop = true;
            this.OnlineRB.Text = "FPX Online Banking";
            this.OnlineRB.UseVisualStyleBackColor = true;
            // 
            // CodRB
            // 
            this.CodRB.AutoSize = true;
            this.CodRB.Location = new System.Drawing.Point(5, 22);
            this.CodRB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodRB.Name = "CodRB";
            this.CodRB.Size = new System.Drawing.Size(64, 22);
            this.CodRB.TabIndex = 0;
            this.CodRB.TabStop = true;
            this.CodRB.Text = "Cash";
            this.CodRB.UseVisualStyleBackColor = true;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(968, 558);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(115, 44);
            this.SubmitBtn.TabIndex = 20;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(821, 559);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 44);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalAmount.Location = new System.Drawing.Point(582, 477);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(264, 31);
            this.lblTotalAmount.TabIndex = 22;
            this.lblTotalAmount.Text = "TOTAL AMOUNT:  ";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // grpSpecialtyOptions
            // 
            this.grpSpecialtyOptions.Controls.Add(this.chkDryCleaning);
            this.grpSpecialtyOptions.Controls.Add(this.chkSensitiveSkin);
            this.grpSpecialtyOptions.Controls.Add(this.chkFolding);
            this.grpSpecialtyOptions.Controls.Add(this.chkSameDayDelivery);
            this.grpSpecialtyOptions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpSpecialtyOptions.Location = new System.Drawing.Point(573, 295);
            this.grpSpecialtyOptions.Margin = new System.Windows.Forms.Padding(4);
            this.grpSpecialtyOptions.Name = "grpSpecialtyOptions";
            this.grpSpecialtyOptions.Padding = new System.Windows.Forms.Padding(4);
            this.grpSpecialtyOptions.Size = new System.Drawing.Size(295, 155);
            this.grpSpecialtyOptions.TabIndex = 23;
            this.grpSpecialtyOptions.TabStop = false;
            this.grpSpecialtyOptions.Text = "Specialty Options";
            this.grpSpecialtyOptions.Visible = false;
            this.grpSpecialtyOptions.Enter += new System.EventHandler(this.grpSpecialtyOptions_Enter);
            // 
            // chkDryCleaning
            // 
            this.chkDryCleaning.AutoSize = true;
            this.chkDryCleaning.Location = new System.Drawing.Point(0, 119);
            this.chkDryCleaning.Margin = new System.Windows.Forms.Padding(4);
            this.chkDryCleaning.Name = "chkDryCleaning";
            this.chkDryCleaning.Size = new System.Drawing.Size(152, 20);
            this.chkDryCleaning.TabIndex = 1;
            this.chkDryCleaning.Text = "Dry Cleaning (RM20)";
            this.chkDryCleaning.UseVisualStyleBackColor = true;
            this.chkDryCleaning.CheckedChanged += new System.EventHandler(this.chkDryCleaning_CheckedChanged);
            // 
            // chkSensitiveSkin
            // 
            this.chkSensitiveSkin.Location = new System.Drawing.Point(1, 84);
            this.chkSensitiveSkin.Margin = new System.Windows.Forms.Padding(4);
            this.chkSensitiveSkin.Name = "chkSensitiveSkin";
            this.chkSensitiveSkin.Size = new System.Drawing.Size(272, 28);
            this.chkSensitiveSkin.TabIndex = 0;
            this.chkSensitiveSkin.Text = "Sensitive Skin Laundry Care (RM20)";
            this.chkSensitiveSkin.UseVisualStyleBackColor = true;
            this.chkSensitiveSkin.CheckedChanged += new System.EventHandler(this.chkSensitiveSkin_CheckedChanged);
            // 
            // chkFolding
            // 
            this.chkFolding.Location = new System.Drawing.Point(0, 54);
            this.chkFolding.Margin = new System.Windows.Forms.Padding(4);
            this.chkFolding.Name = "chkFolding";
            this.chkFolding.Size = new System.Drawing.Size(184, 22);
            this.chkFolding.TabIndex = 0;
            this.chkFolding.Text = "Folding (RM5)";
            this.chkFolding.UseVisualStyleBackColor = true;
            this.chkFolding.CheckedChanged += new System.EventHandler(this.chkFolding_CheckedChanged);
            // 
            // chkSameDayDelivery
            // 
            this.chkSameDayDelivery.Location = new System.Drawing.Point(0, 25);
            this.chkSameDayDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.chkSameDayDelivery.Name = "chkSameDayDelivery";
            this.chkSameDayDelivery.Size = new System.Drawing.Size(216, 22);
            this.chkSameDayDelivery.TabIndex = 0;
            this.chkSameDayDelivery.Text = "Same Day Delivery (RM5)";
            this.chkSameDayDelivery.UseVisualStyleBackColor = true;
            this.chkSameDayDelivery.CheckedChanged += new System.EventHandler(this.chkSameDayDelivery_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(591, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Delivery charge is RM 3.00";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(177)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1112, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpSpecialtyOptions);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.paymentGrpBox);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerDashboard";
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.TimeSlotGpBox.ResumeLayout(false);
            this.TimeSlotGpBox.PerformLayout();
            this.paymentGrpBox.ResumeLayout(false);
            this.paymentGrpBox.PerformLayout();
            this.grpSpecialtyOptions.ResumeLayout(false);
            this.grpSpecialtyOptions.PerformLayout();
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
        private System.Windows.Forms.GroupBox paymentGrpBox;
        private System.Windows.Forms.RadioButton CardRB;
        private System.Windows.Forms.RadioButton OnlineRB;
        private System.Windows.Forms.RadioButton CodRB;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.GroupBox grpSpecialtyOptions;
        private System.Windows.Forms.CheckBox chkSensitiveSkin;
        private System.Windows.Forms.CheckBox chkFolding;
        private System.Windows.Forms.CheckBox chkSameDayDelivery;
        private System.Windows.Forms.CheckBox chkDryCleaning;
        private System.Windows.Forms.Label label1;
    }
}