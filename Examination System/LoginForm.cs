using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_email.Text == "" || textBox_password.Text == "")
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else
            {
                string uname = textBox_email.Text;
                string pass = textBox_password.Text;

                StudentForm main = new StudentForm();
                this.Hide();
                main.Show();

               
            }
        }
    }
}
