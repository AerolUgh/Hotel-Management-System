﻿namespace HotelManagement
{
    partial class Login
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
            this.txtAdminID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.txtAdminPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.ShowPassword = new System.Windows.Forms.PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HidePassword = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAdminID
            // 
            this.txtAdminID.BorderRadius = 10;
            this.txtAdminID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminID.DefaultText = "Enter ID here...";
            this.txtAdminID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdminID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdminID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminID.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAdminID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminID.Location = new System.Drawing.Point(137, 258);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.PasswordChar = '\0';
            this.txtAdminID.PlaceholderText = "";
            this.txtAdminID.SelectedText = "";
            this.txtAdminID.Size = new System.Drawing.Size(285, 38);
            this.txtAdminID.TabIndex = 8;
            this.txtAdminID.Enter += new System.EventHandler(this.txtAdminID_Enter);
            this.txtAdminID.Leave += new System.EventHandler(this.txtAdminID_Leave);
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminID.Location = new System.Drawing.Point(238, 234);
            this.lblAdminID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(78, 19);
            this.lblAdminID.TabIndex = 9;
            this.lblAdminID.Text = "Admin ID";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPassword.Location = new System.Drawing.Point(211, 324);
            this.lblAdminPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(128, 19);
            this.lblAdminPassword.TabIndex = 11;
            this.lblAdminPassword.Text = "Admin Password";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.BorderRadius = 10;
            this.txtAdminPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminPassword.DefaultText = "Enter Password here...";
            this.txtAdminPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdminPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdminPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminPassword.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAdminPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAdminPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminPassword.Location = new System.Drawing.Point(137, 349);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '\0';
            this.txtAdminPassword.PlaceholderText = "";
            this.txtAdminPassword.SelectedText = "";
            this.txtAdminPassword.Size = new System.Drawing.Size(285, 38);
            this.txtAdminPassword.TabIndex = 10;
            this.txtAdminPassword.Enter += new System.EventHandler(this.txtAdminPassword_Enter);
            this.txtAdminPassword.Leave += new System.EventHandler(this.txtAdminPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(198, 435);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(155, 38);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Log in";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ShowPassword
            // 
            this.ShowPassword.BackColor = System.Drawing.Color.White;
            this.ShowPassword.Image = global::HotelManagement.Properties.Resources.view;
            this.ShowPassword.Location = new System.Drawing.Point(384, 357);
            this.ShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(27, 23);
            this.ShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowPassword.TabIndex = 13;
            this.ShowPassword.TabStop = false;
            this.ShowPassword.Click += new System.EventHandler(this.ShowPassword_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::HotelManagement.Properties.Resources.image_removebg_preview;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(196, 32);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(158, 118);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 7;
            this.guna2PictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HotelManagement.Properties.Resources.bitmap;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 670);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HidePassword
            // 
            this.HidePassword.BackColor = System.Drawing.Color.White;
            this.HidePassword.Image = global::HotelManagement.Properties.Resources.hide;
            this.HidePassword.Location = new System.Drawing.Point(384, 357);
            this.HidePassword.Margin = new System.Windows.Forms.Padding(2);
            this.HidePassword.Name = "HidePassword";
            this.HidePassword.Size = new System.Drawing.Size(27, 23);
            this.HidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HidePassword.TabIndex = 14;
            this.HidePassword.TabStop = false;
            this.HidePassword.Visible = false;
            this.HidePassword.Click += new System.EventHandler(this.HidePassword_Click);
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(252, 488);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 19);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 669);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.HidePassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblAdminPassword);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.txtAdminID);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtAdminID;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblAdminPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtAdminPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.PictureBox ShowPassword;
        private System.Windows.Forms.PictureBox HidePassword;
        private System.Windows.Forms.Label Exit;
    }
}