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
using Microsoft.Reporting.WinForms;
using Microsoft.Data.SqlClient;

namespace Examination_System
{
    public partial class InstructorForm : Form
    {

        List<Course> coursesList = new List<Course>();
        List<Exam> examList = new List<Exam>();
        private List<string> imagePaths = new List<string>
    {
        "C:\\Users\\AA\\source\\repos\\Examination-System\\Examination System\\Resources\\result_Final.PNG"

    };

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
            gen_exam_panel.Visible = false;
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
        private void but_Reports_Click(object sender, EventArgs e)
        {
            // Adjust highlighter position
            Highlighter.Height = button1.Height;
            Highlighter.Top = button1.Top;

            // Show only the report panel
            HomePanel.Visible = false;
            Personal_info_Panel.Visible = false;
            gen_exam_panel.Visible = false;
            panel1.Visible = true;

            // Create buttons dynamically
            CreateButtons();
        }

        private void CreateButtons()
        {
            // Clear existing buttons to avoid duplication
            panel1.Controls.Clear();

            string[] buttonNames =
            {
        "Get Students per Track",
        "Get Student Grade",
        "Get Instructor Courses",
        "Get Topics per Track",
        "Get Exam Questions",
        "Get Student Answers"
    };

            EventHandler[] actions =
            {
        GetStudentsPerTrack,
        GetStudentGrade,
        GetInstructorCourses,
        GetTopicsPerTrack,
        GetExamQuestions,
        GetStudentAnswers
    };

            int rows = 2;
            int cols = 3;
            int buttonWidth = 150;
            int buttonHeight = 40;
            int padding = 15;

            for (int i = 0; i < buttonNames.Length; i++)
            {
                Button btn = new Button
                {
                    Text = buttonNames[i],
                    Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                    Location = new System.Drawing.Point((i % cols) * (buttonWidth + padding), (i / cols) * (buttonHeight + padding)),
                    BackColor = System.Drawing.Color.LightBlue,
                    Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat
                };

                // Attach corresponding event handler
                btn.Click += actions[i];

                // Add button to panel
                panel1.Controls.Add(btn);
            }
        }

        // Example placeholders for button functionalities
        private void GetStudentsPerTrack(object sender, EventArgs e)
        {
            MessageBox.Show("Fetching students per track...");
        }

        private void GetStudentGrade(object sender, EventArgs e)
        {
            MessageBox.Show("Fetching student grades...");
        }

        private void GetInstructorCourses(object sender, EventArgs e)
        {
            MessageBox.Show("Fetching instructor courses...");
        }

        private void GetTopicsPerTrack(object sender, EventArgs e)
        {
            MessageBox.Show("Fetching topics per track...");
        }

        private void GetExamQuestions(object sender, EventArgs e)
        {
            MessageBox.Show("Fetching exam questions...");
        }

        private void GetStudentAnswers(object sender, EventArgs e)
        {
            MessageBox.Show("Fetching student answers...");
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
            examList.Clear();
            view_exams_panel.Controls.Clear();
            ProcedureQ("GetExamsByCourse", new string[] { "@Crs_id" }, new object[] { courseId }, out string[] examArray);

            if (examArray.Length % 5 != 0)
            {
                MessageBox.Show("No Exams For This Course.");
            }
            else
            {
                int buttonsPerRow = 5;
                int buttonWidth = 150;
                int buttonHeight = 150;
                int spacingX = 50; // Horizontal spacing
                int spacingY = 50; // Vertical spacing

                for (int i = 0; i < examArray.Length; i += 5)
                {
                    var exam = new Exam(
                        int.Parse(examArray[i]),
                        int.Parse(examArray[i + 1]),
                        int.Parse(examArray[i + 2]),
                        int.Parse(examArray[i + 3]),
                        int.Parse(examArray[i + 4])
                    );

                    examList.Add(exam);
                    gen_exam_panel.Visible = false;
                    view_exams_panel.Visible = true;
                }
                for (int i = 0; i < examList.Count; i++)
                {

                    int row = (i / buttonsPerRow) % 2;
                    int col = (i % buttonsPerRow);

                    // Container for PictureBox and Label
                    Panel panel = new Panel
                    {
                        Width = buttonWidth,
                        Height = buttonHeight + 30, // Extra space for label
                        Top = 300 + (row * (buttonHeight + spacingY)),
                        Left = 150 + (col * (buttonWidth + spacingX))
                    };

                    // PictureBox as the button image
                    PictureBox pictureBox = new PictureBox
                    {
                        Width = buttonWidth,
                        Height = buttonHeight,
                        Image = Image.FromFile("C:\\Users\\AA\\source\\repos\\Examination-System\\Examination System\\Resources\\result_Final.PNG"), // Change to your image path
                        SizeMode = PictureBoxSizeMode.AutoSize, // Ensure it fits
                        Cursor = Cursors.Hand
                    };

                    pictureBox.Click += (sender, e) => MessageBox.Show($"Button {i + 1} clicked!");

                    // Label for text
                    Label label = new Label
                    {
                        Text = $"Exam {i + 1}",
                        Width = buttonWidth,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Top = buttonHeight + 5
                    };

                    // Add controls to panel
                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(label);
                    view_exams_panel.Controls.Add(panel);
                }
            }

        }
        private void LoadReport()
        {
            // Set processing mode
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\AA\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Report1.rdlc"; // Ensure this file is added in the project

            DataTable dt = GetDataFromDatabase();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);

            // Clear existing data sources and add the new one
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Refresh the report
            reportViewer1.RefreshReport();
        }
        private DataTable GetDataFromDatabase()
        {
            DataTable dt = new DataTable();

            // Connection string - Update with your database details
            string connectionString = "Data Source=DESKTOP-J5GGBDS\\SQLEXPRESS;Initial Catalog=\"Examination System\";Integrated Security=True;";

            // SQL Query - Adjust to match your database table structure
            string query = "Exec ReportTrackStudents @Track=2";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }

            return dt;
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
