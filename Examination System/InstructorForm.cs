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
using Microsoft.VisualBasic.Devices;

namespace Examination_System
{
    public partial class InstructorForm : Form
    {
        
        int[] course_id;
        int[] std_num;
        string[] course_name;
        string[] exam;
        public InstructorForm(string[] Teacher)
        {
            InitializeComponent();

            string[] temp;

            // so that Home button is intialized first then we take its coordinate
            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;

            SelectQ(@$"Select COUNT(T.Crs_ID)
                        From Ins I join Teach T
                        on T.Ins_ID = I.ID
                        Group By I.ID
                        Having I.ID = {Teacher[0]}", out temp);

            Clab_ID.Text = Teacher[0];
            Clab_crs.Text = temp[0];

            SelectQ(@$"Select T.Name
                        From Ins I join Track T
                        on I.Track_ID=T.ID
                        Where T.ID ={Teacher[0]}", out temp);
            Clab_track.Text = temp[0];

            string[] courses;
            
            ProcedureQ("ReportInstCourses", ["@Inst_Id"], [Teacher[0]], out courses);
            course_id = new int[courses.Length];  // Adjust the size based on the number of courses you expect
            std_num = new int[courses.Length];
            course_name = new string[courses.Length];
            for (int i = 0; i < courses.Length; i+=3)
            {
                course_name[i]= courses[i];
                course_id[i] = int.Parse(courses[i+1]);
                std_num[i] = int.Parse(courses[i+2]);
                dataGridView1.Rows.Add(courses[i], courses[i+2]);

            }
           

            gen_exam_panel.Visible = false;
            Personal_info_Panel.Visible = false;

            Change_ID.Text = " " + Teacher[0];
            Change_Name.Text = " " + Teacher[1];
            Change_Email.Text = " " + Teacher[3];
            Change_DOB.Text = " " + Teacher[4];
            Change_Gender.Text = " " + Teacher[5];
            Change_Type.Text = " " + Teacher[6];
            Change_Address.Text = " " + Teacher[7];
            Change_Speciality.Text = " " + Teacher[8];

        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void but_Home_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;
            Personal_info_Panel.Visible = false;
            HomePanel.Visible = true;

        }

        private void but_Pinfo_Click(object sender, EventArgs e)
        {

            Highlighter.Height = but_Pinfo.Height;
            Highlighter.Top = but_Pinfo.Top;
            HomePanel.Visible = false;
            Personal_info_Panel.Visible = true;

        }

        private void but_Exams_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_GenExams.Height;
            Highlighter.Top = but_GenExams.Top;
            HomePanel.Visible = false;
            Personal_info_Panel.Visible = false;
            gen_exam_panel.Visible = true; 
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void gen_exam_click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string courseName = dataGridView1.Rows[e.RowIndex].Cells["Course"].Value.ToString();
                int courseId = course_id[e.RowIndex];
                using (InputDialog dialog = new InputDialog(courseName))
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        int input1 = int.Parse(dialog.Input1);
                        int input2 = int.Parse(dialog.Input2);
                        int[] tmep = [courseId, input1, input2];
                        ProcedureQ("GenerateExam", ["@Crs_ID","@MCQ_Count","@TF_Count"], [courseId, input1,input2], out exam);
                        MessageBox.Show($"Exam generated for {courseName} with inputs: {input1}, {input2}");
                    }
                }
            }
        }

    }
}
