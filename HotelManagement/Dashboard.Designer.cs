namespace HotelManagement
{
    partial class Dashboard
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
            this.btnBookNow = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoginAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.aws = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picb = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aws)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBookNow
            // 
            this.btnBookNow.Animated = true;
            this.btnBookNow.BackColor = System.Drawing.SystemColors.Control;
            this.btnBookNow.BorderColor = System.Drawing.Color.Transparent;
            this.btnBookNow.BorderRadius = 9;
            this.btnBookNow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBookNow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBookNow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBookNow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBookNow.FillColor = System.Drawing.Color.Black;
            this.btnBookNow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBookNow.ForeColor = System.Drawing.Color.White;
            this.btnBookNow.Location = new System.Drawing.Point(1013, 12);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(134, 39);
            this.btnBookNow.TabIndex = 3;
            this.btnBookNow.Text = "BOOK NOW";
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.aws);
            this.panel1.Controls.Add(this.picb);
            this.panel1.Location = new System.Drawing.Point(0, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 572);
            this.panel1.TabIndex = 4;
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.Color.White;
            this.btnLoginAdmin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoginAdmin.BorderRadius = 9;
            this.btnLoginAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginAdmin.FillColor = System.Drawing.Color.Transparent;
            this.btnLoginAdmin.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAdmin.ForeColor = System.Drawing.Color.Black;
            this.btnLoginAdmin.Location = new System.Drawing.Point(1013, 60);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(134, 26);
            this.btnLoginAdmin.TabIndex = 5;
            this.btnLoginAdmin.Text = "LOGIN AS ADMIN";
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::HotelManagement.Properties.Resources.image_removebg_preview;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(520, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(102, 72);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 6;
            this.guna2PictureBox2.TabStop = false;
            // 
            // aws
            // 
            this.aws.BackColor = System.Drawing.Color.Transparent;
            this.aws.FillColor = System.Drawing.Color.Transparent;
            this.aws.Image = global::HotelManagement.Properties.Resources.Cuisine;
            this.aws.ImageRotate = 0F;
            this.aws.Location = new System.Drawing.Point(1168, 0);
            this.aws.Name = "aws";
            this.aws.Size = new System.Drawing.Size(1170, 552);
            this.aws.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aws.TabIndex = 2;
            this.aws.TabStop = false;
            this.aws.UseTransparentBackground = true;
            // 
            // picb
            // 
            this.picb.BackColor = System.Drawing.Color.Transparent;
            this.picb.FillColor = System.Drawing.Color.Transparent;
            this.picb.Image = global::HotelManagement.Properties.Resources.Room;
            this.picb.ImageRotate = 0F;
            this.picb.Location = new System.Drawing.Point(3, 0);
            this.picb.Name = "picb";
            this.picb.Size = new System.Drawing.Size(1170, 552);
            this.picb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb.TabIndex = 1;
            this.picb.TabStop = false;
            this.picb.UseTransparentBackground = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1163, 669);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.btnLoginAdmin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBookNow);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aws)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBookNow;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picb;
        private Guna.UI2.WinForms.Guna2PictureBox aws;
        private Guna.UI2.WinForms.Guna2Button btnLoginAdmin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}