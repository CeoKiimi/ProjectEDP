namespace ProjectEDP
{
    partial class CustomerReservationPage
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.nothing = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(23, 79);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.Size = new System.Drawing.Size(936, 399);
            this.dgvReservations.TabIndex = 0;
            // 
            // nothing
            // 
            this.nothing.AutoSize = true;
            this.nothing.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nothing.Location = new System.Drawing.Point(293, 20);
            this.nothing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nothing.Name = "nothing";
            this.nothing.Size = new System.Drawing.Size(425, 47);
            this.nothing.TabIndex = 1;
            this.nothing.Text = "Reservation Details";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(743, 498);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 44);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(858, 498);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(90, 44);
            this.btnPay.TabIndex = 23;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // CustomerReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.nothing);
            this.Controls.Add(this.dgvReservations);
            this.Name = "CustomerReservationPage";
            this.Text = "Customer Reservation";
            this.Load += new System.EventHandler(this.CustomerReservationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label nothing;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPay;
    }
}