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
            this.paymentGrpBox = new System.Windows.Forms.GroupBox();
            this.CardRB = new System.Windows.Forms.RadioButton();
            this.OnlineRB = new System.Windows.Forms.RadioButton();
            this.CodRB = new System.Windows.Forms.RadioButton();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.SpecialLbl = new System.Windows.Forms.Label();
            this.InstructionsTxt = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.TimeSlotGpBox.SuspendLayout();
            this.paymentGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reserveLbl
            // 
            this.reserveLbl.AutoSize = true;
            this.reserveLbl.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLbl.Location = new System.Drawing.Point(236, 28);
            this.reserveLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reserveLbl.Name = "reserveLbl";
            this.reserveLbl.Size = new System.Drawing.Size(411, 47);
            this.reserveLbl.TabIndex = 0;
            this.reserveLbl.Text = "Make A Reservation";
            this.reserveLbl.Click += new System.EventHandler(this.reserveLbl_Click);
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLbl.Location = new System.Drawing.Point(80, 142);
            this.ServiceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(113, 15);
            this.ServiceLbl.TabIndex = 1;
            this.ServiceLbl.Text = "Select Service Type";
            // 
            // pickupChkBox
            // 
            this.pickupChkBox.AutoSize = true;
            this.pickupChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupChkBox.Location = new System.Drawing.Point(82, 166);
            this.pickupChkBox.Margin = new System.Windows.Forms.Padding(2);
            this.pickupChkBox.Name = "pickupChkBox";
            this.pickupChkBox.Size = new System.Drawing.Size(66, 19);
            this.pickupChkBox.TabIndex = 2;
            this.pickupChkBox.Text = "Pickup ";
            this.pickupChkBox.UseVisualStyleBackColor = true;
            // 
            // DeliveryChkBox
            // 
            this.DeliveryChkBox.AutoSize = true;
            this.DeliveryChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryChkBox.Location = new System.Drawing.Point(82, 188);
            this.DeliveryChkBox.Margin = new System.Windows.Forms.Padding(2);
            this.DeliveryChkBox.Name = "DeliveryChkBox";
            this.DeliveryChkBox.Size = new System.Drawing.Size(69, 19);
            this.DeliveryChkBox.TabIndex = 3;
            this.DeliveryChkBox.Text = "Delivery";
            this.DeliveryChkBox.UseVisualStyleBackColor = true;
            // 
            // SpecialChkBox
            // 
            this.SpecialChkBox.AutoSize = true;
            this.SpecialChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialChkBox.Location = new System.Drawing.Point(82, 209);
            this.SpecialChkBox.Margin = new System.Windows.Forms.Padding(2);
            this.SpecialChkBox.Name = "SpecialChkBox";
            this.SpecialChkBox.Size = new System.Drawing.Size(125, 19);
            this.SpecialChkBox.TabIndex = 4;
            this.SpecialChkBox.Text = "Speciality Laundry";
            this.SpecialChkBox.UseVisualStyleBackColor = true;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(405, 182);
            this.AddressTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(198, 48);
            this.AddressTxtBox.TabIndex = 5;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(403, 166);
            this.AddressLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(98, 13);
            this.AddressLbl.TabIndex = 6;
            this.AddressLbl.Text = "Enter Your Address";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.DarkGray;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(83, 238);
            this.DateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(70, 15);
            this.DateLbl.TabIndex = 7;
            this.DateLbl.Text = "Select Date";
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(82, 253);
            this.dateTimePickerOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerOrder.TabIndex = 8;
            // 
            // morningRB
            // 
            this.morningRB.AutoSize = true;
            this.morningRB.Location = new System.Drawing.Point(4, 17);
            this.morningRB.Margin = new System.Windows.Forms.Padding(2);
            this.morningRB.Name = "morningRB";
            this.morningRB.Size = new System.Drawing.Size(111, 19);
            this.morningRB.TabIndex = 10;
            this.morningRB.TabStop = true;
            this.morningRB.Text = "8:00 - 11:00 AM";
            this.morningRB.UseVisualStyleBackColor = true;
            // 
            // eveningRB
            // 
            this.eveningRB.AutoSize = true;
            this.eveningRB.Location = new System.Drawing.Point(4, 38);
            this.eveningRB.Margin = new System.Windows.Forms.Padding(2);
            this.eveningRB.Name = "eveningRB";
            this.eveningRB.Size = new System.Drawing.Size(119, 19);
            this.eveningRB.TabIndex = 11;
            this.eveningRB.TabStop = true;
            this.eveningRB.Text = "12:00 - 14:00 PM";
            this.eveningRB.UseVisualStyleBackColor = true;
            // 
            // nightRB
            // 
            this.nightRB.AutoSize = true;
            this.nightRB.Location = new System.Drawing.Point(4, 59);
            this.nightRB.Margin = new System.Windows.Forms.Padding(2);
            this.nightRB.Name = "nightRB";
            this.nightRB.Size = new System.Drawing.Size(119, 19);
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
            this.TimeSlotGpBox.Location = new System.Drawing.Point(82, 287);
            this.TimeSlotGpBox.Margin = new System.Windows.Forms.Padding(2);
            this.TimeSlotGpBox.Name = "TimeSlotGpBox";
            this.TimeSlotGpBox.Padding = new System.Windows.Forms.Padding(2);
            this.TimeSlotGpBox.Size = new System.Drawing.Size(150, 81);
            this.TimeSlotGpBox.TabIndex = 13;
            this.TimeSlotGpBox.TabStop = false;
            this.TimeSlotGpBox.Text = "Pick Time Slot";
            // 
            // DetailsLbl
            // 
            this.DetailsLbl.AutoSize = true;
            this.DetailsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLbl.Location = new System.Drawing.Point(403, 142);
            this.DetailsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DetailsLbl.Name = "DetailsLbl";
            this.DetailsLbl.Size = new System.Drawing.Size(97, 15);
            this.DetailsLbl.TabIndex = 14;
            this.DetailsLbl.Text = "Delivery Details :";
            // 
            // paymentGrpBox
            // 
            this.paymentGrpBox.Controls.Add(this.CardRB);
            this.paymentGrpBox.Controls.Add(this.OnlineRB);
            this.paymentGrpBox.Controls.Add(this.CodRB);
            this.paymentGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentGrpBox.Location = new System.Drawing.Point(82, 391);
            this.paymentGrpBox.Margin = new System.Windows.Forms.Padding(2);
            this.paymentGrpBox.Name = "paymentGrpBox";
            this.paymentGrpBox.Padding = new System.Windows.Forms.Padding(2);
            this.paymentGrpBox.Size = new System.Drawing.Size(309, 39);
            this.paymentGrpBox.TabIndex = 16;
            this.paymentGrpBox.TabStop = false;
            this.paymentGrpBox.Text = "Select Payment Method";
            // 
            // CardRB
            // 
            this.CardRB.AutoSize = true;
            this.CardRB.Location = new System.Drawing.Point(191, 18);
            this.CardRB.Margin = new System.Windows.Forms.Padding(2);
            this.CardRB.Name = "CardRB";
            this.CardRB.Size = new System.Drawing.Size(118, 19);
            this.CardRB.TabIndex = 2;
            this.CardRB.TabStop = true;
            this.CardRB.Text = "Card Credit/Debit";
            this.CardRB.UseVisualStyleBackColor = true;
            // 
            // OnlineRB
            // 
            this.OnlineRB.AutoSize = true;
            this.OnlineRB.Location = new System.Drawing.Point(57, 17);
            this.OnlineRB.Margin = new System.Windows.Forms.Padding(2);
            this.OnlineRB.Name = "OnlineRB";
            this.OnlineRB.Size = new System.Drawing.Size(135, 19);
            this.OnlineRB.TabIndex = 1;
            this.OnlineRB.TabStop = true;
            this.OnlineRB.Text = "FPX Online Banking";
            this.OnlineRB.UseVisualStyleBackColor = true;
            // 
            // CodRB
            // 
            this.CodRB.AutoSize = true;
            this.CodRB.Location = new System.Drawing.Point(4, 18);
            this.CodRB.Margin = new System.Windows.Forms.Padding(2);
            this.CodRB.Name = "CodRB";
            this.CodRB.Size = new System.Drawing.Size(53, 19);
            this.CodRB.TabIndex = 0;
            this.CodRB.TabStop = true;
            this.CodRB.Text = "Cash";
            this.CodRB.UseVisualStyleBackColor = true;
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.Location = new System.Drawing.Point(403, 271);
            this.instructionsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(139, 13);
            this.instructionsLbl.TabIndex = 17;
            this.instructionsLbl.Text = "Garment Type / Instructions";
            // 
            // SpecialLbl
            // 
            this.SpecialLbl.AutoSize = true;
            this.SpecialLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialLbl.Location = new System.Drawing.Point(403, 253);
            this.SpecialLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SpecialLbl.Name = "SpecialLbl";
            this.SpecialLbl.Size = new System.Drawing.Size(106, 15);
            this.SpecialLbl.TabIndex = 18;
            this.SpecialLbl.Text = "Speciality Details :";
            // 
            // InstructionsTxt
            // 
            this.InstructionsTxt.Location = new System.Drawing.Point(405, 287);
            this.InstructionsTxt.Margin = new System.Windows.Forms.Padding(2);
            this.InstructionsTxt.Multiline = true;
            this.InstructionsTxt.Name = "InstructionsTxt";
            this.InstructionsTxt.Size = new System.Drawing.Size(198, 48);
            this.InstructionsTxt.TabIndex = 19;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(717, 456);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(86, 36);
            this.SubmitBtn.TabIndex = 20;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(607, 457);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 36);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CustomerDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(858, 515);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.InstructionsTxt);
            this.Controls.Add(this.SpecialLbl);
            this.Controls.Add(this.instructionsLbl);
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
            this.Name = "CustomerDashbord";
            this.Text = "Customer Dashbord";
            this.TimeSlotGpBox.ResumeLayout(false);
            this.TimeSlotGpBox.PerformLayout();
            this.paymentGrpBox.ResumeLayout(false);
            this.paymentGrpBox.PerformLayout();
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
        private System.Windows.Forms.Label instructionsLbl;
        private System.Windows.Forms.Label SpecialLbl;
        private System.Windows.Forms.TextBox InstructionsTxt;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button btnBack;
    }
}