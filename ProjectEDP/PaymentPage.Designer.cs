namespace ProjectEDP
{
    partial class PaymentPage
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
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.nothing = new System.Windows.Forms.Label();
            this.groupOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblSpecialtyDetails = new System.Windows.Forms.Label();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.groupPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.groupOrderSummary.SuspendLayout();
            this.groupPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPayNow
            // 
            this.btnPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.Location = new System.Drawing.Point(863, 537);
            this.btnPayNow.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(177, 57);
            this.btnPayNow.TabIndex = 0;
            this.btnPayNow.Text = "CONFIRM PAYMENT";
            this.btnPayNow.UseVisualStyleBackColor = true;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(692, 537);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 57);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.Location = new System.Drawing.Point(8, 31);
            this.lblReservationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(128, 20);
            this.lblReservationID.TabIndex = 2;
            this.lblReservationID.Text = "ReservationID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(8, 76);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(76, 20);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "OrderID";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(8, 127);
            this.lblServiceType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(112, 20);
            this.lblServiceType.TabIndex = 4;
            this.lblServiceType.Text = "ServiceType";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(8, 175);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 20);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSlot.Location = new System.Drawing.Point(8, 226);
            this.lblTimeSlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(83, 20);
            this.lblTimeSlot.TabIndex = 6;
            this.lblTimeSlot.Text = "TimeSlot";
            this.lblTimeSlot.Click += new System.EventHandler(this.lblTimeSlot_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(9, 36);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(148, 20);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(9, 79);
            this.lblOrderStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(117, 20);
            this.lblOrderStatus.TabIndex = 8;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // nothing
            // 
            this.nothing.AutoSize = true;
            this.nothing.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothing.ForeColor = System.Drawing.SystemColors.Control;
            this.nothing.Location = new System.Drawing.Point(292, 33);
            this.nothing.Name = "nothing";
            this.nothing.Size = new System.Drawing.Size(499, 59);
            this.nothing.TabIndex = 9;
            this.nothing.Text = "PAYMENT CHECKOUT";
            // 
            // groupOrderSummary
            // 
            this.groupOrderSummary.Controls.Add(this.lblSpecialtyDetails);
            this.groupOrderSummary.Controls.Add(this.lblDeliveryAddress);
            this.groupOrderSummary.Controls.Add(this.lblReservationID);
            this.groupOrderSummary.Controls.Add(this.lblOrderID);
            this.groupOrderSummary.Controls.Add(this.lblServiceType);
            this.groupOrderSummary.Controls.Add(this.lblDate);
            this.groupOrderSummary.Controls.Add(this.lblTimeSlot);
            this.groupOrderSummary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupOrderSummary.Location = new System.Drawing.Point(56, 142);
            this.groupOrderSummary.Margin = new System.Windows.Forms.Padding(4);
            this.groupOrderSummary.Name = "groupOrderSummary";
            this.groupOrderSummary.Padding = new System.Windows.Forms.Padding(4);
            this.groupOrderSummary.Size = new System.Drawing.Size(452, 378);
            this.groupOrderSummary.TabIndex = 10;
            this.groupOrderSummary.TabStop = false;
            this.groupOrderSummary.Text = "Order Summary";
            this.groupOrderSummary.Enter += new System.EventHandler(this.groupOrderSummary_Enter);
            // 
            // lblSpecialtyDetails
            // 
            this.lblSpecialtyDetails.AutoSize = true;
            this.lblSpecialtyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialtyDetails.Location = new System.Drawing.Point(8, 330);
            this.lblSpecialtyDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialtyDetails.Name = "lblSpecialtyDetails";
            this.lblSpecialtyDetails.Size = new System.Drawing.Size(152, 20);
            this.lblSpecialtyDetails.TabIndex = 8;
            this.lblSpecialtyDetails.Text = "Specialty Details";
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryAddress.Location = new System.Drawing.Point(8, 279);
            this.lblDeliveryAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(153, 20);
            this.lblDeliveryAddress.TabIndex = 7;
            this.lblDeliveryAddress.Text = "Delivery Address";
            // 
            // groupPaymentDetails
            // 
            this.groupPaymentDetails.Controls.Add(this.lblAmount);
            this.groupPaymentDetails.Controls.Add(this.lblPaymentStatus);
            this.groupPaymentDetails.Controls.Add(this.lblPaymentMethod);
            this.groupPaymentDetails.Controls.Add(this.lblOrderStatus);
            this.groupPaymentDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupPaymentDetails.Location = new System.Drawing.Point(613, 142);
            this.groupPaymentDetails.Margin = new System.Windows.Forms.Padding(4);
            this.groupPaymentDetails.Name = "groupPaymentDetails";
            this.groupPaymentDetails.Padding = new System.Windows.Forms.Padding(4);
            this.groupPaymentDetails.Size = new System.Drawing.Size(435, 378);
            this.groupPaymentDetails.TabIndex = 11;
            this.groupPaymentDetails.TabStop = false;
            this.groupPaymentDetails.Text = "Payment Details";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(9, 176);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(72, 20);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(9, 127);
            this.lblPaymentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(141, 20);
            this.lblPaymentStatus.TabIndex = 9;
            this.lblPaymentStatus.Text = "Payment Status";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(177)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1112, 629);
            this.Controls.Add(this.groupPaymentDetails);
            this.Controls.Add(this.groupOrderSummary);
            this.Controls.Add(this.nothing);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPayNow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaymentPage";
            this.Text = "Payment Page";
            this.Load += new System.EventHandler(this.PaymentPage_Load);
            this.groupOrderSummary.ResumeLayout(false);
            this.groupOrderSummary.PerformLayout();
            this.groupPaymentDetails.ResumeLayout(false);
            this.groupPaymentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label nothing;
        private System.Windows.Forms.GroupBox groupOrderSummary;
        private System.Windows.Forms.Label lblSpecialtyDetails;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.GroupBox groupPaymentDetails;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPaymentStatus;
    }
}