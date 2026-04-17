namespace WindowsFormsApp1
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.LabWelcome = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HIdeShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabWelcome
            // 
            this.LabWelcome.AutoSize = true;
            this.LabWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LabWelcome.Font = new System.Drawing.Font("Aharoni", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWelcome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LabWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabWelcome.Location = new System.Drawing.Point(365, 37);
            this.LabWelcome.Name = "LabWelcome";
            this.LabWelcome.Size = new System.Drawing.Size(191, 63);
            this.LabWelcome.TabIndex = 4;
            this.LabWelcome.Text = "Login";
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Transparent;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOut.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.MediumPurple;
            this.LogOut.Location = new System.Drawing.Point(12, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(111, 35);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtUsername.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(397, 296);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(159, 34);
            this.TxtUsername.TabIndex = 6;
            this.TxtUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPassword.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(397, 364);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(159, 34);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(424, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // HIdeShow
            // 
            this.HIdeShow.BackColor = System.Drawing.Color.Transparent;
            this.HIdeShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HIdeShow.BackgroundImage")));
            this.HIdeShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HIdeShow.Location = new System.Drawing.Point(562, 371);
            this.HIdeShow.Name = "HIdeShow";
            this.HIdeShow.Size = new System.Drawing.Size(24, 23);
            this.HIdeShow.TabIndex = 9;
            this.HIdeShow.UseVisualStyleBackColor = false;
            this.HIdeShow.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 709);
            this.Controls.Add(this.HIdeShow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.LabWelcome);
            this.Name = "LoginScreen";
            this.Opacity = 0.98D;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabWelcome;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HIdeShow;
    }
}