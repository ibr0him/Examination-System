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
