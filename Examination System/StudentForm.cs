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
using Examination_System.Properties;
using System.Resources;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;
using System.Web;
using System.Timers;
using Examination_System.Instr;


namespace Examination_System
{
    public partial class StudentForm : Form
    {
        // For Showing Exams Upper and lower Panels
        private static Panel[] Upper_Ex;
        private static Panel[] Lower_Ex;

        // Flags for keeping track of the panels
        private static int Upper_index = 0;
        private static int Lower_index = 0;

        private static string[] Student;

        // For Exam
        private static string[] Questions;
        private static int[] Q_IDs;
        private static string[][] Chioces;
        private static string[] User_Ans;
        private static int Q_index = 0;
        private static Panel[] QChoices_Panel;
        private static int Exam_id;
        private static int Crs_ID;

        // Exam Timer
        private System.Timers.Timer ExamTimer;
        private int RemTime;
        private int[] Timer_Color;
        private int ExamTotalTime;



        // For Making the form Dragable on dragging Certain Forms
        private bool Win_dragging = false;
        private Point Win_dragCursorPoint;
        private Point Win_dragFormPoint;

        public StudentForm(string[] Stud)
        {
            InitializeComponent();

            string[] temp;

            Student = Stud;
            // so that Home button is intialized first then we take its coordinate
            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;

            SelectQ(@$"Select Count(T.Crs_ID) 
            From Student S join Track_Courses T 
            on S.Track_ID = T.Track_ID 
            Group By S.ID Having ID ={Stud[0]}", out temp);

            Clab_ID.Text = Stud[0];
            Clab_crs.Text = temp[0];

            SelectQ(@$"Select T.Name From Student S , Track T 
            Where S.Track_ID = T.ID AND S.ID = {Stud[0]}", out temp);
            Clab_track.Text = temp[0];


            Personal_info_Panel.Visible = false;
            ExamView_Panel.Visible = false;
            TakeExam_Panel.Visible = false;


            //Personal info Fields
            Change_ID.Text = " " + Stud[0];
            Change_Name.Text = " " + Stud[1];
            Change_Email.Text = " " + Stud[3];
            Change_DOB.Text = " " + Stud[4];
            Change_Gender.Text = " " + Stud[5];
            Change_Type.Text = " " + Stud[6];
            Change_Address.Text = " " + Stud[7];
            Change_Speciality.Text = " " + Stud[8];
            Pinfo_Save.Visible = false;


        }

        private void but_Close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void but_Home_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;

            HomePanel.Visible = true;

            Personal_info_Panel.Visible = false;
            ExamView_Panel.Visible = false;
            TakeExam_Panel.Visible = false;

        }

        private void but_Pinfo_Click(object sender, EventArgs e)
        {
            Highlighter.Height = but_Pinfo.Height;
            Highlighter.Top = but_Pinfo.Top;

            Personal_info_Panel.Visible = true;

            HomePanel.Visible = false;
            ExamView_Panel.Visible = false;
            TakeExam_Panel.Visible = false;

        }

        private void but_Exams_Click(object sender, EventArgs e)
        {

            Highlighter.Height = but_Exams.Height;
            Highlighter.Top = but_Exams.Top;

            ExamView_Panel.Visible = true;

            HomePanel.Visible = false;
            Personal_info_Panel.Visible = false;
            TakeExam_Panel.Visible = false;

            ShowTakOutGoingExams();

        }
        private void ShowTakOutGoingExams()
        {

            string[] Output;
            int FE_count, OutE_count;
            string[] DBFE_Crs;
            string[] DBOutE_crs;
            int[] DBGrades;
            System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));


            // Getting Data From DB


            // Returns number of cources that the student has take their exam
            string query = @$"Select Count(C.ID)
                                From Student S join TakeExam T
                                on S.ID = T.St_ID join Course C
                                on C.ID = T.Crs_ID
                                Where S.ID ={Student[0]}";

            if (SelectQ(query, out Output) == 1)
            {
                FE_count = int.Parse(Output[0]);

                if (FE_count > 0)
                {
                    query = @$"Select Distinct C.Name , T.Grade
                            From Student S join TakeExam T
                            on S.ID = T.St_ID join Course C
                            on C.ID = T.Crs_ID
                            Where S.ID ={Student[0]}";

                    if (SelectQ(query, out Output) == 1)
                    {
                        DBFE_Crs = new string[Output.Length / 2];
                        DBGrades = new int[Output.Length / 2];

                        int tr = 0;
                        for (int i = 0; tr < Output.Length; i++)
                        { DBFE_Crs[i] = Output[tr]; tr += 2; }

                        tr = 1;
                        for (int i = 0; tr < Output.Length; i++)
                        {
                            if (Output[tr] == "NULL")
                                DBGrades[i] = 0;
                            else
                                DBGrades[i] = int.Parse(Output[tr]);
                            tr += 2;
                        }

                        // Upper Panel's Componets
                        Panel[] FE_Panel = new Panel[FE_count];
                        PictureBox[] imgs = new PictureBox[FE_count];
                        Label[] FE_grade = new Label[FE_count];
                        Label[] FE_Crs = new Label[FE_count];

                        int x, temp1;

                        temp1 = (int)Math.Ceiling(DBFE_Crs.Length / 7.0);
                        Upper_Ex = new Panel[temp1];

                        // Adding Componets to The Upper Panel
                        int iterator = 0, Counter = 0;
                        for (int k = 0; k < Upper_Ex.Length; k++)
                        {
                            Upper_Ex[k] = new Panel(); ;
                            Upper_Ex[k].Location = new Point(70, 160);
                            Upper_Ex[k].Name = $"Upper_Ex{k}";
                            Upper_Ex[k].Size = new Size(1045, 186);
                            ExamView_Panel.Controls.Add(Upper_Ex[k]);

                            x = 0;
                            for (; (iterator < FE_count) && (Counter != 7); iterator++)
                            {

                                // FE_Grade

                                FE_grade[iterator] = new Label();
                                FE_grade[iterator].AutoSize = true;
                                FE_grade[iterator].BackColor = Color.FromArgb(178, 8, 55);
                                FE_grade[iterator].Font = new Font("Showcard Gothic", 16F);
                                FE_grade[iterator].ForeColor = Color.White;
                                FE_grade[iterator].Name = $"FE_Grade{iterator}";
                                FE_grade[iterator].Size = new Size(64, 28);

                                if (DBGrades[iterator] < 10)
                                {
                                    FE_grade[iterator].Location = new Point(80, 21);
                                    FE_grade[iterator].Text = $"{DBGrades[iterator]}%";

                                }
                                if (DBGrades[iterator] < 100 && DBGrades[iterator] >= 10)
                                {
                                    FE_grade[iterator].Location = new Point(75, 21);
                                    FE_grade[iterator].Text = $"{DBGrades[iterator]}%";

                                }
                                if (DBGrades[iterator] == 100)
                                {
                                    FE_grade[iterator].Location = new Point(65, 21);
                                    FE_grade[iterator].Text = $"{DBGrades[iterator]}%";

                                }
                                // FE_img

                                imgs[iterator] = new PictureBox();
                                imgs[iterator].Image = (Image)resources1.GetObject("pictureBox2.Image");
                                imgs[iterator].Location = new Point(3, 0);
                                imgs[iterator].Name = $"FE_img{iterator}";
                                imgs[iterator].Size = new Size(129, 153);
                                imgs[iterator].SizeMode = PictureBoxSizeMode.AutoSize;

                                // Panel

                                FE_Panel[iterator] = new Panel();
                                FE_Panel[iterator].Controls.Add(FE_grade[iterator]);
                                FE_Panel[iterator].Controls.Add(imgs[iterator]);
                                FE_Panel[iterator].Location = new Point(x, 0);
                                FE_Panel[iterator].Name = $"Finished_Exams{iterator}";
                                FE_Panel[iterator].Size = new Size(141, 186);

                                // FE_Crs

                                FE_Crs[iterator] = new Label();
                                FE_Crs[iterator].AutoSize = true;
                                FE_Crs[iterator].Font = new Font("Century Gothic", 12F);
                                FE_Crs[iterator].Name = $"FE_Crs{iterator}";
                                FE_Crs[iterator].Size = new Size(89, 21);
                                FE_Crs[iterator].Text = DBFE_Crs[iterator];
                                FE_Panel[iterator].Controls.Add(FE_Crs[iterator]);
                                FE_Crs[iterator].Location = new Point(((129 - FE_Crs[iterator].Width) / 2), 158);


                                Upper_Ex[k].Controls.Add(FE_Panel[iterator]);
                                x += 150;
                                Counter++;
                            }
                            Counter = 0;
                        }




                    }
                    else
                    {
                        PopUp.ErrorMessage($"DataBase Error Parsing Finished Exams\n{Output[0]}");
                        return;
                    }

                }

                else
                {
                    Upper_Ex = new Panel[1];
                    Upper_Ex[0] = new Panel(); ;
                    Upper_Ex[0].Location = new Point(70, 160);
                    Upper_Ex[0].Name = $"Upper_Ex{0}";
                    Upper_Ex[0].Size = new Size(1045, 186);
                    ExamView_Panel.Controls.Add(Upper_Ex[0]);

                    // adding label to say that there is no Taken Exams

                    Label Note1 = new Label();

                    Note1.AutoSize = true;
                    Note1.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    Note1.Margin = new Padding(4, 0, 4, 0);
                    Note1.Name = "Note1";
                    Note1.Size = new Size(30, 33);
                    Note1.Text = "( There Is No Taken Exams Grades 😢 )";
                    Upper_Ex[0].Controls.Add(Note1);
                    Note1.Location = new Point(((Upper_Ex[0].Width - Note1.Width) / 2), ((Upper_Ex[0].Height - Note1.Height) / 2));

                }
            }

            else
            {
                PopUp.ErrorMessage($"DataBase Error Selecting Finished Exams\n{Output[0]}");
                return;
            }

            //Returns Number of Cources that the student hasn't take thier exam and there is Exam set by instructor

            query = $@"Select COUNT (Distinct C.Name)
                        From Student S 
                        join Track_Courses T on S.Track_ID = T.Track_ID 
                        join Course C on T.Crs_ID = C.ID 
                        join Exam E on E.Crs_ID = C.ID
                        Where C.Name NOT IN (
                            Select Distinct C2.Name
                            From Student S2 
                            join TakeExam T2 on S2.ID = T2.St_ID 
                            join Course C2 on C2.ID = T2.Crs_ID
                            Where S2.ID = S.ID  
                        ) And S.ID ={Student[0]}";

            if (SelectQ(query, out Output) == 1)
            {
                OutE_count = int.Parse(Output[0]);

                if (OutE_count > 0)
                {
                    query = $@"Select Distinct C.Name
                        From Student S 
                        join Track_Courses T on S.Track_ID = T.Track_ID 
                        join Course C on T.Crs_ID = C.ID 
                        join Exam E on E.Crs_ID = C.ID
                        Where C.Name NOT IN (
                            Select Distinct C2.Name
                            From Student S2 
                            join TakeExam T2 on S2.ID = T2.St_ID 
                            join Course C2 on C2.ID = T2.Crs_ID
                            Where S2.ID = S.ID  
                        ) And S.ID ={Student[0]}";

                    if (SelectQ(query, out Output) == 1)
                    {
                        DBOutE_crs = Output;

                        //Lower Panel 's Components
                        Panel[] OutE_Panel = new Panel[OutE_count];
                        PictureBox[] imgs2 = new PictureBox[OutE_count];
                        Label[] OutE_Crs = new Label[OutE_count];

                        // Adding Componets to the LowerPanel

                        int temp1 = (int)Math.Ceiling(DBOutE_crs.Length / 5.0), x;
                        Lower_Ex = new Panel[temp1];
                        int iterator2 = 0, Counter2 = 0;
                        for (int k = 0; k < Lower_Ex.Length; k++)
                        {

                            Lower_Ex[k] = new Panel(); ;
                            Lower_Ex[k].Location = new Point(50, 480);
                            Lower_Ex[k].Name = $"Lower_Ex{k}";
                            Lower_Ex[k].Size = new Size(1105, 193);
                            ExamView_Panel.Controls.Add(Lower_Ex[k]);

                            x = 0;
                            for (; (iterator2 < OutE_count) && (Counter2 != 5); iterator2++)
                            {
                                // OutE_img

                                imgs2[iterator2] = new PictureBox();
                                imgs2[iterator2].Image = (Image)resources1.GetObject("pictureBox3.Image");
                                imgs2[iterator2].Location = new Point(0, 0);
                                imgs2[iterator2].Name = $"OutE_img{iterator2}";
                                imgs2[iterator2].Size = new Size(219, 154);
                                imgs2[iterator2].SizeMode = PictureBoxSizeMode.AutoSize;
                                imgs2[iterator2].TabStop = false;

                                // OutE_panel

                                OutE_Panel[iterator2] = new Panel();
                                OutE_Panel[iterator2].Controls.Add(imgs2[iterator2]);
                                OutE_Panel[iterator2].Location = new Point(x, 0);
                                OutE_Panel[iterator2].Name = $"OutE_panel{iterator2}";
                                OutE_Panel[iterator2].Size = new Size(222, 193);

                                // OutE_Crs

                                OutE_Crs[iterator2] = new Label();
                                OutE_Crs[iterator2].AutoSize = true;
                                OutE_Crs[iterator2].Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                                OutE_Crs[iterator2].Name = $"OutE_Crs{iterator2}";
                                OutE_Crs[iterator2].Size = new Size(89, 21);
                                OutE_Crs[iterator2].Text = DBOutE_crs[iterator2];
                                OutE_Panel[iterator2].Controls.Add(OutE_Crs[iterator2]);
                                OutE_Crs[iterator2].Cursor = Cursors.Hand;
                                OutE_Crs[iterator2].Location = new Point(((219 - OutE_Crs[iterator2].Width) / 2), 163);
                                OutE_Crs[iterator2].Click += EnterExamButton_Click;

                                Lower_Ex[k].Controls.Add(OutE_Panel[iterator2]);
                                x += 220;
                                Counter2++;
                            }
                            Counter2 = 0;

                        }
                    }

                    else
                    {
                        PopUp.ErrorMessage($"DataBase Error Parsing Outgoing Exams\n{Output[0]}");
                        return;
                    }


                }

                else
                {
                    Lower_Ex = new Panel[1];
                    Lower_Ex[0] = new Panel(); ;
                    Lower_Ex[0].Location = new Point(50, 480);
                    Lower_Ex[0].Name = $"Lower_Ex{0}";
                    Lower_Ex[0].Size = new Size(1105, 193);
                    ExamView_Panel.Controls.Add(Lower_Ex[0]);

                    // adding label to say that there is no OutGoing Exam

                    Label Note2 = new Label();

                    Note2.AutoSize = true;
                    Note2.Font = new Font("Century Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    Note2.Margin = new Padding(4, 0, 4, 0);
                    Note2.Name = "Note2";
                    Note2.Size = new Size(30, 33);
                    Note2.Text = "( There Is No OutGoing Exams 🎉 )";
                    Lower_Ex[0].Controls.Add(Note2);
                    Note2.Location = new Point(((Lower_Ex[0].Width - Note2.Width) / 2), ((Lower_Ex[0].Height - Note2.Height) / 2));

                }
            }

            else
            {
                PopUp.ErrorMessage($"DataBase Error Selecting Outgoing Exams\n{Output[0]}");
                return;
            }

            // FE_Header

            Label FE_Header = new Label();
            FE_Header.AutoSize = true;
            FE_Header.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FE_Header.Location = new Point(20, 96);
            FE_Header.Name = "FE_Header";
            FE_Header.Size = new Size(184, 25);
            FE_Header.TabIndex = 0;
            FE_Header.Text = "Finished Exams :";
            ExamView_Panel.Controls.Add(FE_Header);

            // OutE_Header

            Label OutE_Header = new Label();
            OutE_Header.AutoSize = true;
            OutE_Header.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OutE_Header.Location = new Point(11, 400);
            OutE_Header.Name = "OutE_Header";
            OutE_Header.Size = new Size(187, 25);
            OutE_Header.Text = "Outgoing Exams :";
            ExamView_Panel.Controls.Add(OutE_Header);


            // Placing The Upper And Lower Panels Navigation Arrows Coordinates

            int x_coord, y_coord;

            x_coord = Upper_Ex[0].Location.X + Upper_Ex[0].Width;
            y_coord = Upper_Ex[0].Location.Y + ((Upper_Ex[0].Height - Rarrow.Height) / 2);
            Rarrow.Location = new Point(x_coord, y_coord);
            x_coord = Upper_Ex[0].Location.X - 60;
            Larrow.Location = new Point(x_coord, y_coord);

            x_coord = Lower_Ex[0].Location.X + Lower_Ex[0].Width;
            y_coord = Lower_Ex[0].Location.Y + ((Lower_Ex[0].Height - LowerRarrow.Height) / 2);
            LowerRarrow.Location = new Point(x_coord, y_coord);
            x_coord = Lower_Ex[0].Location.X - 25;
            LowerLarrow.Location = new Point(x_coord, y_coord);

            // Hiding untill needed
            Rarrow.Visible = false;
            Larrow.Visible = false;
            LowerLarrow.Visible = false;
            LowerRarrow.Visible = false;

            // Manging Arrows 

            if (FE_count > 7)
            {
                Rarrow.Visible = true;
                Rarrow.Cursor = Cursors.Hand;
                Larrow.Visible = true;
                Larrow.Image = (Image)resources1.GetObject("LowerLarrow.Image");
                Larrow.Cursor = Cursors.Default;
                Larrow.Enabled = false;
            }
            if (OutE_count > 5)
            {
                LowerRarrow.Visible = true;
                LowerRarrow.Cursor = Cursors.Hand;
                LowerRarrow.Image = (Image)resources1.GetObject("Rarrow.Image");
                LowerLarrow.Visible = true;
                LowerLarrow.Cursor = Cursors.Default;
                LowerLarrow.Enabled = false;
            }




        }
        private void EnterExamButton_Click(object sender, EventArgs e)
        {
            Label Clicked = sender as Label;


            if (new PopUp("Are You Sure You Want To Take The Exam Now ?").ConfirmMessage(""))
            {
                but_Home.Enabled = false;
                but_FB.Enabled = false;
                but_instagram.Enabled = false;
                but_Logout.Enabled = false;
                but_Notification.Enabled = false;
                but_Pinfo.Enabled = false;
                but_setting.Enabled = false;
                but_twitter.Enabled = false;
                but_Exams.Enabled = false;
                but_Close.Enabled = false;

                string[] Output;
                string Query = $@"Select ID From Course Where Name = '{Clicked.Text}'";
                SelectQ(Query, out Output);
                Crs_ID = int.Parse(Output[0]);
                TakeTheExam(Clicked.Text);
            }


        }
        private void but_Logout_Click(object sender, EventArgs e)
        {
            LoginForm L = new LoginForm();
            L.Show();

            //Reseting Static Flags
            Upper_index = 0;
            Lower_index = 0;
            Q_index = 0;
            Win_dragging = false;

            this.Close();
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


        private void but_setting_Click(object sender, EventArgs e)
        {
            new PopUp("Futuristic Feature Not Required And Not Implemented Yet !").DoneMessage("");
        }

        private void but_Notification_Click(object sender, EventArgs e)
        {
            new PopUp("Futuristic Feature Not Required And Not Implemented Yet !").DoneMessage("");

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
        private void ExLarrow_Click(object sender, EventArgs e)
        {
            Button Clicked = sender as Button;
            System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));

            if (Clicked.Name == "Larrow")
            {
                if (Upper_index >= 1)
                {
                    Upper_index--;

                    for (int i = 0; i < Upper_Ex.Length; i++)
                        if (i == Upper_index)
                            Upper_Ex[i].Visible = true;
                        else
                            Upper_Ex[i].Visible = false;

                    Rarrow.Enabled = true;
                    Rarrow.Image = (Image)resources1.GetObject("Rarrow.Image");

                    if (Upper_index == 0)
                    {
                        Larrow.Enabled = false;
                        Larrow.Image = (Image)resources1.GetObject("LowerLarrow.Image");
                    }
                }
            }
            else
            {
                if (Lower_index >= 1)
                {
                    Lower_index--;

                    for (int i = 0; i < Lower_Ex.Length; i++)
                        if (i == Lower_index)
                            Lower_Ex[i].Visible = true;
                        else
                            Lower_Ex[i].Visible = false;

                    LowerRarrow.Enabled = true;
                    LowerRarrow.Image = (Image)resources1.GetObject("Rarrow.Image");

                    if (Lower_index == 0)
                    {
                        LowerLarrow.Enabled = false;
                        LowerLarrow.Image = (Image)resources1.GetObject("LowerLarrow.Image");
                    }
                }

            }
        }
        private void ExRarrow_Click(object sender, EventArgs e)
        {
            Button Clicked = sender as Button;
            System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));

            if (Clicked.Name == "Rarrow")
            {
                if (Upper_index < Upper_Ex.Length - 1)
                {
                    Upper_index++;

                    for (int i = 0; i < Upper_Ex.Length; i++)
                        if (i == Upper_index)
                            Upper_Ex[i].Visible = true;
                        else
                            Upper_Ex[i].Visible = false;

                    Larrow.Enabled = true;
                    Larrow.Image = (Image)resources1.GetObject("Larrow.Image");

                    if (Upper_index == Upper_Ex.Length - 1)
                    {
                        Rarrow.Enabled = false;
                        Rarrow.Image = (Image)resources1.GetObject("LowerRarrow.Image");
                    }
                }
            }
            else
            {
                if (Lower_index < Lower_Ex.Length - 1)
                {
                    Lower_index++;

                    for (int i = 0; i < Lower_Ex.Length; i++)
                        if (i == Lower_index)
                            Lower_Ex[i].Visible = true;
                        else
                            Lower_Ex[i].Visible = false;

                    LowerLarrow.Enabled = true;
                    LowerLarrow.Image = (Image)resources1.GetObject("Larrow.Image");

                    if (Lower_index == Lower_Ex.Length - 1)
                    {
                        LowerRarrow.Enabled = false;
                        LowerRarrow.Image = (Image)resources1.GetObject("LowerRarrow.Image");
                    }
                }
            }

        }

        private void TakeTheExam(string Crs_Name)
        {
            ExamView_Panel.Visible = false;
            TakeExam_Panel.Visible = true;
            string[] Output;
            string Query = $@"Select Distinct E.ID
                            From Exam E join Course C 
                            on E.Crs_ID = C.ID join Exam_Question EQ
                            on E.ID = EQ.Exam_ID join Question Q
                            on Q.ID = EQ.Q_ID
                            Where C.Name = '{Crs_Name}'";

            SelectQ(Query, out Output);
            Exam_id = int.Parse(Output[0]);

            Query = $@"Select Q.ID ,Q.Content
                            From Exam E join Course C 
                            on E.Crs_ID = C.ID join Exam_Question EQ
                            on E.ID = EQ.Exam_ID join Question Q
                            on Q.ID = EQ.Q_ID
                            Where C.Name = '{Crs_Name}'And E.ID ={Exam_id}";

            SelectQ(Query, out Output);

            Q_IDs = new int[Output.Length / 2];
            Questions = new string[Output.Length / 2];
            User_Ans = new string[Output.Length / 2];

            int tr = 0;
            for (int i = 0; tr < Output.Length; i++)
            {
                Q_IDs[i] = int.Parse(Output[tr]);
                tr += 2;
            }

            tr = 1;
            for (int i = 0; tr < Output.Length; i++)
            {
                Questions[i] = Output[tr];
                tr += 2;
            }

            for (int i = 0; i < User_Ans.Length; i++)
                User_Ans[i] = "No Choice";

            Query = @"Select C.Choice
                    From Choices C 
                    Where C.Question_ID =";

            Chioces = new string[Questions.Length][];
            for (int i = 0; i < Questions.Length; i++)
            {
                SelectQ(Query + Convert.ToString(Q_IDs[i]), out Output);
                Chioces[i] = Output;
            }


            RadioButton[] Radio_Choice = new System.Windows.Forms.RadioButton[Chioces[0].Length];
            QChoices_Panel = new Panel[Questions.Length];

            int y = 0;
            for (int k = 0; k < QChoices_Panel.Length; k++)
            {
                QChoices_Panel[k] = new Panel();
                QChoices_Panel[k].Size = new Size(1000, Chioces[0].Length * 30);
                QChoices_Panel[k].Location = new Point(131, (Q_Label.Location.Y + Q_Label.Height + 30));
                TakeExam_Panel.Controls.Add(QChoices_Panel[k]);
                QChoices_Panel[k].Visible = false;
                y = 0;
                for (int i = 0; i < Chioces[k].Length; i++)
                {
                    Radio_Choice[i] = new RadioButton();
                    Radio_Choice[i].AutoSize = true;
                    Radio_Choice[i].Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    Radio_Choice[i].Location = new Point(0, y);
                    Radio_Choice[i].Name = $"Radio_Choice{k}{i}";
                    Radio_Choice[i].Size = new Size(157, 28);
                    Radio_Choice[i].Text = Chioces[k][i];
                    Radio_Choice[i].UseVisualStyleBackColor = true;
                    Radio_Choice[i].CheckedChanged += RadioButton_CheckedChanged;
                    QChoices_Panel[k].Controls.Add(Radio_Choice[i]);
                    y += 30;

                }

            }

            Q_Label.Text = $"Q{Q_index + 1}) {Questions[0]}";
            QChoices_Panel[Q_index].Visible = true;
            but_Previous.Location = new Point(Q_Label.Location.X + 20, (QChoices_Panel[0].Location.Y + QChoices_Panel[0].Height + 60));
            but_Next.Location = new Point((Q_Label.Location.X + Q_Label.Width - but_Next.Width), QChoices_Panel[0].Location.Y + QChoices_Panel[0].Height + 60);
            but_Previous.Visible = false;

            // Timer setup
            ExamTimer = new System.Timers.Timer();
            ExamTimer.Interval = 1000;
            ExamTimer.Elapsed += OnTimeEvent;
            ExamTimer.Start();
            Timer_Color = new int[] { 0, 255, 0 };
            Query = $@"Select Duration
                        From Exam
                        Where ID={Exam_id}";
            SelectQ(Query, out Output);
            ExamTotalTime = int.Parse(Output[0]);
            RemTime = ExamTotalTime * 60;
            ExamTotalTime = RemTime;


            // update Timer Label

            Timer_TB.Text = $"{(RemTime / 3600):D2}:{((RemTime % 3600) / 60):D2}:{(RemTime % 60):D2}";



        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {

            if (RemTime > 0)
            {
                RemTime--;

                Timer_TB.Invoke(new Action(() =>
                {
                    Timer_TB.Text = $"{(RemTime / 3600):D2}:{((RemTime % 3600) / 60):D2}:{(RemTime % 60):D2}";
                    Timer_TB.BackColor = (RemTime % 2 == 0)
                        ? Color.FromArgb(240, 240, 240)
                        : Color.FromArgb(Timer_Color[0], Timer_Color[1], Timer_Color[2]);
                }));

                if ((RemTime > (0.34 * ExamTotalTime)) && ((0.67 * ExamTotalTime) > RemTime))
                    Timer_Color = new int[] { 247, 247, 0 };
                if (RemTime < (0.34 * ExamTotalTime))
                    Timer_Color = new int[] { 255, 0, 0 };
            }
            else
            {

                string query = "Insert into Answers(St_ID,Exam_ID,Q_ID,Answer) Values";
                for (int i = 0; i < Questions.Length; i++)
                    if (i < Questions.Length - 1)
                        query += $"\n({Student[0]},{Exam_id},{Q_IDs[i]},'{User_Ans[i]}'),";
                    else
                        query += $"\n({Student[0]},{Exam_id},{Q_IDs[i]},'{User_Ans[i]}');";

                ModifyQ(query);

                ModifyQ($"ExamCorrection {Student[0]},{Exam_id},{Crs_ID}");

                Timer_TB.Invoke(new Action(() =>
                {
                    TakeExam_Panel.Visible = false;
                    ExamView_Panel.Visible = true;

                    this.Controls.Clear();  // Clear all controls
                    this.InitializeComponent();  // Reload the form’s components

                    but_Exams.PerformClick();
                    string[] temp;
                    SelectQ(@$"Select Count(T.Crs_ID) 
                        From Student S join Track_Courses T 
                        on S.Track_ID = T.Track_ID 
                        Group By S.ID Having ID ={Student[0]}", out temp);

                    Clab_ID.Text = Student[0];
                    Clab_crs.Text = temp[0];

                    SelectQ(@$"Select T.Name From Student S , Track T 
                     Where S.Track_ID = T.ID AND S.ID = {Student[0]}", out temp);
                    Clab_track.Text = temp[0];
                    Change_ID.Text = " " + Student[0];
                    Change_Name.Text = " " + Student[1];
                    Change_Email.Text = " " + Student[3];
                    Change_DOB.Text = " " + Student[4];
                    Change_Gender.Text = " " + Student[5];
                    Change_Type.Text = " " + Student[6];
                    Change_Address.Text = " " + Student[7];
                    Change_Speciality.Text = " " + Student[8];

                    but_Home.Enabled = true;
                    but_FB.Enabled = true;
                    but_instagram.Enabled = true;
                    but_Logout.Enabled = true;
                    but_Notification.Enabled = true;
                    but_Pinfo.Enabled = true;
                    but_setting.Enabled = true;
                    but_twitter.Enabled = true;
                    but_Exams.Enabled = true;
                    but_Close.Enabled = true;
                }));
                ExamTimer.Stop();


            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadio = sender as RadioButton;

            if (selectedRadio != null && selectedRadio.Checked)
            {
                if (selectedRadio.Text != "No Result")
                    User_Ans[Q_index] = selectedRadio.Text;
            }
        }

        private void but_Next_Click(object sender, EventArgs e)
        {
            if (but_Next.Text == "Submit")
            {


                if (new PopUp("Are You Sure You Want To Submit Exam Now ?").ConfirmMessage(""))
                {
                    ExamTimer.Stop();

                    TakeExam_Panel.Visible = false;

                    ExamView_Panel.Visible = true;

                    string query = "Insert into Answers(St_ID,Exam_ID,Q_ID,Answer) Values";
                    for (int i = 0; i < Questions.Length; i++)
                        if (i < Questions.Length - 1)
                            query += $"\n({Student[0]},{Exam_id},{Q_IDs[i]},'{User_Ans[i]}'),";
                        else
                            query += $"\n({Student[0]},{Exam_id},{Q_IDs[i]},'{User_Ans[i]}');";

                    ModifyQ(query);

                    ModifyQ($"ExamCorrection {Student[0]},{Exam_id},{Crs_ID}");

                    this.Controls.Clear();  // Clear all controls
                    this.InitializeComponent();  // Reload the form’s components


                    but_Exams.PerformClick();
                    string[] temp;
                    SelectQ(@$"Select Count(T.Crs_ID) 
                                From Student S join Track_Courses T 
                                on S.Track_ID = T.Track_ID 
                                Group By S.ID Having ID ={Student[0]}", out temp);

                    Clab_ID.Text = Student[0];
                    Clab_crs.Text = temp[0];

                    SelectQ(@$"Select T.Name From Student S , Track T 
                        Where S.Track_ID = T.ID AND S.ID = {Student[0]}", out temp);
                    Clab_track.Text = temp[0];
                    Change_ID.Text = " " + Student[0];
                    Change_Name.Text = " " + Student[1];
                    Change_Email.Text = " " + Student[3];
                    Change_DOB.Text = " " + Student[4];
                    Change_Gender.Text = " " + Student[5];
                    Change_Type.Text = " " + Student[6];
                    Change_Address.Text = " " + Student[7];
                    Change_Speciality.Text = " " + Student[8];

                    but_Home.Enabled = true;
                    but_FB.Enabled = true;
                    but_instagram.Enabled = true;
                    but_Logout.Enabled = true;
                    but_Notification.Enabled = true;
                    but_Pinfo.Enabled = true;
                    but_setting.Enabled = true;
                    but_twitter.Enabled = true;
                    but_Exams.Enabled = true;
                    but_Close.Enabled = true;
                }

            }
            if (Q_index < Questions.Length - 1)
            {
                but_Previous.Visible = true;

                QChoices_Panel[Q_index].Visible = false;
                Q_index++;
                QChoices_Panel[Q_index].Visible = true;
                Q_Label.Text = $"Q{Q_index + 1}) {Questions[Q_index]}";

                using (Graphics g = Q_Label.CreateGraphics())
                {
                    SizeF textSize = g.MeasureString(Q_Label.Text, Q_Label.Font);
                    Q_Label.Height = (int)Math.Ceiling(textSize.Height);
                }

                QChoices_Panel[Q_index].Location = new Point(131, (Q_Label.Location.Y + Q_Label.Height + 30));


                if (Q_index == Questions.Length - 1)
                    but_Next.Text = "Submit";

                // Interactively Change buttons Location
                but_Previous.Location = new Point(Q_Label.Location.X + 20, (QChoices_Panel[Q_index].Location.Y + QChoices_Panel[Q_index].Height + 60));
                but_Next.Location = new Point((Q_Label.Location.X + Q_Label.Width - but_Next.Width), QChoices_Panel[Q_index].Location.Y + QChoices_Panel[Q_index].Height + 60);

            }

        }

        private void but_Previous_Click(object sender, EventArgs e)
        {
            if (Q_index > 0)
            {
                if (Q_index == Questions.Length - 1)
                    but_Next.Text = "Next";

                QChoices_Panel[Q_index].Visible = false;
                Q_index--;
                QChoices_Panel[Q_index].Visible = true;

                Q_Label.Text = $"Q{Q_index + 1}) {Questions[Q_index]}";


                if (Q_index == 0)
                    but_Previous.Visible = false;

                // Interactively Change buttons Location
                but_Previous.Location = new Point(Q_Label.Location.X + 20, (QChoices_Panel[Q_index].Location.Y + QChoices_Panel[Q_index].Height + 60));
                but_Next.Location = new Point((Q_Label.Location.X + Q_Label.Width - but_Next.Width), QChoices_Panel[Q_index].Location.Y + QChoices_Panel[Q_index].Height + 60);

            }
        }

        private void Pinfo_Save_Click(object sender, EventArgs e)
        {
            // vaildation DOB

            if (Student[4] != Change_DOB.Text)
            {
                Student[4] = Change_DOB.Text.Trim();

                string temp = Student[4];
                int count = 0;

                for (int i = 0; i < temp.Length; i++)
                    if (temp[i] == '/')
                        count++;

                if (count != 2)
                {
                    PopUp.ErrorMessage("Wrong DOB Update \nPlease Enter The DOB in This Formate 'DD/MM/YYY'");

                    return;
                }
                else
                {
                    string[] Num = temp.Split('/');
                    for (int i = 0; i < Num.Length; i++)
                        if (!int.TryParse(Num[i], out int number))
                        {
                            PopUp.ErrorMessage("Wrong DOB Update \nDOB Only Accepts Numbers With Special Charater");

                            return;
                        }

                }

            }

            Student[1] = Change_Name.Text.Trim();
            Student[7] = Change_Address.Text.Trim();
            Student[8] = Change_Speciality.Text.Trim();

            string result = string.Empty;
            string Query1 = $@"Update Users
                            Set Name = '{Student[1]}',DOB ='{Student[4]}',Address='{Student[7]}'
                            Where ID = {Student[0]}";

            string Query2 = $@"Update Student
                        Set Specialist ='{Student[8]}'
                        Where ID = {Student[0]}";

            result = $"{ModifyQ(Query1)} {ModifyQ(Query2)}";

            if (result.Contains("Error"))
            {
                PopUp.ErrorMessage($"Wrong Update \n{result}");

                return;
            }
            else
                new PopUp("Information Has Been Updated Successfully").DoneMessage("");

            Pinfo_Save.Visible = false;
        }

        private void PinfoTB_Selected(object sender, EventArgs e)
        {
            Pinfo_Save.Visible = true;
        }
    }
}
