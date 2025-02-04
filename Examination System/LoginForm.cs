using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DBConnect;

namespace Examination_System
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {

            InitializeComponent();
        }

        private void Close_But_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Mini_but_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button_login_Click(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
            string pass = textBox_password.Text;
            string[] Student;

            // Will Return all user attributes union Student attributes "ID No Dublication"
            int flag = SelectQ(@$"Select U.*,S.Specialist From Users U, Student S 
                            Where U.Email ='{email}' AND U.Password = '{pass}'
                            And U.ID=S.ID", out Student);
            if (flag == 1)
            {
                if (Student[6] == "Student")
                {
                    StudentForm main = new StudentForm(Student);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    // Naviagte to Instructor Page
                }

            }
            else
                if (textBox_email.Text == "" || textBox_password.Text == "")
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Your Password or Email Is not Correct", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

    }
}
