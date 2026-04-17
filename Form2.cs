using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                HIdeShow.BackgroundImage = Image.FromFile(@"A:\Projects C#\Login_Project_For_Win.Form\WindowsFormsApp1\view.png");

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;

                HIdeShow.BackgroundImage = Image.FromFile(@"A:\Projects C#\Login_Project_For_Win.Form\WindowsFormsApp1\hide.png");
            }

        }
    }
}
