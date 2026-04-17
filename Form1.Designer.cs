namespace WindowsFormsApp1
{
    partial class UserChoos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChoos));
            this.Butregistration = new System.Windows.Forms.Button();
            this.ButLogin = new System.Windows.Forms.Button();
            this.LabWelcome = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LogOut = new System.Windows.Forms.Button();
            this.Clock1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Butregistration
            // 
            this.Butregistration.BackColor = System.Drawing.Color.Transparent;
            this.Butregistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Butregistration.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butregistration.ForeColor = System.Drawing.Color.Orange;
            this.Butregistration.Location = new System.Drawing.Point(523, 439);
            this.Butregistration.Name = "Butregistration";
            this.Butregistration.Size = new System.Drawing.Size(129, 54);
            this.Butregistration.TabIndex = 0;
            this.Butregistration.Text = "registration";
            this.Butregistration.UseVisualStyleBackColor = false;
            this.Butregistration.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButLogin
            // 
            this.ButLogin.BackColor = System.Drawing.Color.Transparent;
            this.ButLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButLogin.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButLogin.ForeColor = System.Drawing.Color.Orange;
            this.ButLogin.Location = new System.Drawing.Point(322, 439);
            this.ButLogin.Name = "ButLogin";
            this.ButLogin.Size = new System.Drawing.Size(129, 54);
            this.ButLogin.TabIndex = 1;
            this.ButLogin.Text = "Log in";
            this.ButLogin.UseVisualStyleBackColor = false;
            this.ButLogin.Click += new System.EventHandler(this.ButLogin_Click);
            // 
            // LabWelcome
            // 
            this.LabWelcome.AutoSize = true;
            this.LabWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LabWelcome.Font = new System.Drawing.Font("Aharoni", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWelcome.ForeColor = System.Drawing.Color.Gold;
            this.LabWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabWelcome.Location = new System.Drawing.Point(311, 29);
            this.LabWelcome.Name = "LabWelcome";
            this.LabWelcome.Size = new System.Drawing.Size(307, 63);
            this.LabWelcome.TabIndex = 3;
            this.LabWelcome.Text = "Welcome";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.Transparent;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOut.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.LavenderBlush;
            this.LogOut.Location = new System.Drawing.Point(436, 662);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(111, 35);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Clock1
            // 
            this.Clock1.AutoSize = true;
            this.Clock1.BackColor = System.Drawing.Color.Transparent;
            this.Clock1.Font = new System.Drawing.Font("Aharoni", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock1.ForeColor = System.Drawing.Color.Goldenrod;
            this.Clock1.Location = new System.Drawing.Point(776, 29);
            this.Clock1.Name = "Clock1";
            this.Clock1.Size = new System.Drawing.Size(86, 28);
            this.Clock1.TabIndex = 7;
            this.Clock1.Text = "Clock";
            this.Clock1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserChoos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 709);
            this.Controls.Add(this.Clock1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.LabWelcome);
            this.Controls.Add(this.ButLogin);
            this.Controls.Add(this.Butregistration);
            this.MinimizeBox = false;
            this.Name = "UserChoos";
            this.Opacity = 0.98D;
            this.Text = "User Choos";
            this.Load += new System.EventHandler(this.UserChoos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butregistration;
        private System.Windows.Forms.Button ButLogin;
        private System.Windows.Forms.Label LabWelcome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label Clock1;
    }
}

