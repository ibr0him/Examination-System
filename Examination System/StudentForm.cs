using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Examination_System
{
    public partial class StudentForm : Form
    {

        public StudentForm()
        {
            InitializeComponent();
            // so that Home button is intialized first then we take its coordinate
            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;

        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void but_Home_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;

        }

        private void but_Pinfo_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_Pinfo.Height;
            Highlighter.Top = but_Pinfo.Top;
        }

        private void but_Exams_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_Exams.Height;
            Highlighter.Top = but_Exams.Top;
        }

        private void but_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm L = new LoginForm();
            L.Show();

        }
    }
}
