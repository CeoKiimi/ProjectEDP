namespace ProjectEDP
{
    partial class Homepage
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
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReserveBtn = new System.Windows.Forms.Button();
            this.reserveListbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.Location = new System.Drawing.Point(117, 34);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(625, 53);
            this.welcomeLbl.TabIndex = 0;
            this.welcomeLbl.Text = "WELCOME TO EASY LAUNDRY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make a reservation with Easy Laundry";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.BackColor = System.Drawing.Color.CadetBlue;
            this.ReserveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveBtn.Location = new System.Drawing.Point(351, 149);
            this.ReserveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(153, 36);
            this.ReserveBtn.TabIndex = 2;
            this.ReserveBtn.Text = "Click To Make Reservation";
            this.ReserveBtn.UseVisualStyleBackColor = false;
            this.ReserveBtn.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // reserveListbtn
            // 
            this.reserveListbtn.BackColor = System.Drawing.Color.CadetBlue;
            this.reserveListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveListbtn.Location = new System.Drawing.Point(351, 189);
            this.reserveListbtn.Margin = new System.Windows.Forms.Padding(2);
            this.reserveListbtn.Name = "reserveListbtn";
            this.reserveListbtn.Size = new System.Drawing.Size(153, 36);
            this.reserveListbtn.TabIndex = 3;
            this.reserveListbtn.Text = "Click To See Reservation List";
            this.reserveListbtn.UseVisualStyleBackColor = false;
            this.reserveListbtn.Click += new System.EventHandler(this.reserveListbtn_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::ProjectEDP.Properties.Resources.laundry2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.reserveListbtn);
            this.Controls.Add(this.ReserveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.Button reserveListbtn;
    }
}