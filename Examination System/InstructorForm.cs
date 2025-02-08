using System.Data;
using static DBConnect;
using System.Diagnostics;
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
            panel1.Visible = false;
            reportPanel.Visible = false;

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
            reportPanel.Visible = false;

        }

        private void but_Pinfo_Click(object sender, EventArgs e)
        {

            Highlighter.Height = but_Pinfo.Height;
            Highlighter.Top = but_Pinfo.Top;
            HomePanel.Visible = false;
            gen_exam_panel.Visible = false;
            Personal_info_Panel.Visible = true;
            panel1.Visible = false;
            reportPanel.Visible = false;

        }

        private void but_Exams_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_GenExams.Height;
            Highlighter.Top = but_GenExams.Top;
            HomePanel.Visible = false;
            Personal_info_Panel.Visible = false;
            panel1.Visible = false;
            gen_exam_panel.Visible = true;
            reportPanel.Visible = false;
        }
        private void but_Reports_Click(object sender, EventArgs e)
        {
            SetPanelVisibility(panel1);
            Highlighter.Height = button1.Height;
            Highlighter.Top = button1.Top;

            CreateButtons();
            panel1.Controls.Add(labelReports);
        }

        private void CreateButtons()
        {
            panel1.Controls.Clear();

            string[] buttonNames =
            {
        "Get Students per Track",
        "Get Student Grades",
        "Get Instructor Courses",
        "Get Topics per Course",
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

            int rows = 2, cols = 3, buttonWidth = 350, buttonHeight = 150, padding = 20;
            int totalWidth = (buttonWidth + padding) * cols - padding;
            int totalHeight = (buttonHeight + padding) * rows - padding;
            int startX = (panel1.Width - totalWidth) / 2;
            int startY = (panel1.Height - totalHeight) / 2;

            for (int i = 0; i < buttonNames.Length; i++)
            {
                Button btn = new Button
                {
                    Text = buttonNames[i],
                    Size = new System.Drawing.Size(buttonWidth, buttonHeight),
                    Location = new System.Drawing.Point(
                        startX + (i % cols) * (buttonWidth + padding),
                        startY + (i / cols) * (buttonHeight + padding)
                    ),
                    BackColor = System.Drawing.Color.FromArgb(178, 8, 55),
                    ForeColor = System.Drawing.Color.White,
                    Font = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat
                };

                if (i < actions.Length) // Prevents out-of-range errors
                    btn.Click += actions[i];

                panel1.Controls.Add(btn);
            }
        }

        private void SetPanelVisibility(Panel activePanel)
        {
            HomePanel.Visible = false;
            Personal_info_Panel.Visible = false;
            gen_exam_panel.Visible = false;
            panel1.Visible = false;
            reportPanel.Visible = false;

            activePanel.Visible = true;
        }

        private string currentProcedure;


        private void ShowReportPanel(string title, string procedureName, int paramCount, string[] paramNames)
        {
            SetPanelVisibility(reportPanel);
            reportPanel.Controls.Clear();

            // Center title at the top with a margin-top of 100px
            titleLabel.Text = title;
            titleLabel.Font = new System.Drawing.Font("Arial", 28, System.Drawing.FontStyle.Bold);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.AutoSize = false;
            titleLabel.Width = reportPanel.Width;
            titleLabel.Top = 200;
            titleLabel.Height = 100;
            titleLabel.Left = reportPanel.Width/2;

            reportPanel.Controls.Add(titleLabel);

            currentProcedure = procedureName;
            parameterInputs = new TextBox[paramCount];

            int leftMargin = 100;
            int topMargin = 300; // Below title
            int spacing = 100;    // Spacing between elements

            for (int i = 0; i < paramCount; i++)
            {
                Label paramLabel = new Label
                {
                    Text = paramNames[i],
                    Left = leftMargin,
                    Top = topMargin + (i * spacing),
                    AutoSize = true,
                    Font = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold)

                };

                TextBox textBox = new TextBox
                {
                    Width = 250,
                    Height=120,
                    Left = leftMargin,
                    Top = paramLabel.Top + 50 // Positioned below label
                };

                reportPanel.Controls.Add(paramLabel);
                reportPanel.Controls.Add(textBox);
                parameterInputs[i] = textBox;
            }

            // Adjust button size and position
            viewReportButton.Width = 100;
            viewReportButton.Height = 80;
            viewReportButton.Left = leftMargin;
            viewReportButton.Font = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            viewReportButton.Top = topMargin + (paramCount * spacing) + 20;

            reportPanel.Controls.Add(viewReportButton);
        }


        private async void ViewReportButton_Click(object sender, EventArgs e)
        {
            string query = $"EXEC {currentProcedure} ";
            query += string.Join(", ", parameterInputs.Select(p => $"'{p.Text}'"));

            await LoadReportAsync(query);
        }

        private async Task LoadReportAsync(string query)
        {
            string connectionString = "Data Source=DESKTOP-J5GGBDS\\SQLEXPRESS;Initial Catalog=\"Examination System\";Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    await conn.OpenAsync();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    reportViewer.LocalReport.DataSources.Clear();
                    reportViewer.LocalReport.DataSources.Add(new ReportDataSource("ReportData", dt));
                    reportViewer.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event Handlers
        private void GetStudentsPerTrack(object sender, EventArgs e) { ShowReportPanel("Get Students per Track", "ReportTrackStudents", 1, new[] { "Track ID" }); }
        private void GetStudentGrade(object sender, EventArgs e) { ShowReportPanel("Get Student Grade", "ReportStudentsGrades", 1, new[] { "Student ID" }); }
        private void GetInstructorCourses(object sender, EventArgs e) { ShowReportPanel("Get Instructor Courses", "ReportInstCourses", 1, new[] { "Instructor ID" }); }
        private void GetTopicsPerTrack(object sender, EventArgs e) { ShowReportPanel("Get Topics Per Course", "GetTopicByCourseID", 1, new[] { "Course ID" }); }
        private void GetExamQuestions(object sender, EventArgs e) { ShowReportPanel("Get Exam Questions", "ReportExamQuestions", 1, new[] { "Exam ID" }); }
        private void GetStudentAnswers(object sender, EventArgs e) { ShowReportPanel("Get Student Answers", "ReportStudentAnswer", 2, new[] { "Student ID", "Exam ID" }); }

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
