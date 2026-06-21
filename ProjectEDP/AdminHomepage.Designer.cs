namespace ProjectEDP
{
    partial class AdminHomepage
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.manageOrderBtn = new System.Windows.Forms.Button();
            this.manageReservationBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(11, 454);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(116, 36);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // manageOrderBtn
            // 
            this.manageOrderBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.manageOrderBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageOrderBtn.Location = new System.Drawing.Point(349, 155);
            this.manageOrderBtn.Margin = new System.Windows.Forms.Padding(2);
            this.manageOrderBtn.Name = "manageOrderBtn";
            this.manageOrderBtn.Size = new System.Drawing.Size(153, 36);
            this.manageOrderBtn.TabIndex = 8;
            this.manageOrderBtn.Text = "Manage Orders";
            this.manageOrderBtn.UseVisualStyleBackColor = false;
            this.manageOrderBtn.Click += new System.EventHandler(this.manageOrderBtn_Click);
            // 
            // manageReservationBtn
            // 
            this.manageReservationBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.manageReservationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageReservationBtn.Location = new System.Drawing.Point(349, 115);
            this.manageReservationBtn.Margin = new System.Windows.Forms.Padding(2);
            this.manageReservationBtn.Name = "manageReservationBtn";
            this.manageReservationBtn.Size = new System.Drawing.Size(153, 36);
            this.manageReservationBtn.TabIndex = 7;
            this.manageReservationBtn.Text = "Manage Reservations";
            this.manageReservationBtn.UseVisualStyleBackColor = false;
            this.manageReservationBtn.Click += new System.EventHandler(this.manageReservationBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(117, 24);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(625, 53);
            this.welcomeLbl.TabIndex = 5;
            this.welcomeLbl.Text = "WELCOME TO EASY LAUNDRY";
            // 
            // AdminHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::ProjectEDP.Properties.Resources.laundry2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.manageOrderBtn);
            this.Controls.Add(this.manageReservationBtn);
            this.Controls.Add(this.welcomeLbl);
            this.Name = "AdminHomepage";
            this.Text = "Admin Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button manageOrderBtn;
        private System.Windows.Forms.Button manageReservationBtn;
        private System.Windows.Forms.Label welcomeLbl;
    }
}