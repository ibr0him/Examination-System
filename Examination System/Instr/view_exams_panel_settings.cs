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

namespace Examination_System
{
    public partial class InstructorForm : Form
    {

      
        private void ViewExams(string courseName, int courseId)
        {
           

            ProcedureQ("GetExamsByCourse", new string[] { "@Crs_id" }, new object[] { courseId }, out string[] examArray);

            if (examArray.Length % 5 != 0)
                PopUp.ErrorMessage("No Exams For This Course.");
            else
            {
                examList.Clear();
                view_exams_panel.Controls.Clear();
                view_exams_panel.AutoScroll = true;
                RedBar.Hide();
                RedFlag.Hide();
                view_exams_panel.Dock = DockStyle.Fill;
                view_exams_panel.BringToFront();


                Label titleLabel = new Label
                {
                    Text = $"Exams for {courseName}",
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = view_exams_panel.Width,
                    Height = 40,
                    Dock = DockStyle.Top,
                    BackColor = Color.DarkRed,
                    ForeColor = Color.White,
                };


                view_exams_panel.Controls.Add(titleLabel);
                int buttonsPerRow = 5;
                int buttonWidth = 150;
                int buttonHeight = 150;
                int spacingX = 50;
                int spacingY = 50;
                int startY = 60;

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

                int totalRows = (examList.Count + buttonsPerRow - 1) / buttonsPerRow;

                for (int i = 0; i < examList.Count; i++)
                {
                    int row = i / buttonsPerRow;
                    int col = i % buttonsPerRow;

                    Panel panel = new Panel
                    {
                        Width = buttonWidth,
                        Height = buttonHeight + 30,
                        Top = startY + (row * (buttonHeight + spacingY)),
                        Left = 150 + (col * (buttonWidth + spacingX))
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Width = buttonWidth,
                        Height = buttonHeight,
                        Image = (Image)resources1.GetObject("pictureBox2.Image"),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Cursor = Cursors.Hand
                    };

                    pictureBox.Click += (sender, e) => new PopUp($"Exam View").DoneMessage("");

                    Label label = new Label
                    {
                        Text = $"Exam {i + 1}",
                        Width = buttonWidth,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Top = buttonHeight + 5
                    };

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(label);
                    view_exams_panel.Controls.Add(panel);
                }

                view_exams_panel.AutoScrollMinSize = new Size(view_exams_panel.Width, (totalRows * (buttonHeight + spacingY)) + startY);
            }
        }




    }
}
