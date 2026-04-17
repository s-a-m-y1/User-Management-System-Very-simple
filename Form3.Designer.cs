namespace WindowsFormsApp1
{
    partial class Userregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userregister));
            this.HIdeShow2 = new System.Windows.Forms.Button();
            this.Enter2 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtLastname = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LabWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.___ = new System.Windows.Forms.GroupBox();
            this.___.SuspendLayout();
            this.SuspendLayout();
            // 
            // HIdeShow2
            // 
            this.HIdeShow2.BackColor = System.Drawing.Color.Transparent;
            this.HIdeShow2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HIdeShow2.BackgroundImage")));
            this.HIdeShow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HIdeShow2.Location = new System.Drawing.Point(195, 124);
            this.HIdeShow2.Name = "HIdeShow2";
            this.HIdeShow2.Size = new System.Drawing.Size(24, 23);
            this.HIdeShow2.TabIndex = 13;
            this.HIdeShow2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HIdeShow2.UseVisualStyleBackColor = false;
            this.HIdeShow2.Click += new System.EventHandler(this.HIdeShow_Click);
            // 
            // Enter2
            // 
            this.Enter2.BackColor = System.Drawing.Color.Transparent;
            this.Enter2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter2.Font = new System.Drawing.Font("Aharoni", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter2.ForeColor = System.Drawing.Color.MediumPurple;
            this.Enter2.Location = new System.Drawing.Point(384, 585);
            this.Enter2.Name = "Enter2";
            this.Enter2.Size = new System.Drawing.Size(118, 35);
            this.Enter2.TabIndex = 12;
            this.Enter2.Text = "Enter";
            this.Enter2.UseVisualStyleBackColor = false;
            this.Enter2.Click += new System.EventHandler(this.Enter1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtPassword.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(30, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(159, 34);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtUsername.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(30, 19);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(159, 34);
            this.TxtUsername.TabIndex = 10;
            this.TxtUsername.Text = "Firstname";
            // 
            // TxtLastname
            // 
            this.TxtLastname.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtLastname.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLastname.Location = new System.Drawing.Point(30, 68);
            this.TxtLastname.Name = "TxtLastname";
            this.TxtLastname.Size = new System.Drawing.Size(159, 34);
            this.TxtLastname.TabIndex = 14;
            this.TxtLastname.Text = "Lastname";
            // 
            // TxtAge
            // 
            this.TxtAge.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtAge.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(30, 266);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(159, 34);
            this.TxtAge.TabIndex = 15;
            this.TxtAge.Text = "Age";
            // 
            // TxtPhone
            // 
            this.TxtPhone.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtPhone.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(30, 217);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(159, 34);
            this.TxtPhone.TabIndex = 16;
            this.TxtPhone.Text = "Phone";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.TxtEmail.Font = new System.Drawing.Font("Aharoni", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(30, 168);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(159, 34);
            this.TxtEmail.TabIndex = 17;
            this.TxtEmail.Text = "Email";
            // 
            // LabWelcome
            // 
            this.LabWelcome.AutoSize = true;
            this.LabWelcome.BackColor = System.Drawing.Color.Transparent;
            this.LabWelcome.Font = new System.Drawing.Font("Aharoni", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabWelcome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.LabWelcome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabWelcome.Location = new System.Drawing.Point(373, 32);
            this.LabWelcome.Name = "LabWelcome";
            this.LabWelcome.Size = new System.Drawing.Size(0, 63);
            this.LabWelcome.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aharoni", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(329, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 63);
            this.label1.TabIndex = 19;
            this.label1.Text = "Register";
            // 
            // ___
            // 
            this.___.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.___.BackColor = System.Drawing.Color.Transparent;
            this.___.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.___.Controls.Add(this.TxtUsername);
            this.___.Controls.Add(this.TxtLastname);
            this.___.Controls.Add(this.txtPassword);
            this.___.Controls.Add(this.TxtAge);
            this.___.Controls.Add(this.TxtPhone);
            this.___.Controls.Add(this.TxtEmail);
            this.___.Controls.Add(this.HIdeShow2);
            this.___.ForeColor = System.Drawing.Color.Transparent;
            this.___.Location = new System.Drawing.Point(330, 213);
            this.___.Name = "___";
            this.___.Size = new System.Drawing.Size(234, 338);
            this.___.TabIndex = 20;
            this.___.TabStop = false;
            // 
            // Userregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 709);
            this.Controls.Add(this.___);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabWelcome);
            this.Controls.Add(this.Enter2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Userregister";
            this.Opacity = 0.98D;
            this.Text = "register";
            this.Load += new System.EventHandler(this.Userregister_Load);
            this.___.ResumeLayout(false);
            this.___.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HIdeShow2;
        private System.Windows.Forms.Button Enter2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtLastname;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LabWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ___;
    }
}