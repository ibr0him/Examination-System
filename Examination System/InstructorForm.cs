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

        List<Course> coursesList = new List<Course>();
        string[] coursesArray;
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

            ProcedureQ("ReportInstCourses", new string[] { "@Inst_Id" }, new object[] { Teacher[0] }, out string[] coursesArray);

            if (coursesArray.Length % 3 != 0)
            {
                MessageBox.Show("Error: Unexpected course data format.");
            }
            else
            {
                for (int i = 0; i < coursesArray.Length; i += 3)
                {
                    var course = new Course(
                        coursesArray[i], // Course Name
                        int.Parse(coursesArray[i + 1]), // Course ID
                        int.Parse(coursesArray[i + 2])  // Student Number
                    );

                    coursesList.Add(course);

                    dataGridView1.Rows.Add(course.Id, course.Name, course.StudentCount);
                }
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var columnIndex = e.ColumnIndex;

                string courseName = dataGridView1.Rows[e.RowIndex].Cells["CourseName"].Value.ToString();
                int courseId = (int)dataGridView1.Rows[e.RowIndex].Cells["CourseID"].Value;

                if (dataGridView1.Columns[columnIndex].Name == "gen")
                {
                    using (InputDialog dialog = new InputDialog(courseName))
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            int input1 = int.Parse(dialog.Input1); // MCQ count
                            int input2 = int.Parse(dialog.Input2); // True/False count

                            ProcedureQ("GenerateExam",
                                new string[] { "@Crs_ID", "@MCQ_Count", "@TF_Count" },
                                new object[] { courseId, input1, input2 },
                                out string[] exam);

                            MessageBox.Show($"Exam generated for {courseName} with {input1} MCQs and {input2} True/False questions.");
                        }
                    }
                }
                else if (dataGridView1.Columns[columnIndex].Name == "viewExamsButton")
                {
                    ViewExams(courseName, courseId);
                }
            }
        }

        private void ViewExams(string courseName, int courseId)
        {
            MessageBox.Show($"Viewing exams for {courseName} (Course ID: {courseId})");
        }


    }
}
