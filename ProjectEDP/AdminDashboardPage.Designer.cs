namespace ProjectEDP
{
    partial class AdminDashboardPage
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
            this.dgvAdminReservations = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // reserveLbl
            // 
            this.reserveLbl.AutoSize = true;
            this.reserveLbl.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveLbl.Location = new System.Drawing.Point(306, 20);
            this.reserveLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reserveLbl.Name = "reserveLbl";
            this.reserveLbl.Size = new System.Drawing.Size(425, 47);
            this.reserveLbl.TabIndex = 1;
            this.reserveLbl.Text = "Manage Reservation";
            // 
            // dgvAdminReservations
            // 
            this.dgvAdminReservations.AllowUserToAddRows = false;
            this.dgvAdminReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdminReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminReservations.Location = new System.Drawing.Point(25, 83);
            this.dgvAdminReservations.Name = "dgvAdminReservations";
            this.dgvAdminReservations.ReadOnly = true;
            this.dgvAdminReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminReservations.Size = new System.Drawing.Size(938, 398);
            this.dgvAdminReservations.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(279, 502);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 37);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.Location = new System.Drawing.Point(503, 502);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(91, 37);
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(392, 502);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(91, 37);
            this.btnReject.TabIndex = 5;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(617, 502);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(91, 37);
            this.btnViewOrders.TabIndex = 6;
            this.btnViewOrders.Text = "VIEW ORDERS";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // AdminDashboardPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvAdminReservations);
            this.Controls.Add(this.reserveLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboardPage";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reserveLbl;
        private System.Windows.Forms.DataGridView dgvAdminReservations;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnViewOrders;
    }
}