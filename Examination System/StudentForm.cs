using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using static DBConnect;
using System.Diagnostics;

namespace Examination_System
{
    public partial class StudentForm : Form
    {

        public StudentForm(string[] Student)
        {
            InitializeComponent();

            string[] temp;

            // so that Home button is intialized first then we take its coordinate
            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;

            SelectQ(@$"Select Count(T.Crs_ID) 
            From Student S join Track_Courses T 
            on S.Track_ID = T.Track_ID 
            Group By S.ID Having ID ={Student[0]}", out temp);

            Clab_ID.Text = Student[0];
            Clab_crs.Text = temp[0];

            SelectQ(@$"Select T.Name From Student S , Track T 
            Where S.Track_ID = T.ID AND S.ID = {Student[0]}", out temp);
            Clab_track.Text = temp[0];

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
            StudentPersonalInfo info_sub = new StudentPersonalInfo();
            Highlighter.Height = but_Pinfo.Height;
            Highlighter.Top = but_Pinfo.Top;
            this.Hide();
            info_sub.Show();
        }

        private void but_Exams_Click(object sender, EventArgs e)
        {
            StudentExam exam_sub = new StudentExam();
            Highlighter.Height = but_Exams.Height;
            Highlighter.Top = but_Exams.Top;
            this.Hide();
            exam_sub.Show();
        }

        private void but_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm L = new LoginForm();
            L.Show();

        }

        private void but_FB_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/ITISmartVillageBranch",
                UseShellExecute = true  // Ensures it opens in the default browser
            });
        }

        private void but_twitter_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://x.com/iti_channel/status/1790013804291527145",
                UseShellExecute = true
            });
        }

        private void but_instagram_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/explore/locations/192119237540159/iti-smart-village/recent/",
                UseShellExecute = true
            });
        }
    }
}
