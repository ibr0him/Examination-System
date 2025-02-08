using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Examination_System
{
    partial class InstructorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            SidePanel = new Panel();
            button1 = new Button();
            but_Logout = new Button();
            Highlighter = new Panel();
            but_GenExams = new Button();
            but_Pinfo = new Button();
            but_Home = new Button();
            Report_panel = new Panel();
            labelReports = new Label();
            but_Report = new Button();
            gen_exam_panel = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            CourseID = new DataGridViewTextBoxColumn();
            CourseName = new DataGridViewTextBoxColumn();
            StudentNumber = new DataGridViewTextBoxColumn();
            gen = new DataGridViewButtonColumn();
            viewExamsButton = new DataGridViewButtonColumn();
            Course = new DataGridViewTextBoxColumn();
            Student_Number = new DataGridViewTextBoxColumn();
            RedBar = new Panel();
            but_Close = new Button();
            but_instagram = new Button();
            but_twitter = new Button();
            but_FB = new Button();
            but_setting = new Button();
            but_Notification = new Button();
            RedFlag = new Panel();
            Project_icon = new PictureBox();
            Project_Subheader = new Label();
            Project_header = new Label();
            HomePanel = new Panel();
            Clab_ID = new Label();
            Clab_track = new Label();
            Clab_crs = new Label();
            lab_ID = new Label();
            lab_crs = new Label();
            lab_track = new Label();
            HomePanel_img = new PictureBox();
            Personal_info_Panel = new Panel();
            Pinfo_Save = new Button();
            Personal_Details = new Label();
            Salary_Title = new Label();
            Change_Salary = new TextBox();
            Address_Title = new Label();
            Change_Address = new TextBox();
            Type_Title = new Label();
            Change_Type = new TextBox();
            Gender_Title = new Label();
            Change_Gender = new TextBox();
            DOB_Title = new Label();
            Change_DOB = new TextBox();
            Email_Title = new Label();
            Change_Email = new TextBox();
            Name_Title = new Label();
            Change_Name = new TextBox();
            ID_Title = new Label();
            pictureBox1 = new PictureBox();
            Change_ID = new TextBox();
            view_exams_panel = new Panel();
            panel1 = new Panel();
            reportPanel = new Panel();
            titleLabel = new Label();
            viewReportButton = new Button();
            SidePanel.SuspendLayout();
            Report_panel.SuspendLayout();
            gen_exam_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            RedFlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Project_icon).BeginInit();
            HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomePanel_img).BeginInit();
            Personal_info_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(41, 39, 40);
            SidePanel.Controls.Add(button1);
            SidePanel.Controls.Add(but_Logout);
            SidePanel.Controls.Add(Highlighter);
            SidePanel.Controls.Add(but_GenExams);
            SidePanel.Controls.Add(but_Pinfo);
            SidePanel.Controls.Add(but_Home);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            SidePanel.Margin = new Padding(6, 5, 6, 5);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(358, 1334);
=======
            SidePanel.Margin = new Padding(4, 3, 4, 3);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(250, 800);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            SidePanel.TabIndex = 0;
            SidePanel.MouseDown += Panel_MouseDown;
            SidePanel.MouseMove += Panel_MouseMove;
            SidePanel.MouseUp += Panel_MouseUp;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            button1.Location = new Point(28, 543);
            button1.Margin = new Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new Size(304, 91);
            button1.TabIndex = 2;
=======
            button1.Location = new Point(19, 330);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(213, 55);
            button1.TabIndex = 14;
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            button1.Text = " Reports";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += but_Reports_Click;
            // 
            // but_Logout
            // 
            but_Logout.FlatAppearance.BorderSize = 0;
            but_Logout.FlatStyle = FlatStyle.Flat;
            but_Logout.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Logout.ForeColor = Color.White;
            but_Logout.Image = (Image)resources.GetObject("but_Logout.Image");
            but_Logout.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_Logout.Location = new Point(28, 1181);
            but_Logout.Margin = new Padding(6, 5, 6, 5);
            but_Logout.Name = "but_Logout";
            but_Logout.Size = new Size(271, 91);
=======
            but_Logout.Location = new Point(19, 709);
            but_Logout.Margin = new Padding(4, 3, 4, 3);
            but_Logout.Name = "but_Logout";
            but_Logout.Size = new Size(190, 55);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_Logout.TabIndex = 13;
            but_Logout.Text = "  Log out";
            but_Logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Logout.UseVisualStyleBackColor = true;
            but_Logout.Click += but_Logout_Click;
            // 
            // Highlighter
            // 
            Highlighter.BackColor = Color.FromArgb(178, 8, 55);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Highlighter.Location = new Point(6, 61);
            Highlighter.Margin = new Padding(6, 5, 6, 5);
            Highlighter.Name = "Highlighter";
            Highlighter.Size = new Size(20, 116);
=======
            Highlighter.Location = new Point(4, 37);
            Highlighter.Margin = new Padding(4, 3, 4, 3);
            Highlighter.Name = "Highlighter";
            Highlighter.Size = new Size(14, 70);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Highlighter.TabIndex = 12;
            // 
            // but_GenExams
            // 
            but_GenExams.FlatAppearance.BorderSize = 0;
            but_GenExams.FlatStyle = FlatStyle.Flat;
            but_GenExams.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_GenExams.ForeColor = Color.White;
            but_GenExams.Image = (Image)resources.GetObject("but_GenExams.Image");
            but_GenExams.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_GenExams.Location = new Point(28, 395);
            but_GenExams.Margin = new Padding(6, 5, 6, 5);
            but_GenExams.Name = "but_GenExams";
            but_GenExams.Size = new Size(338, 99);
=======
            but_GenExams.Location = new Point(19, 237);
            but_GenExams.Margin = new Padding(4, 3, 4, 3);
            but_GenExams.Name = "but_GenExams";
            but_GenExams.Size = new Size(236, 59);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_GenExams.TabIndex = 2;
            but_GenExams.Text = " Generate Exams";
            but_GenExams.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_GenExams.UseVisualStyleBackColor = true;
            but_GenExams.Click += but_Exams_Click;
            // 
            // but_Pinfo
            // 
            but_Pinfo.FlatAppearance.BorderSize = 0;
            but_Pinfo.FlatStyle = FlatStyle.Flat;
            but_Pinfo.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Pinfo.ForeColor = Color.White;
            but_Pinfo.Image = (Image)resources.GetObject("but_Pinfo.Image");
            but_Pinfo.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_Pinfo.Location = new Point(28, 231);
            but_Pinfo.Margin = new Padding(6, 5, 6, 5);
            but_Pinfo.Name = "but_Pinfo";
            but_Pinfo.Size = new Size(304, 91);
=======
            but_Pinfo.Location = new Point(19, 139);
            but_Pinfo.Margin = new Padding(4, 3, 4, 3);
            but_Pinfo.Name = "but_Pinfo";
            but_Pinfo.Size = new Size(213, 55);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_Pinfo.TabIndex = 2;
            but_Pinfo.Text = " Personal Info";
            but_Pinfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Pinfo.UseVisualStyleBackColor = true;
            but_Pinfo.Click += but_Pinfo_Click;
            // 
            // but_Home
            // 
            but_Home.FlatAppearance.BorderSize = 0;
            but_Home.FlatStyle = FlatStyle.Flat;
            but_Home.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Home.ForeColor = Color.White;
            but_Home.Image = (Image)resources.GetObject("but_Home.Image");
            but_Home.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_Home.Location = new Point(28, 74);
            but_Home.Margin = new Padding(6, 5, 6, 5);
            but_Home.Name = "but_Home";
            but_Home.Size = new Size(271, 86);
=======
            but_Home.Location = new Point(19, 44);
            but_Home.Margin = new Padding(4, 3, 4, 3);
            but_Home.Name = "but_Home";
            but_Home.Size = new Size(190, 52);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_Home.TabIndex = 2;
            but_Home.Text = " Home";
            but_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Home.UseVisualStyleBackColor = true;
            but_Home.Click += but_Home_Click;
            // 
            // Report_panel
            // 
            Report_panel.Controls.Add(labelReports);
            Report_panel.Location = new Point(379, 92);
            Report_panel.Margin = new Padding(4, 5, 4, 5);
            Report_panel.Name = "Report_panel";
            Report_panel.Size = new Size(1650, 1180);
            Report_panel.TabIndex = 18;
            // 
            // labelReports
            // 
            labelReports.AutoSize = true;
            labelReports.Font = new Font("Century Gothic", 28F, FontStyle.Bold);
            labelReports.Location = new Point(622, 58);
            labelReports.Margin = new Padding(4, 0, 4, 0);
            labelReports.Name = "labelReports";
            labelReports.Size = new Size(229, 66);
            labelReports.TabIndex = 1;
            labelReports.Text = "Reports";
            // 
            // but_Report
            // 
            but_Report.Location = new Point(0, 0);
            but_Report.Name = "but_Report";
            but_Report.Size = new Size(75, 23);
            but_Report.TabIndex = 0;
            // 
            // gen_exam_panel
            // 
            gen_exam_panel.Controls.Add(label1);
            gen_exam_panel.Controls.Add(dataGridView1);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            gen_exam_panel.Location = new Point(361, 134);
            gen_exam_panel.Margin = new Padding(4, 5, 4, 5);
            gen_exam_panel.Name = "gen_exam_panel";
            gen_exam_panel.Size = new Size(1702, 1179);
=======
            gen_exam_panel.Location = new Point(253, 80);
            gen_exam_panel.Name = "gen_exam_panel";
            gen_exam_panel.Size = new Size(1192, 707);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            gen_exam_panel.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            label1.Location = new Point(622, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(391, 58);
=======
            label1.Location = new Point(436, 34);
            label1.Name = "label1";
            label1.Size = new Size(263, 39);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            label1.TabIndex = 0;
            label1.Text = "Generate Exam";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.Menu;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 16F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CourseID, CourseName, StudentNumber, gen, viewExamsButton });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.ImeMode = ImeMode.On;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            dataGridView1.Location = new Point(66, 216);
            dataGridView1.Margin = new Padding(4);
=======
            dataGridView1.Location = new Point(46, 130);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            dataGridView1.Size = new Size(1601, 838);
=======
            dataGridView1.Size = new Size(1121, 502);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CourseID
            // 
            CourseID.FillWeight = 20F;
            CourseID.HeaderText = "Course ID";
            CourseID.MinimumWidth = 6;
            CourseID.Name = "CourseID";
            CourseID.ReadOnly = true;
            CourseID.Width = 300;
            // 
            // CourseName
            // 
            CourseName.FillWeight = 50F;
            CourseName.HeaderText = "Course Name";
            CourseName.MinimumWidth = 6;
            CourseName.Name = "CourseName";
            CourseName.ReadOnly = true;
            CourseName.Width = 300;
            // 
            // StudentNumber
            // 
            StudentNumber.FillWeight = 30F;
            StudentNumber.HeaderText = "Student Number";
            StudentNumber.MinimumWidth = 6;
            StudentNumber.Name = "StudentNumber";
            StudentNumber.ReadOnly = true;
            StudentNumber.Width = 300;
            // 
            // gen
            // 
            gen.FillWeight = 40F;
            gen.HeaderText = "";
            gen.MinimumWidth = 6;
            gen.Name = "gen";
            gen.ReadOnly = true;
            gen.Text = "Generate Exam";
            gen.UseColumnTextForButtonValue = true;
            gen.Width = 150;
            // 
            // viewExamsButton
            // 
            viewExamsButton.HeaderText = "";
            viewExamsButton.MinimumWidth = 6;
            viewExamsButton.Name = "viewExamsButton";
            viewExamsButton.ReadOnly = true;
            viewExamsButton.Text = "View Exams";
            viewExamsButton.UseColumnTextForButtonValue = true;
            viewExamsButton.Width = 150;
            // 
            // Course
            // 
            Course.MinimumWidth = 6;
            Course.Name = "Course";
            Course.Width = 125;
            // 
            // Student_Number
            // 
            Student_Number.MinimumWidth = 6;
            Student_Number.Name = "Student_Number";
            Student_Number.Width = 125;
            // 
            // RedBar
            // 
            RedBar.BackColor = Color.FromArgb(178, 8, 55);
            RedBar.Dock = DockStyle.Top;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            RedBar.Location = new Point(358, 0);
            RedBar.Margin = new Padding(6, 5, 6, 5);
            RedBar.Name = "RedBar";
            RedBar.Size = new Size(1706, 40);
=======
            RedBar.Location = new Point(250, 0);
            RedBar.Margin = new Padding(4, 3, 4, 3);
            RedBar.Name = "RedBar";
            RedBar.Size = new Size(1195, 24);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            RedBar.TabIndex = 1;
            RedBar.MouseDown += Panel_MouseDown;
            RedBar.MouseMove += Panel_MouseMove;
            RedBar.MouseUp += Panel_MouseUp;
            // 
            // but_Close
            // 
            but_Close.FlatAppearance.BorderSize = 0;
            but_Close.FlatStyle = FlatStyle.Flat;
            but_Close.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Close.ForeColor = Color.White;
            but_Close.Image = (Image)resources.GetObject("but_Close.Image");
            but_Close.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_Close.Location = new Point(1994, 49);
            but_Close.Margin = new Padding(6, 5, 6, 5);
            but_Close.Name = "but_Close";
            but_Close.Size = new Size(60, 75);
=======
            but_Close.Location = new Point(1396, 29);
            but_Close.Margin = new Padding(4, 3, 4, 3);
            but_Close.Name = "but_Close";
            but_Close.Size = new Size(42, 45);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_Close.TabIndex = 5;
            but_Close.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Close.UseVisualStyleBackColor = true;
            but_Close.Click += but_Close_Click;
            // 
            // but_instagram
            // 
            but_instagram.FlatAppearance.BorderSize = 0;
            but_instagram.FlatStyle = FlatStyle.Flat;
            but_instagram.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_instagram.ForeColor = Color.White;
            but_instagram.Image = (Image)resources.GetObject("but_instagram.Image");
            but_instagram.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_instagram.Location = new Point(1539, 54);
            but_instagram.Margin = new Padding(6, 5, 6, 5);
            but_instagram.Name = "but_instagram";
            but_instagram.Size = new Size(50, 65);
=======
            but_instagram.Location = new Point(1077, 32);
            but_instagram.Margin = new Padding(4, 3, 4, 3);
            but_instagram.Name = "but_instagram";
            but_instagram.Size = new Size(35, 39);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_instagram.TabIndex = 6;
            but_instagram.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_instagram.UseVisualStyleBackColor = true;
            but_instagram.Click += but_instagram_Click;
            // 
            // but_twitter
            // 
            but_twitter.FlatAppearance.BorderSize = 0;
            but_twitter.FlatStyle = FlatStyle.Flat;
            but_twitter.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_twitter.ForeColor = Color.White;
            but_twitter.Image = (Image)resources.GetObject("but_twitter.Image");
            but_twitter.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_twitter.Location = new Point(1469, 54);
            but_twitter.Margin = new Padding(6, 5, 6, 5);
            but_twitter.Name = "but_twitter";
            but_twitter.Size = new Size(50, 65);
=======
            but_twitter.Location = new Point(1028, 32);
            but_twitter.Margin = new Padding(4, 3, 4, 3);
            but_twitter.Name = "but_twitter";
            but_twitter.Size = new Size(35, 39);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_twitter.TabIndex = 7;
            but_twitter.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_twitter.UseVisualStyleBackColor = true;
            but_twitter.Click += but_twitter_Click;
            // 
            // but_FB
            // 
            but_FB.FlatAppearance.BorderSize = 0;
            but_FB.FlatStyle = FlatStyle.Flat;
            but_FB.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_FB.ForeColor = Color.White;
            but_FB.Image = (Image)resources.GetObject("but_FB.Image");
            but_FB.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_FB.Location = new Point(1399, 54);
            but_FB.Margin = new Padding(6, 5, 6, 5);
            but_FB.Name = "but_FB";
            but_FB.Size = new Size(50, 65);
=======
            but_FB.Location = new Point(979, 32);
            but_FB.Margin = new Padding(4, 3, 4, 3);
            but_FB.Name = "but_FB";
            but_FB.Size = new Size(35, 39);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_FB.TabIndex = 8;
            but_FB.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_FB.UseVisualStyleBackColor = true;
            but_FB.Click += but_FB_Click;
            // 
            // but_setting
            // 
            but_setting.FlatAppearance.BorderSize = 0;
            but_setting.FlatStyle = FlatStyle.Flat;
            but_setting.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_setting.ForeColor = Color.White;
            but_setting.Image = (Image)resources.GetObject("but_setting.Image");
            but_setting.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_setting.Location = new Point(1931, 51);
            but_setting.Margin = new Padding(6, 5, 6, 5);
            but_setting.Name = "but_setting";
            but_setting.Size = new Size(52, 66);
=======
            but_setting.Location = new Point(1352, 31);
            but_setting.Margin = new Padding(4, 3, 4, 3);
            but_setting.Name = "but_setting";
            but_setting.Size = new Size(37, 40);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_setting.TabIndex = 9;
            but_setting.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_setting.UseVisualStyleBackColor = true;
            but_setting.Click += but_setting_Click;
            // 
            // but_Notification
            // 
            but_Notification.FlatAppearance.BorderSize = 0;
            but_Notification.FlatStyle = FlatStyle.Flat;
            but_Notification.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Notification.ForeColor = Color.White;
            but_Notification.Image = (Image)resources.GetObject("but_Notification.Image");
            but_Notification.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            but_Notification.Location = new Point(1869, 51);
            but_Notification.Margin = new Padding(6, 5, 6, 5);
            but_Notification.Name = "but_Notification";
            but_Notification.Size = new Size(52, 66);
=======
            but_Notification.Location = new Point(1308, 31);
            but_Notification.Margin = new Padding(4, 3, 4, 3);
            but_Notification.Name = "but_Notification";
            but_Notification.Size = new Size(37, 40);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            but_Notification.TabIndex = 10;
            but_Notification.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Notification.UseVisualStyleBackColor = true;
            but_Notification.Click += but_Notification_Click;
            // 
            // RedFlag
            // 
            RedFlag.BackColor = Color.FromArgb(178, 8, 55);
            RedFlag.Controls.Add(Project_icon);
            RedFlag.Controls.Add(Project_Subheader);
            RedFlag.Controls.Add(Project_header);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            RedFlag.Location = new Point(502, 1);
            RedFlag.Margin = new Padding(6, 5, 6, 5);
            RedFlag.Name = "RedFlag";
            RedFlag.Size = new Size(186, 275);
=======
            RedFlag.Controls.Add(Project_icon);
            RedFlag.Location = new Point(352, 1);
            RedFlag.Margin = new Padding(4, 3, 4, 3);
            RedFlag.Name = "RedFlag";
            RedFlag.Size = new Size(130, 165);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            RedFlag.TabIndex = 11;
            // 
            // Project_icon
            // 
            Project_icon.Image = (Image)resources.GetObject("Project_icon.Image");
            Project_icon.Location = new Point(11, 19);
            Project_icon.Margin = new Padding(6, 5, 6, 5);
            Project_icon.Name = "Project_icon";
            Project_icon.Size = new Size(151, 170);
            Project_icon.SizeMode = PictureBoxSizeMode.Zoom;
            Project_icon.TabIndex = 4;
            Project_icon.TabStop = false;
            // 
            // Project_Subheader
            // 
            Project_Subheader.AutoSize = true;
            Project_Subheader.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Project_Subheader.ForeColor = Color.White;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Project_Subheader.Location = new Point(59, 226);
            Project_Subheader.Margin = new Padding(6, 0, 6, 0);
            Project_Subheader.Name = "Project_Subheader";
            Project_Subheader.Size = new Size(73, 21);
=======
            Project_Subheader.Location = new Point(41, 136);
            Project_Subheader.Margin = new Padding(4, 0, 4, 0);
            Project_Subheader.Name = "Project_Subheader";
            Project_Subheader.Size = new Size(50, 17);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Project_Subheader.TabIndex = 3;
            Project_Subheader.Text = "System";
            // 
            // Project_header
            // 
            Project_header.AutoSize = true;
            Project_header.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Project_header.ForeColor = Color.White;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Project_header.Location = new Point(20, 194);
            Project_header.Margin = new Padding(6, 0, 6, 0);
            Project_header.Name = "Project_header";
            Project_header.Size = new Size(154, 28);
            Project_header.TabIndex = 3;
            Project_header.Text = "Examination";
            // 
=======
            Project_header.Location = new Point(14, 116);
            Project_header.Margin = new Padding(4, 0, 4, 0);
            Project_header.Name = "Project_header";
            Project_header.Size = new Size(106, 19);
            Project_header.TabIndex = 3;
            Project_header.Text = "Examination";
            // 
            // Project_icon
            // 
            Project_icon.Image = (Image)resources.GetObject("Project_icon.Image");
            Project_icon.Location = new Point(8, 11);
            Project_icon.Margin = new Padding(4, 3, 4, 3);
            Project_icon.Name = "Project_icon";
            Project_icon.Size = new Size(106, 102);
            Project_icon.SizeMode = PictureBoxSizeMode.Zoom;
            Project_icon.TabIndex = 4;
            Project_icon.TabStop = false;
            // 
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            // HomePanel
            // 
            HomePanel.Controls.Add(Clab_ID);
            HomePanel.Controls.Add(Clab_track);
            HomePanel.Controls.Add(Clab_crs);
            HomePanel.Controls.Add(lab_ID);
            HomePanel.Controls.Add(lab_crs);
            HomePanel.Controls.Add(lab_track);
            HomePanel.Controls.Add(HomePanel_img);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            HomePanel.Location = new Point(362, 166);
            HomePanel.Margin = new Padding(6, 5, 6, 5);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1629, 1146);
=======
            HomePanel.Location = new Point(254, 100);
            HomePanel.Margin = new Padding(4, 3, 4, 3);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1140, 688);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            HomePanel.TabIndex = 12;
            // 
            // Clab_ID
            // 
            Clab_ID.AutoSize = true;
            Clab_ID.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Clab_ID.Location = new Point(232, 1026);
            Clab_ID.Margin = new Padding(6, 0, 6, 0);
            Clab_ID.Name = "Clab_ID";
            Clab_ID.Size = new Size(45, 50);
=======
            Clab_ID.Location = new Point(163, 616);
            Clab_ID.Margin = new Padding(4, 0, 4, 0);
            Clab_ID.Name = "Clab_ID";
            Clab_ID.Size = new Size(30, 33);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Clab_ID.TabIndex = 21;
            Clab_ID.Text = "0";
            // 
            // Clab_track
            // 
            Clab_track.AutoSize = true;
            Clab_track.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Clab_track.Location = new Point(769, 1026);
            Clab_track.Margin = new Padding(6, 0, 6, 0);
            Clab_track.Name = "Clab_track";
            Clab_track.Size = new Size(45, 50);
=======
            Clab_track.Location = new Point(538, 616);
            Clab_track.Margin = new Padding(4, 0, 4, 0);
            Clab_track.Name = "Clab_track";
            Clab_track.Size = new Size(30, 33);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Clab_track.TabIndex = 22;
            Clab_track.Text = "0";
            // 
            // Clab_crs
            // 
            Clab_crs.AutoSize = true;
            Clab_crs.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Clab_crs.Location = new Point(1520, 1029);
            Clab_crs.Margin = new Padding(6, 0, 6, 0);
            Clab_crs.Name = "Clab_crs";
            Clab_crs.Size = new Size(45, 50);
=======
            Clab_crs.Location = new Point(1064, 617);
            Clab_crs.Margin = new Padding(4, 0, 4, 0);
            Clab_crs.Name = "Clab_crs";
            Clab_crs.Size = new Size(30, 33);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Clab_crs.TabIndex = 23;
            Clab_crs.Text = "0";
            // 
            // lab_ID
            // 
            lab_ID.AutoSize = true;
            lab_ID.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            lab_ID.Location = new Point(156, 1025);
            lab_ID.Margin = new Padding(6, 0, 6, 0);
            lab_ID.Name = "lab_ID";
            lab_ID.Size = new Size(86, 50);
=======
            lab_ID.Location = new Point(109, 615);
            lab_ID.Margin = new Padding(4, 0, 4, 0);
            lab_ID.Name = "lab_ID";
            lab_ID.Size = new Size(55, 33);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            lab_ID.TabIndex = 24;
            lab_ID.Text = "ID :";
            // 
            // lab_crs
            // 
            lab_crs.AutoSize = true;
            lab_crs.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            lab_crs.Location = new Point(920, 1026);
            lab_crs.Margin = new Padding(6, 0, 6, 0);
            lab_crs.Name = "lab_crs";
            lab_crs.Size = new Size(645, 50);
=======
            lab_crs.Location = new Point(644, 616);
            lab_crs.Margin = new Padding(4, 0, 4, 0);
            lab_crs.Name = "lab_crs";
            lab_crs.Size = new Size(420, 33);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            lab_crs.TabIndex = 25;
            lab_crs.Text = "Number Of  Teached Cources :";
            // 
            // lab_track
            // 
            lab_track.AutoSize = true;
            lab_track.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab_track.ImageAlign = ContentAlignment.MiddleLeft;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            lab_track.Location = new Point(406, 1026);
            lab_track.Margin = new Padding(6, 0, 6, 0);
            lab_track.Name = "lab_track";
            lab_track.Size = new Size(399, 50);
=======
            lab_track.Location = new Point(284, 616);
            lab_track.Margin = new Padding(4, 0, 4, 0);
            lab_track.Name = "lab_track";
            lab_track.Size = new Size(258, 33);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            lab_track.TabIndex = 26;
            lab_track.Text = "Teaches For Track :";
            // 
            // HomePanel_img
            // 
            HomePanel_img.Image = (Image)resources.GetObject("HomePanel_img.Image");
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            HomePanel_img.Location = new Point(281, 5);
            HomePanel_img.Margin = new Padding(6, 5, 6, 5);
            HomePanel_img.Name = "HomePanel_img";
            HomePanel_img.Size = new Size(1249, 914);
=======
            HomePanel_img.Location = new Point(197, 3);
            HomePanel_img.Margin = new Padding(4, 3, 4, 3);
            HomePanel_img.Name = "HomePanel_img";
            HomePanel_img.Size = new Size(874, 548);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            HomePanel_img.SizeMode = PictureBoxSizeMode.Zoom;
            HomePanel_img.TabIndex = 27;
            HomePanel_img.TabStop = false;
            // 
            // Personal_info_Panel
            // 
            Personal_info_Panel.Controls.Add(Pinfo_Save);
            Personal_info_Panel.Controls.Add(Personal_Details);
            Personal_info_Panel.Controls.Add(Salary_Title);
            Personal_info_Panel.Controls.Add(Change_Salary);
            Personal_info_Panel.Controls.Add(Address_Title);
            Personal_info_Panel.Controls.Add(Change_Address);
            Personal_info_Panel.Controls.Add(Type_Title);
            Personal_info_Panel.Controls.Add(Change_Type);
            Personal_info_Panel.Controls.Add(Gender_Title);
            Personal_info_Panel.Controls.Add(Change_Gender);
            Personal_info_Panel.Controls.Add(DOB_Title);
            Personal_info_Panel.Controls.Add(Change_DOB);
            Personal_info_Panel.Controls.Add(Email_Title);
            Personal_info_Panel.Controls.Add(Change_Email);
            Personal_info_Panel.Controls.Add(Name_Title);
            Personal_info_Panel.Controls.Add(Change_Name);
            Personal_info_Panel.Controls.Add(ID_Title);
            Personal_info_Panel.Controls.Add(pictureBox1);
            Personal_info_Panel.Controls.Add(Change_ID);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Personal_info_Panel.Location = new Point(358, 134);
            Personal_info_Panel.Margin = new Padding(4, 5, 4, 5);
            Personal_info_Panel.Name = "Personal_info_Panel";
            Personal_info_Panel.Size = new Size(1650, 1180);
=======
            Personal_info_Panel.Location = new Point(250, 80);
            Personal_info_Panel.Name = "Personal_info_Panel";
            Personal_info_Panel.Size = new Size(1155, 708);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Personal_info_Panel.TabIndex = 13;
            // 
            // Pinfo_Save
            // 
            Pinfo_Save.BackColor = Color.FromArgb(178, 8, 55);
            Pinfo_Save.FlatStyle = FlatStyle.Flat;
            Pinfo_Save.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Pinfo_Save.ForeColor = Color.White;
            Pinfo_Save.Location = new Point(1014, 638);
            Pinfo_Save.Name = "Pinfo_Save";
            Pinfo_Save.Size = new Size(127, 46);
            Pinfo_Save.TabIndex = 19;
            Pinfo_Save.Text = "Save";
            Pinfo_Save.UseVisualStyleBackColor = false;
            Pinfo_Save.Click += Pinfo_Save_Click;
            // 
            // Personal_Details
            // 
            Personal_Details.AutoSize = true;
            Personal_Details.Font = new Font("Century Gothic", 24F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Personal_Details.Location = new Point(611, 520);
            Personal_Details.Margin = new Padding(4, 0, 4, 0);
            Personal_Details.Name = "Personal_Details";
            Personal_Details.Size = new Size(591, 58);
=======
            Personal_Details.Location = new Point(428, 312);
            Personal_Details.Name = "Personal_Details";
            Personal_Details.Size = new Size(396, 39);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Personal_Details.TabIndex = 0;
            Personal_Details.Text = "Teacher Personal Details";
            // 
            // Salary_Title
            // 
            Salary_Title.AutoSize = true;
            Salary_Title.Font = new Font("Century Gothic", 19F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Salary_Title.Location = new Point(649, 1019);
            Salary_Title.Margin = new Padding(4, 0, 4, 0);
            Salary_Title.Name = "Salary_Title";
            Salary_Title.Size = new Size(132, 45);
=======
            Salary_Title.Location = new Point(454, 611);
            Salary_Title.Name = "Salary_Title";
            Salary_Title.Size = new Size(92, 32);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Salary_Title.TabIndex = 17;
            Salary_Title.Text = "Salary";
            // 
            // Change_Salary
            // 
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Change_Speciality.BackColor = SystemColors.Control;
            Change_Speciality.Enabled = false;
            Change_Speciality.Font = new Font("Century Gothic", 14F);
            Change_Speciality.ForeColor = SystemColors.Desktop;
            Change_Speciality.Location = new Point(651, 1081);
            Change_Speciality.Margin = new Padding(4, 5, 4, 5);
            Change_Speciality.Name = "Change_Speciality";
            Change_Speciality.Size = new Size(388, 42);
            Change_Speciality.TabIndex = 16;
=======
            Change_Salary.BackColor = SystemColors.Control;
            Change_Salary.Enabled = false;
            Change_Salary.Font = new Font("Century Gothic", 14F);
            Change_Salary.ForeColor = SystemColors.Desktop;
            Change_Salary.Location = new Point(456, 649);
            Change_Salary.Name = "Change_Salary";
            Change_Salary.Size = new Size(273, 30);
            Change_Salary.TabIndex = 16;
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            // 
            // Address_Title
            // 
            Address_Title.AutoSize = true;
            Address_Title.Font = new Font("Century Gothic", 19F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Address_Title.Location = new Point(62, 1019);
            Address_Title.Margin = new Padding(4, 0, 4, 0);
            Address_Title.Name = "Address_Title";
            Address_Title.Size = new Size(165, 45);
=======
            Address_Title.Location = new Point(44, 611);
            Address_Title.Name = "Address_Title";
            Address_Title.Size = new Size(114, 32);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Address_Title.TabIndex = 15;
            Address_Title.Text = "Address";
            // 
            // Change_Address
            // 
            Change_Address.BackColor = SystemColors.Control;
            Change_Address.Font = new Font("Century Gothic", 14F);
            Change_Address.ForeColor = SystemColors.Desktop;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Change_Address.Location = new Point(68, 1081);
            Change_Address.Margin = new Padding(4, 5, 4, 5);
            Change_Address.Name = "Change_Address";
            Change_Address.Size = new Size(388, 42);
=======
            Change_Address.Location = new Point(47, 649);
            Change_Address.Name = "Change_Address";
            Change_Address.Size = new Size(273, 30);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Change_Address.TabIndex = 14;
            Change_Address.Enter += PinfoTB_Selected;
            // 
            // Type_Title
            // 
            Type_Title.AutoSize = true;
            Type_Title.Font = new Font("Century Gothic", 19F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Type_Title.Location = new Point(1231, 839);
            Type_Title.Margin = new Padding(4, 0, 4, 0);
            Type_Title.Name = "Type_Title";
            Type_Title.Size = new Size(281, 45);
=======
            Type_Title.Location = new Point(862, 503);
            Type_Title.Name = "Type_Title";
            Type_Title.Size = new Size(192, 32);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Type_Title.TabIndex = 13;
            Type_Title.Text = "Account Type";
            // 
            // Change_Type
            // 
            Change_Type.BackColor = SystemColors.Control;
            Change_Type.Enabled = false;
            Change_Type.Font = new Font("Century Gothic", 14F);
            Change_Type.ForeColor = SystemColors.Desktop;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Change_Type.Location = new Point(1239, 901);
            Change_Type.Margin = new Padding(4, 5, 4, 5);
            Change_Type.Name = "Change_Type";
            Change_Type.Size = new Size(388, 42);
=======
            Change_Type.Location = new Point(867, 541);
            Change_Type.Name = "Change_Type";
            Change_Type.Size = new Size(273, 30);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Change_Type.TabIndex = 12;
            // 
            // Gender_Title
            // 
            Gender_Title.AutoSize = true;
            Gender_Title.Font = new Font("Century Gothic", 19F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Gender_Title.Location = new Point(651, 839);
            Gender_Title.Margin = new Padding(4, 0, 4, 0);
            Gender_Title.Name = "Gender_Title";
            Gender_Title.Size = new Size(163, 45);
=======
            Gender_Title.Location = new Point(456, 503);
            Gender_Title.Name = "Gender_Title";
            Gender_Title.Size = new Size(113, 32);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Gender_Title.TabIndex = 11;
            Gender_Title.Text = "Gender";
            // 
            // Change_Gender
            // 
            Change_Gender.BackColor = SystemColors.Control;
            Change_Gender.Enabled = false;
            Change_Gender.Font = new Font("Century Gothic", 14F);
            Change_Gender.ForeColor = SystemColors.Desktop;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Change_Gender.Location = new Point(654, 901);
            Change_Gender.Margin = new Padding(4, 5, 4, 5);
            Change_Gender.Name = "Change_Gender";
            Change_Gender.Size = new Size(388, 42);
=======
            Change_Gender.Location = new Point(458, 541);
            Change_Gender.Name = "Change_Gender";
            Change_Gender.Size = new Size(273, 30);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Change_Gender.TabIndex = 10;
            // 
            // DOB_Title
            // 
            DOB_Title.AutoSize = true;
            DOB_Title.Font = new Font("Century Gothic", 19F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            DOB_Title.Location = new Point(66, 839);
            DOB_Title.Margin = new Padding(4, 0, 4, 0);
            DOB_Title.Name = "DOB_Title";
            DOB_Title.Size = new Size(259, 45);
=======
            DOB_Title.Location = new Point(46, 503);
            DOB_Title.Name = "DOB_Title";
            DOB_Title.Size = new Size(174, 32);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            DOB_Title.TabIndex = 9;
            DOB_Title.Text = "Date Of Birth";
            // 
            // Change_DOB
            // 
            Change_DOB.BackColor = SystemColors.Control;
            Change_DOB.Font = new Font("Century Gothic", 14F);
            Change_DOB.ForeColor = SystemColors.Desktop;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Change_DOB.Location = new Point(70, 901);
            Change_DOB.Margin = new Padding(4, 5, 4, 5);
            Change_DOB.Name = "Change_DOB";
            Change_DOB.Size = new Size(388, 42);
=======
            Change_DOB.Location = new Point(49, 541);
            Change_DOB.Name = "Change_DOB";
            Change_DOB.Size = new Size(273, 30);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Change_DOB.TabIndex = 8;
            Change_DOB.Enter += PinfoTB_Selected;
            // 
            // Email_Title
            // 
            Email_Title.AutoSize = true;
            Email_Title.Font = new Font("Century Gothic", 19F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Email_Title.Location = new Point(1231, 655);
            Email_Title.Margin = new Padding(4, 0, 4, 0);
            Email_Title.Name = "Email_Title";
            Email_Title.Size = new Size(121, 45);
=======
            Email_Title.Location = new Point(862, 393);
            Email_Title.Name = "Email_Title";
            Email_Title.Size = new Size(82, 32);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Email_Title.TabIndex = 7;
            Email_Title.Text = "Email";
            // 
            // Change_Email
            // 
            Change_Email.BackColor = SystemColors.Control;
            Change_Email.Enabled = false;
            Change_Email.Font = new Font("Century Gothic", 14F);
            Change_Email.ForeColor = SystemColors.Desktop;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Change_Email.Location = new Point(1239, 719);
            Change_Email.Margin = new Padding(4, 5, 4, 5);
            Change_Email.Name = "Change_Email";
            Change_Email.Size = new Size(388, 42);
=======
            Change_Email.Location = new Point(867, 431);
            Change_Email.Name = "Change_Email";
            Change_Email.Size = new Size(273, 30);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Change_Email.TabIndex = 6;
            // 
            // Name_Title
            // 
            Name_Title.AutoSize = true;
            Name_Title.Font = new Font("Century Gothic", 19F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Name_Title.Location = new Point(651, 655);
            Name_Title.Margin = new Padding(4, 0, 4, 0);
            Name_Title.Name = "Name_Title";
            Name_Title.Size = new Size(136, 45);
=======
            Name_Title.Location = new Point(456, 393);
            Name_Title.Name = "Name_Title";
            Name_Title.Size = new Size(92, 32);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Name_Title.TabIndex = 5;
            Name_Title.Text = "Name";
            // 
            // Change_Name
            // 
            Change_Name.BackColor = SystemColors.Control;
            Change_Name.Font = new Font("Century Gothic", 14F);
            Change_Name.ForeColor = SystemColors.Desktop;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Change_Name.Location = new Point(654, 719);
            Change_Name.Margin = new Padding(4, 5, 4, 5);
            Change_Name.Name = "Change_Name";
            Change_Name.Size = new Size(388, 42);
=======
            Change_Name.Location = new Point(458, 431);
            Change_Name.Name = "Change_Name";
            Change_Name.Size = new Size(273, 30);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Change_Name.TabIndex = 4;
            Change_Name.Enter += PinfoTB_Selected;
            // 
            // ID_Title
            // 
            ID_Title.AutoSize = true;
            ID_Title.Font = new Font("Century Gothic", 19F);
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            ID_Title.Location = new Point(66, 655);
            ID_Title.Margin = new Padding(4, 0, 4, 0);
            ID_Title.Name = "ID_Title";
            ID_Title.Size = new Size(220, 45);
=======
            ID_Title.Location = new Point(46, 393);
            ID_Title.Name = "ID_Title";
            ID_Title.Size = new Size(148, 32);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            ID_Title.TabIndex = 3;
            ID_Title.Text = "ID Number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            pictureBox1.Location = new Point(656, 34);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 510);
=======
            pictureBox1.Location = new Point(459, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 306);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Change_ID
            // 
            Change_ID.BackColor = SystemColors.Control;
            Change_ID.Enabled = false;
            Change_ID.Font = new Font("Century Gothic", 14F);
            Change_ID.ForeColor = SystemColors.Desktop;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Change_ID.Location = new Point(70, 719);
            Change_ID.Margin = new Padding(4, 5, 4, 5);
            Change_ID.Name = "Change_ID";
            Change_ID.Size = new Size(388, 42);
=======
            Change_ID.Location = new Point(49, 431);
            Change_ID.Name = "Change_ID";
            Change_ID.Size = new Size(273, 30);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Change_ID.TabIndex = 1;
            // 
            // view_exams_panel
            // 
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            view_exams_panel.Location = new Point(379, 92);
            view_exams_panel.Margin = new Padding(4, 5, 4, 5);
            view_exams_panel.Name = "view_exams_panel";
            view_exams_panel.Size = new Size(1650, 1180);
=======
            view_exams_panel.Location = new Point(250, 80);
            view_exams_panel.Name = "view_exams_panel";
            view_exams_panel.Size = new Size(1194, 720);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            view_exams_panel.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Location = new Point(361, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(1644, 1202);
            panel1.TabIndex = 28;
            // 
            // reportPanel
            // 
            reportPanel.Location = new Point(358, 119);
            reportPanel.Name = "reportPanel";
            reportPanel.Size = new Size(1702, 1215);
            reportPanel.TabIndex = 29;
            // 
            // titleLabel
            // 
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(100, 23);
            titleLabel.TabIndex = 0;
            // 
            // viewReportButton
            // 
            viewReportButton.Location = new Point(0, 0);
            viewReportButton.Name = "viewReportButton";
            viewReportButton.Size = new Size(75, 23);
            viewReportButton.TabIndex = 0;
            viewReportButton.Click += ViewReportButton_Click;
            //
            ReportViewer reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill
            };
            // 
            // InstructorForm
            // 
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2064, 1334);
            Controls.Add(RedFlag);
            Controls.Add(reportPanel);
            Controls.Add(panel1);
=======
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 800);
            Controls.Add(RedFlag);
            Controls.Add(Personal_info_Panel);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Controls.Add(HomePanel);
            Controls.Add(RedBar);
            Controls.Add(SidePanel);
            Controls.Add(but_setting);
            Controls.Add(but_Notification);
            Controls.Add(but_Close);
            Controls.Add(but_instagram);
            Controls.Add(but_twitter);
            Controls.Add(but_FB);
            Controls.Add(gen_exam_panel);
            Controls.Add(view_exams_panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
            Margin = new Padding(6, 5, 6, 5);
=======
            Margin = new Padding(4, 3, 4, 3);
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            SidePanel.ResumeLayout(false);
            Report_panel.ResumeLayout(false);
            Report_panel.PerformLayout();
            gen_exam_panel.ResumeLayout(false);
            gen_exam_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            RedFlag.ResumeLayout(false);
            RedFlag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Project_icon).EndInit();
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomePanel_img).EndInit();
            Personal_info_Panel.ResumeLayout(false);
            Personal_info_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button but_Home;
        private System.Windows.Forms.Panel RedBar;
        private System.Windows.Forms.Button but_Pinfo; 
        private System.Windows.Forms.Button but_Report;
        private System.Windows.Forms.Button but_GenExams;
        private System.Windows.Forms.Button but_Close;
        private System.Windows.Forms.Button but_instagram;
        private System.Windows.Forms.Button but_twitter;
        private System.Windows.Forms.Button but_FB;
        private System.Windows.Forms.Button but_setting;
        private System.Windows.Forms.Button but_Notification;
        private System.Windows.Forms.Panel RedFlag;
        private System.Windows.Forms.Label Project_Subheader;
        private System.Windows.Forms.Label Project_header;
        private System.Windows.Forms.PictureBox Project_icon;
        private System.Windows.Forms.Panel Highlighter;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label Clab_ID;
        private System.Windows.Forms.Label Clab_track;
        private System.Windows.Forms.Label Clab_crs;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Label lab_crs;
        private System.Windows.Forms.Label lab_track;
        private System.Windows.Forms.PictureBox HomePanel_img;
        private Button but_Logout;
        private Panel Personal_info_Panel;
        private Label Personal_Details;
        private TextBox Change_ID;
        private PictureBox pictureBox1;
        private Label ID_Title;
        private Label Email_Title;
        private TextBox Change_Email;
        private Label Name_Title;
        private TextBox Change_Name;
        private Label Salary_Title;
        private TextBox Change_Salary;
        private Label Address_Title;
        private TextBox Change_Address;
        private Label Type_Title;
        private TextBox Change_Type;
        private Label Gender_Title;
        private TextBox Change_Gender;
        private Label DOB_Title;
        private TextBox Change_DOB;
        private Button button1;
        private Panel gen_exam_panel;
        private Label label1;
        private Label labelReports;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Student_Number;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn StudentNumber;
        private DataGridViewButtonColumn gen;
        private DataGridViewButtonColumn viewExamsButton;
        private Panel view_exams_panel;
<<<<<<< HEAD:Examination System/InstructorForm.Designer.cs
        private Panel Report_panel;
        private Panel panel1;
        private Label titleLabel;
        private Button viewReportButton;
        private ReportViewer reportViewer;
        private TextBox[] parameterInputs;
        private Panel reportPanel;

        public ReportViewer reportViewer1 { get; private set; }


=======
        private Button Pinfo_Save;
>>>>>>> 740622ee6b86f5e732e945b4a74f9f9499efd491:Examination System/Instr/InstructorForm.Designer.cs
    }
}

