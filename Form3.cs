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
  
    public partial class Userregister : Form
    {
        public Userregister()
        {
            InitializeComponent();
        }

      
        private void Enter1_Click(object sender, EventArgs e)
        {
            string Firsname, Lastname;
            Firsname = TxtUsername.Text;
            Lastname = TxtLastname.Text;
         
            ///________________________//
            MessageBox.Show("Welcome " + Firsname + " " + Lastname + "\nYour account has been registered successfully!");


        }

        private void HIdeShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar==true)
            {
                txtPassword.UseSystemPasswordChar = false;
               HIdeShow2.BackgroundImage = Image.FromFile(@"A:\Projects C#\Login_Project_For_Win.Form\WindowsFormsApp1\view.png");

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                HIdeShow2.BackgroundImage = Image.FromFile(@"A:\Projects C#\Login_Project_For_Win.Form\WindowsFormsApp1\hide.png");

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Userregister_Load(object sender, EventArgs e)
        {

        }
    }
}
