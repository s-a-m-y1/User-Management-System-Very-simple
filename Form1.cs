using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class UserChoos : Form
    {
        public UserChoos()
        {
            InitializeComponent();
          
        }
        //

        private void button1_Click(object sender, EventArgs e)
        {
            Form Fr = new Userregister();
            Fr.Show();
        }

        private void ButLogin_Click(object sender, EventArgs e)
        {
            Form Frm = new LoginScreen();
            Frm.Show();
        }

        private void UserChoos_Load(object sender, EventArgs e)
        {
           
        }

        

      

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enabled = true;
             Clock1.Text=  DateTime.Now.ToString("hh:mm:ss tt" );
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Enabled = true;
            //this.Text = "Current Time: " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}

