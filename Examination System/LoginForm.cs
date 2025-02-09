using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            string[] Teachers;

            
            int flag = SelectQ(@$"Select * From Users
                            Where Email ='{email}' AND Password = '{pass}'", out Student);
            if (flag == 1)
            {
                if (Student[6] == "Student")
                {
                    // Will Return all user attributes union Student attributes "ID No Dublication"
                    SelectQ(@$"Select U.*,S.Specialist From Users U, Student S 
                            Where U.Email ='{email}' AND U.Password = '{pass}'
                            And U.ID=S.ID", out Student);
                    
                    Student[4]=Student[4].Split(" ")[0];
                    StudentForm main = new StudentForm(Student);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    // Will Return all user attributes union Instructor attributes "ID No Dublication"
                    SelectQ(@$"Select U.*,I.Salary From Users U, Ins I 
                        Where U.Email ='{email}' AND U.Password = '{pass}'
                        And U.ID=I.ID", out Teachers);
                    Teachers[4]=Teachers[4].Split(" ")[0];
                    InstructorForm teach = new InstructorForm(Teachers);
                    this.Hide();
                    teach.Show();
                }

            }
            else
            {
                if (textBox_email.Text == "" || textBox_password.Text == "")
                    PopUp.ErrorMessage("Please Fill Your login Data");
                else
                    PopUp.ErrorMessage("Your Password or Email Is not Correct");
            }
        }

    }
}
