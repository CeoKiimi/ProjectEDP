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
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblSpecialtyDetails = new System.Windows.Forms.Label();
            this.groupPaymentDetails = new System.Windows.Forms.GroupBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.groupOrderSummary.SuspendLayout();
            this.groupPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPayNow
            // 
            this.btnPayNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayNow.Location = new System.Drawing.Point(647, 436);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(133, 46);
            this.btnPayNow.TabIndex = 0;
            this.btnPayNow.Text = "CONFIRM PAYMENT";
            this.btnPayNow.UseVisualStyleBackColor = true;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(519, 436);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 46);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.Location = new System.Drawing.Point(6, 25);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(106, 16);
            this.lblReservationID.TabIndex = 2;
            this.lblReservationID.Text = "ReservationID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(6, 62);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(61, 16);
            this.lblOrderID.TabIndex = 3;
            this.lblOrderID.Text = "OrderID";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceType.Location = new System.Drawing.Point(6, 103);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(96, 16);
            this.lblServiceType.TabIndex = 4;
            this.lblServiceType.Text = "ServiceType";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(6, 142);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date";
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSlot.Location = new System.Drawing.Point(6, 184);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(69, 16);
            this.lblTimeSlot.TabIndex = 6;
            this.lblTimeSlot.Text = "TimeSlot";
            this.lblTimeSlot.Click += new System.EventHandler(this.lblTimeSlot_Click);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(7, 29);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(122, 16);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(7, 64);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(93, 16);
            this.lblOrderStatus.TabIndex = 8;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // nothing
            // 
            this.nothing.AutoSize = true;
            this.nothing.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothing.Location = new System.Drawing.Point(219, 27);
            this.nothing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nothing.Name = "nothing";
            this.nothing.Size = new System.Drawing.Size(404, 47);
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
            this.groupOrderSummary.Location = new System.Drawing.Point(42, 115);
            this.groupOrderSummary.Name = "groupOrderSummary";
            this.groupOrderSummary.Size = new System.Drawing.Size(339, 307);
            this.groupOrderSummary.TabIndex = 10;
            this.groupOrderSummary.TabStop = false;
            this.groupOrderSummary.Text = "Order Summary";
            this.groupOrderSummary.Enter += new System.EventHandler(this.groupOrderSummary_Enter);
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryAddress.Location = new System.Drawing.Point(6, 227);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(127, 16);
            this.lblDeliveryAddress.TabIndex = 7;
            this.lblDeliveryAddress.Text = "Delivery Address";
            // 
            // lblSpecialtyDetails
            // 
            this.lblSpecialtyDetails.AutoSize = true;
            this.lblSpecialtyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialtyDetails.Location = new System.Drawing.Point(6, 268);
            this.lblSpecialtyDetails.Name = "lblSpecialtyDetails";
            this.lblSpecialtyDetails.Size = new System.Drawing.Size(125, 16);
            this.lblSpecialtyDetails.TabIndex = 8;
            this.lblSpecialtyDetails.Text = "Specialty Details";
            // 
            // groupPaymentDetails
            // 
            this.groupPaymentDetails.Controls.Add(this.lblAmount);
            this.groupPaymentDetails.Controls.Add(this.lblPaymentStatus);
            this.groupPaymentDetails.Controls.Add(this.lblPaymentMethod);
            this.groupPaymentDetails.Controls.Add(this.lblOrderStatus);
            this.groupPaymentDetails.Location = new System.Drawing.Point(460, 115);
            this.groupPaymentDetails.Name = "groupPaymentDetails";
            this.groupPaymentDetails.Size = new System.Drawing.Size(326, 307);
            this.groupPaymentDetails.TabIndex = 11;
            this.groupPaymentDetails.TabStop = false;
            this.groupPaymentDetails.Text = "Payment Details";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(7, 103);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(114, 16);
            this.lblPaymentStatus.TabIndex = 9;
            this.lblPaymentStatus.Text = "Payment Status";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(7, 143);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 16);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // PaymentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.groupPaymentDetails);
            this.Controls.Add(this.groupOrderSummary);
            this.Controls.Add(this.nothing);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPayNow);
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