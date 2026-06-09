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
            this.CodRB = new System.Windows.Forms.RadioButton();
            this.OnlineRB = new System.Windows.Forms.RadioButton();
            this.CardRB = new System.Windows.Forms.RadioButton();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.SpecialLbl = new System.Windows.Forms.Label();
            this.InstructionsTxt = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.TimeSlotGpBox.SuspendLayout();
            this.paymentGrpBox.SuspendLayout();
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
            this.ServiceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLbl.Location = new System.Drawing.Point(48, 192);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(138, 18);
            this.ServiceLbl.TabIndex = 1;
            this.ServiceLbl.Text = "Select Service Type";
            // 
            // pickupChkBox
            // 
            this.pickupChkBox.AutoSize = true;
            this.pickupChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupChkBox.Location = new System.Drawing.Point(51, 222);
            this.pickupChkBox.Name = "pickupChkBox";
            this.pickupChkBox.Size = new System.Drawing.Size(79, 22);
            this.pickupChkBox.TabIndex = 2;
            this.pickupChkBox.Text = "Pickup ";
            this.pickupChkBox.UseVisualStyleBackColor = true;
            // 
            // DeliveryChkBox
            // 
            this.DeliveryChkBox.AutoSize = true;
            this.DeliveryChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryChkBox.Location = new System.Drawing.Point(51, 248);
            this.DeliveryChkBox.Name = "DeliveryChkBox";
            this.DeliveryChkBox.Size = new System.Drawing.Size(82, 22);
            this.DeliveryChkBox.TabIndex = 3;
            this.DeliveryChkBox.Text = "Delivery";
            this.DeliveryChkBox.UseVisualStyleBackColor = true;
            // 
            // SpecialChkBox
            // 
            this.SpecialChkBox.AutoSize = true;
            this.SpecialChkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialChkBox.Location = new System.Drawing.Point(51, 274);
            this.SpecialChkBox.Name = "SpecialChkBox";
            this.SpecialChkBox.Size = new System.Drawing.Size(148, 22);
            this.SpecialChkBox.TabIndex = 4;
            this.SpecialChkBox.Text = "Speciality Laundry";
            this.SpecialChkBox.UseVisualStyleBackColor = true;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Location = new System.Drawing.Point(444, 241);
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
            this.DateLbl.BackColor = System.Drawing.Color.DarkGray;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.Location = new System.Drawing.Point(52, 310);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(84, 18);
            this.DateLbl.TabIndex = 7;
            this.DateLbl.Text = "Select Date";
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
            this.morningRB.Size = new System.Drawing.Size(132, 22);
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
            this.eveningRB.Size = new System.Drawing.Size(141, 22);
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
            this.DetailsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLbl.Location = new System.Drawing.Point(441, 192);
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
            this.paymentGrpBox.Location = new System.Drawing.Point(51, 498);
            this.paymentGrpBox.Name = "paymentGrpBox";
            this.paymentGrpBox.Size = new System.Drawing.Size(387, 48);
            this.paymentGrpBox.TabIndex = 16;
            this.paymentGrpBox.TabStop = false;
            this.paymentGrpBox.Text = "Select Payment Method";
            // 
            // CodRB
            // 
            this.CodRB.AutoSize = true;
            this.CodRB.Location = new System.Drawing.Point(6, 22);
            this.CodRB.Name = "CodRB";
            this.CodRB.Size = new System.Drawing.Size(64, 22);
            this.CodRB.TabIndex = 0;
            this.CodRB.TabStop = true;
            this.CodRB.Text = "Cash";
            this.CodRB.UseVisualStyleBackColor = true;
            // 
            // OnlineRB
            // 
            this.OnlineRB.AutoSize = true;
            this.OnlineRB.Location = new System.Drawing.Point(80, 21);
            this.OnlineRB.Name = "OnlineRB";
            this.OnlineRB.Size = new System.Drawing.Size(161, 22);
            this.OnlineRB.TabIndex = 1;
            this.OnlineRB.TabStop = true;
            this.OnlineRB.Text = "FPX Online Banking";
            this.OnlineRB.UseVisualStyleBackColor = true;
            // 
            // CardRB
            // 
            this.CardRB.AutoSize = true;
            this.CardRB.Location = new System.Drawing.Point(232, 21);
            this.CardRB.Name = "CardRB";
            this.CardRB.Size = new System.Drawing.Size(142, 22);
            this.CardRB.TabIndex = 2;
            this.CardRB.TabStop = true;
            this.CardRB.Text = "Card Credit/Debit";
            this.CardRB.UseVisualStyleBackColor = true;
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.Location = new System.Drawing.Point(441, 351);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(169, 16);
            this.instructionsLbl.TabIndex = 17;
            this.instructionsLbl.Text = "Garment Type / Instructions";
            // 
            // SpecialLbl
            // 
            this.SpecialLbl.AutoSize = true;
            this.SpecialLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialLbl.Location = new System.Drawing.Point(441, 329);
            this.SpecialLbl.Name = "SpecialLbl";
            this.SpecialLbl.Size = new System.Drawing.Size(127, 18);
            this.SpecialLbl.TabIndex = 18;
            this.SpecialLbl.Text = "Speciality Details :";
            // 
            // InstructionsTxt
            // 
            this.InstructionsTxt.Location = new System.Drawing.Point(444, 370);
            this.InstructionsTxt.Multiline = true;
            this.InstructionsTxt.Name = "InstructionsTxt";
            this.InstructionsTxt.Size = new System.Drawing.Size(204, 58);
            this.InstructionsTxt.TabIndex = 19;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(950, 556);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(121, 49);
            this.SubmitBtn.TabIndex = 20;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // CustomerDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1144, 634);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}