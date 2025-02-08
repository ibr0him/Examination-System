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
using Examination_System.Instr;
using Microsoft.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace Examination_System
{
    public partial class InstructorForm : Form
    {
        // For Making the form Dragable on dragging Certain Forms
        private bool Win_dragging = false;
        private Point Win_dragCursorPoint;
        private Point Win_dragFormPoint;

        private void but_Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void but_Home_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;
            Personal_info_Panel.Visible = false;
            gen_exam_panel.Visible = false;
            view_exams_panel.Visible = false;
            RedBar.Visible = true;
            RedFlag.Visible = true;
            HomePanel.Visible = true;

        }

        private void but_Pinfo_Click(object sender, EventArgs e)
        {

            Highlighter.Height = but_Pinfo.Height;
            Highlighter.Top = but_Pinfo.Top;
            HomePanel.Visible = false;
            gen_exam_panel.Visible = false;
            view_exams_panel.Visible = false;
            RedBar.Visible = true;
            RedFlag.Visible = true;
            Personal_info_Panel.Visible = true;

        }

        private void but_Exams_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_GenExams.Height;
            Highlighter.Top = but_GenExams.Top;
            HomePanel.Visible = false;
            Personal_info_Panel.Visible = false;
            view_exams_panel.Visible = false;
            RedBar.Visible = true;
            RedFlag.Visible = true;
            gen_exam_panel.Visible = true;
        }
        /////////////////////////////////////////////////////////////////////
        ///Aziz 
        private void but_Reports_Click(object sender, EventArgs e)
        {
            SetPanelVisibility(panel1);
            Highlighter.Height = button1.Height;
            Highlighter.Top = button1.Top;
            RedBar.Visible = true;
            RedFlag.Visible = true;
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
            titleLabel.Left = reportPanel.Width / 2;

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
                    Height = 120,
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

            //await LoadReportAsync(query);
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


        /////////////////////////////////////////////////////////////////////

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

        private void PinfoTB_Selected(object sender, EventArgs e)
        {
            Pinfo_Save.Visible = true;
        }

        private void Pinfo_Save_Click(object sender, EventArgs e)
        {
            // vaildation DOB

            if (Teachers[4] != Change_DOB.Text)
            {
                Teachers[4] = Change_DOB.Text.Trim();

                string temp = Teachers[4];
                int count = 0;

                for (int i = 0; i < temp.Length; i++)
                    if (temp[i] == '/')
                        count++;

                if (count != 2)
                {
                    MessageBox.Show("Please Enter The DOB in This Formate 'DD/MM/YYY'",
                        "Wrong DOB Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string[] Num = temp.Split('/');
                    for (int i = 0; i < Num.Length; i++)
                        if (!int.TryParse(Num[i], out int number))
                        {
                            MessageBox.Show("DOB Only Accepts Numbers With Special Charater '/ '",
                                "Wrong DOB Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                }

            }

            Teachers[1] = Change_Name.Text.Trim();
            Teachers[7] = Change_Address.Text.Trim();
            Teachers[8] = Change_Salary.Text.Trim();

            string result = string.Empty;
            string Query1 = $@"Update Users
                            Set Name = '{Teachers[1]}',DOB ='{Teachers[4]}',Address='{Teachers[7]}'
                            Where ID = {Teachers[0]}";


            result = $"{ModifyQ(Query1)}";

            if (result.Contains("Error"))
            {
                MessageBox.Show(result, "Wrong Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                MessageBox.Show("Information Has Been Updated Successfully");

            Pinfo_Save.Visible = false;
        }

        private void but_Notification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Futuristic Feature Not Required And Not Implemented Yet !");
        }

        private void but_setting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Futuristic Feature Not Required And Not Implemented Yet !");
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Win_dragging = true;
            Win_dragCursorPoint = Cursor.Position;
            Win_dragFormPoint = this.Location;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Win_dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(Win_dragCursorPoint));
                this.Location = Point.Add(Win_dragFormPoint, new Size(diff));
            }
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            Win_dragging = false;
        }
    }
}
