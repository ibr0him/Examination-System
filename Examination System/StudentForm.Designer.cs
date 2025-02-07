namespace Examination_System
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            SidePanel = new Panel();
            but_Logout = new Button();
            Highlighter = new Panel();
            but_Exams = new Button();
            but_Pinfo = new Button();
            but_Home = new Button();
            RedBar = new Panel();
            but_Close = new Button();
            but_instagram = new Button();
            but_twitter = new Button();
            but_FB = new Button();
            but_setting = new Button();
            but_Notification = new Button();
            RedFlag = new Panel();
            Project_Subheader = new Label();
            Project_header = new Label();
            Project_icon = new PictureBox();
            HomePanel = new Panel();
            Clab_ID = new Label();
            Clab_track = new Label();
            Clab_crs = new Label();
            lab_ID = new Label();
            lab_crs = new Label();
            lab_track = new Label();
            HomePanel_img = new PictureBox();
            Personal_info_Panel = new Panel();
            Speciality_Title = new Label();
            Change_Speciality = new TextBox();
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
            Personal_Details = new Label();
            ExamView_Panel = new Panel();
            LowerLarrow = new Button();
            LowerRarrow = new Button();
            Larrow = new Button();
            Rarrow = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            TakeExam_Panel = new Panel();
            but_Previous = new Button();
            but_Next = new Button();
            Q_Label = new Label();
            SidePanel.SuspendLayout();
            RedFlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Project_icon).BeginInit();
            HomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomePanel_img).BeginInit();
            Personal_info_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ExamView_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            TakeExam_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(41, 39, 40);
            SidePanel.Controls.Add(but_Logout);
            SidePanel.Controls.Add(Highlighter);
            SidePanel.Controls.Add(but_Exams);
            SidePanel.Controls.Add(but_Pinfo);
            SidePanel.Controls.Add(but_Home);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Margin = new Padding(4, 3, 4, 3);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(232, 800);
            SidePanel.TabIndex = 0;
            SidePanel.MouseDown += Panel_MouseDown;
            SidePanel.MouseMove += Panel_MouseMove;
            SidePanel.MouseUp += Panel_MouseUp;
            // 
            // but_Logout
            // 
            but_Logout.Cursor = Cursors.Hand;
            but_Logout.FlatAppearance.BorderSize = 0;
            but_Logout.FlatStyle = FlatStyle.Flat;
            but_Logout.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Logout.ForeColor = Color.White;
            but_Logout.Image = (Image)resources.GetObject("but_Logout.Image");
            but_Logout.ImageAlign = ContentAlignment.MiddleLeft;
            but_Logout.Location = new Point(19, 709);
            but_Logout.Margin = new Padding(4, 3, 4, 3);
            but_Logout.Name = "but_Logout";
            but_Logout.Size = new Size(190, 55);
            but_Logout.TabIndex = 13;
            but_Logout.Text = "  Log out";
            but_Logout.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Logout.UseVisualStyleBackColor = true;
            but_Logout.Click += but_Logout_Click;
            // 
            // Highlighter
            // 
            Highlighter.BackColor = Color.FromArgb(178, 8, 55);
            Highlighter.Location = new Point(4, 37);
            Highlighter.Margin = new Padding(4, 3, 4, 3);
            Highlighter.Name = "Highlighter";
            Highlighter.Size = new Size(14, 70);
            Highlighter.TabIndex = 12;
            // 
            // but_Exams
            // 
            but_Exams.Cursor = Cursors.Hand;
            but_Exams.FlatAppearance.BorderSize = 0;
            but_Exams.FlatStyle = FlatStyle.Flat;
            but_Exams.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Exams.ForeColor = Color.White;
            but_Exams.Image = (Image)resources.GetObject("but_Exams.Image");
            but_Exams.ImageAlign = ContentAlignment.MiddleLeft;
            but_Exams.Location = new Point(19, 237);
            but_Exams.Margin = new Padding(4, 3, 4, 3);
            but_Exams.Name = "but_Exams";
            but_Exams.Size = new Size(190, 55);
            but_Exams.TabIndex = 2;
            but_Exams.Text = "  Exams";
            but_Exams.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Exams.UseVisualStyleBackColor = true;
            but_Exams.Click += but_Exams_Click;
            // 
            // but_Pinfo
            // 
            but_Pinfo.Cursor = Cursors.Hand;
            but_Pinfo.FlatAppearance.BorderSize = 0;
            but_Pinfo.FlatStyle = FlatStyle.Flat;
            but_Pinfo.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Pinfo.ForeColor = Color.White;
            but_Pinfo.Image = (Image)resources.GetObject("but_Pinfo.Image");
            but_Pinfo.ImageAlign = ContentAlignment.MiddleLeft;
            but_Pinfo.Location = new Point(19, 139);
            but_Pinfo.Margin = new Padding(4, 3, 4, 3);
            but_Pinfo.Name = "but_Pinfo";
            but_Pinfo.Size = new Size(213, 55);
            but_Pinfo.TabIndex = 2;
            but_Pinfo.Text = "  Personal Info";
            but_Pinfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Pinfo.UseVisualStyleBackColor = true;
            but_Pinfo.Click += but_Pinfo_Click;
            // 
            // but_Home
            // 
            but_Home.Cursor = Cursors.Hand;
            but_Home.FlatAppearance.BorderSize = 0;
            but_Home.FlatStyle = FlatStyle.Flat;
            but_Home.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            but_Home.ForeColor = Color.White;
            but_Home.Image = (Image)resources.GetObject("but_Home.Image");
            but_Home.ImageAlign = ContentAlignment.MiddleLeft;
            but_Home.Location = new Point(19, 44);
            but_Home.Margin = new Padding(4, 3, 4, 3);
            but_Home.Name = "but_Home";
            but_Home.Size = new Size(190, 52);
            but_Home.TabIndex = 2;
            but_Home.Text = "  Home";
            but_Home.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Home.UseVisualStyleBackColor = true;
            but_Home.Click += but_Home_Click;
            // 
            // RedBar
            // 
            RedBar.BackColor = Color.FromArgb(178, 8, 55);
            RedBar.Dock = DockStyle.Top;
            RedBar.Location = new Point(232, 0);
            RedBar.Margin = new Padding(4, 3, 4, 3);
            RedBar.Name = "RedBar";
            RedBar.Size = new Size(1213, 24);
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
            but_Close.Location = new Point(1396, 29);
            but_Close.Margin = new Padding(4, 3, 4, 3);
            but_Close.Name = "but_Close";
            but_Close.Size = new Size(42, 45);
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
            but_instagram.Location = new Point(1077, 32);
            but_instagram.Margin = new Padding(4, 3, 4, 3);
            but_instagram.Name = "but_instagram";
            but_instagram.Size = new Size(35, 39);
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
            but_twitter.Location = new Point(1028, 32);
            but_twitter.Margin = new Padding(4, 3, 4, 3);
            but_twitter.Name = "but_twitter";
            but_twitter.Size = new Size(35, 39);
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
            but_FB.Location = new Point(979, 32);
            but_FB.Margin = new Padding(4, 3, 4, 3);
            but_FB.Name = "but_FB";
            but_FB.Size = new Size(35, 39);
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
            but_setting.Location = new Point(1352, 31);
            but_setting.Margin = new Padding(4, 3, 4, 3);
            but_setting.Name = "but_setting";
            but_setting.Size = new Size(37, 40);
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
            but_Notification.Location = new Point(1308, 31);
            but_Notification.Margin = new Padding(4, 3, 4, 3);
            but_Notification.Name = "but_Notification";
            but_Notification.Size = new Size(37, 40);
            but_Notification.TabIndex = 10;
            but_Notification.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_Notification.UseVisualStyleBackColor = true;
            but_Notification.Click += but_Notification_Click;
            // 
            // RedFlag
            // 
            RedFlag.BackColor = Color.FromArgb(178, 8, 55);
            RedFlag.Controls.Add(Project_Subheader);
            RedFlag.Controls.Add(Project_header);
            RedFlag.Controls.Add(Project_icon);
            RedFlag.Location = new Point(352, 1);
            RedFlag.Margin = new Padding(4, 3, 4, 3);
            RedFlag.Name = "RedFlag";
            RedFlag.Size = new Size(130, 165);
            RedFlag.TabIndex = 11;
            // 
            // Project_Subheader
            // 
            Project_Subheader.AutoSize = true;
            Project_Subheader.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Project_Subheader.ForeColor = Color.White;
            Project_Subheader.Location = new Point(41, 136);
            Project_Subheader.Margin = new Padding(4, 0, 4, 0);
            Project_Subheader.Name = "Project_Subheader";
            Project_Subheader.Size = new Size(50, 17);
            Project_Subheader.TabIndex = 3;
            Project_Subheader.Text = "System";
            // 
            // Project_header
            // 
            Project_header.AutoSize = true;
            Project_header.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Project_header.ForeColor = Color.White;
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
            // HomePanel
            // 
            HomePanel.Controls.Add(Clab_ID);
            HomePanel.Controls.Add(Clab_track);
            HomePanel.Controls.Add(Clab_crs);
            HomePanel.Controls.Add(lab_ID);
            HomePanel.Controls.Add(lab_crs);
            HomePanel.Controls.Add(lab_track);
            HomePanel.Controls.Add(HomePanel_img);
            HomePanel.Location = new Point(240, 100);
            HomePanel.Margin = new Padding(4, 3, 4, 3);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1154, 688);
            HomePanel.TabIndex = 12;
            // 
            // Clab_ID
            // 
            Clab_ID.AutoSize = true;
            Clab_ID.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clab_ID.Location = new Point(208, 622);
            Clab_ID.Margin = new Padding(4, 0, 4, 0);
            Clab_ID.Name = "Clab_ID";
            Clab_ID.Size = new Size(30, 33);
            Clab_ID.TabIndex = 21;
            Clab_ID.Text = "0";
            // 
            // Clab_track
            // 
            Clab_track.AutoSize = true;
            Clab_track.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clab_track.Location = new Point(526, 622);
            Clab_track.Margin = new Padding(4, 0, 4, 0);
            Clab_track.Name = "Clab_track";
            Clab_track.Size = new Size(30, 33);
            Clab_track.TabIndex = 22;
            Clab_track.Text = "0";
            // 
            // Clab_crs
            // 
            Clab_crs.AutoSize = true;
            Clab_crs.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clab_crs.Location = new Point(1029, 623);
            Clab_crs.Margin = new Padding(4, 0, 4, 0);
            Clab_crs.Name = "Clab_crs";
            Clab_crs.Size = new Size(30, 33);
            Clab_crs.TabIndex = 23;
            Clab_crs.Text = "0";
            // 
            // lab_ID
            // 
            lab_ID.AutoSize = true;
            lab_ID.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab_ID.Location = new Point(154, 621);
            lab_ID.Margin = new Padding(4, 0, 4, 0);
            lab_ID.Name = "lab_ID";
            lab_ID.Size = new Size(55, 33);
            lab_ID.TabIndex = 24;
            lab_ID.Text = "ID :";
            // 
            // lab_crs
            // 
            lab_crs.AutoSize = true;
            lab_crs.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab_crs.Location = new Point(745, 621);
            lab_crs.Margin = new Padding(4, 0, 4, 0);
            lab_crs.Name = "lab_crs";
            lab_crs.Size = new Size(289, 33);
            lab_crs.TabIndex = 25;
            lab_crs.Text = "Number Of Cources :";
            // 
            // lab_track
            // 
            lab_track.AutoSize = true;
            lab_track.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lab_track.ImageAlign = ContentAlignment.MiddleLeft;
            lab_track.Location = new Point(430, 620);
            lab_track.Margin = new Padding(4, 0, 4, 0);
            lab_track.Name = "lab_track";
            lab_track.Size = new Size(97, 33);
            lab_track.TabIndex = 26;
            lab_track.Text = "Track :";
            // 
            // HomePanel_img
            // 
            HomePanel_img.Image = (Image)resources.GetObject("HomePanel_img.Image");
            HomePanel_img.Location = new Point(157, 3);
            HomePanel_img.Margin = new Padding(4, 3, 4, 3);
            HomePanel_img.Name = "HomePanel_img";
            HomePanel_img.Size = new Size(906, 590);
            HomePanel_img.SizeMode = PictureBoxSizeMode.Zoom;
            HomePanel_img.TabIndex = 27;
            HomePanel_img.TabStop = false;
            // 
            // Personal_info_Panel
            // 
            Personal_info_Panel.Controls.Add(Speciality_Title);
            Personal_info_Panel.Controls.Add(Change_Speciality);
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
            Personal_info_Panel.Controls.Add(Personal_Details);
            Personal_info_Panel.Location = new Point(239, 89);
            Personal_info_Panel.Name = "Personal_info_Panel";
            Personal_info_Panel.Size = new Size(1166, 699);
            Personal_info_Panel.TabIndex = 13;
            // 
            // Speciality_Title
            // 
            Speciality_Title.AutoSize = true;
            Speciality_Title.Font = new Font("Century Gothic", 19F);
            Speciality_Title.Location = new Point(455, 589);
            Speciality_Title.Name = "Speciality_Title";
            Speciality_Title.Size = new Size(138, 32);
            Speciality_Title.TabIndex = 17;
            Speciality_Title.Text = "Speciality";
            // 
            // Change_Speciality
            // 
            Change_Speciality.BackColor = SystemColors.Control;
            Change_Speciality.Font = new Font("Century Gothic", 14F);
            Change_Speciality.Enabled = false;
            Change_Speciality.ForeColor = SystemColors.Desktop;
            Change_Speciality.Location = new Point(457, 627);
            Change_Speciality.Name = "Change_Speciality";
            Change_Speciality.Size = new Size(273, 30);
            Change_Speciality.TabIndex = 16;
            // 
            // Address_Title
            // 
            Address_Title.AutoSize = true;
            Address_Title.Font = new Font("Century Gothic", 19F);
            Address_Title.Location = new Point(45, 589);
            Address_Title.Name = "Address_Title";
            Address_Title.Size = new Size(114, 32);
            Address_Title.TabIndex = 15;
            Address_Title.Text = "Address";
            // 
            // Change_Address
            // 
            Change_Address.BackColor = SystemColors.Control;
            Change_Address.Enabled = false;
            Change_Address.Font = new Font("Century Gothic", 14F);
            Change_Address.ForeColor = SystemColors.Desktop;
            Change_Address.Location = new Point(48, 627);
            Change_Address.Name = "Change_Address";
            Change_Address.Size = new Size(273, 30);
            Change_Address.TabIndex = 14;
            // 
            // Type_Title
            // 
            Type_Title.AutoSize = true;
            Type_Title.Font = new Font("Century Gothic", 19F);
            Type_Title.Location = new Point(863, 481);
            Type_Title.Name = "Type_Title";
            Type_Title.Size = new Size(192, 32);
            Type_Title.TabIndex = 13;
            Type_Title.Text = "Account Type";
            // 
            // Change_Type
            // 
            Change_Type.BackColor = SystemColors.Control;
            Change_Type.Enabled = false;
            Change_Type.Font = new Font("Century Gothic", 14F);
            Change_Type.ForeColor = SystemColors.Desktop;
            Change_Type.Location = new Point(868, 519);
            Change_Type.Name = "Change_Type";
            Change_Type.Size = new Size(273, 30);
            Change_Type.TabIndex = 12;
            // 
            // Gender_Title
            // 
            Gender_Title.AutoSize = true;
            Gender_Title.Font = new Font("Century Gothic", 19F);
            Gender_Title.Location = new Point(457, 481);
            Gender_Title.Name = "Gender_Title";
            Gender_Title.Size = new Size(113, 32);
            Gender_Title.TabIndex = 11;
            Gender_Title.Text = "Gender";
            // 
            // Change_Gender
            // 
            Change_Gender.BackColor = SystemColors.Control;
            Change_Gender.Enabled = false;
            Change_Gender.Font = new Font("Century Gothic", 14F);
            Change_Gender.ForeColor = SystemColors.Desktop;
            Change_Gender.Location = new Point(459, 519);
            Change_Gender.Name = "Change_Gender";
            Change_Gender.Size = new Size(273, 30);
            Change_Gender.TabIndex = 10;
            // 
            // DOB_Title
            // 
            DOB_Title.AutoSize = true;
            DOB_Title.Font = new Font("Century Gothic", 19F);
            DOB_Title.Location = new Point(47, 481);
            DOB_Title.Name = "DOB_Title";
            DOB_Title.Size = new Size(174, 32);
            DOB_Title.TabIndex = 9;
            DOB_Title.Text = "Date Of Birth";
            // 
            // Change_DOB
            // 
            Change_DOB.BackColor = SystemColors.Control;
            Change_DOB.Enabled = false;
            Change_DOB.Font = new Font("Century Gothic", 14F);
            Change_DOB.ForeColor = SystemColors.Desktop;
            Change_DOB.Location = new Point(50, 519);
            Change_DOB.Name = "Change_DOB";
            Change_DOB.Size = new Size(273, 30);
            Change_DOB.TabIndex = 8;
            // 
            // Email_Title
            // 
            Email_Title.AutoSize = true;
            Email_Title.Font = new Font("Century Gothic", 19F);
            Email_Title.Location = new Point(863, 371);
            Email_Title.Name = "Email_Title";
            Email_Title.Size = new Size(82, 32);
            Email_Title.TabIndex = 7;
            Email_Title.Text = "Email";
            // 
            // Change_Email
            // 
            Change_Email.BackColor = SystemColors.Control;
            Change_Email.Enabled = false;
            Change_Email.Font = new Font("Century Gothic", 14F);
            Change_Email.ForeColor = SystemColors.Desktop;
            Change_Email.Location = new Point(868, 409);
            Change_Email.Name = "Change_Email";
            Change_Email.Size = new Size(273, 30);
            Change_Email.TabIndex = 6;
            // 
            // Name_Title
            // 
            Name_Title.AutoSize = true;
            Name_Title.Font = new Font("Century Gothic", 19F);
            Name_Title.Location = new Point(457, 371);
            Name_Title.Name = "Name_Title";
            Name_Title.Size = new Size(92, 32);
            Name_Title.TabIndex = 5;
            Name_Title.Text = "Name";
            // 
            // Change_Name
            // 
            Change_Name.BackColor = SystemColors.Control;
            Change_Name.Enabled = false;
            Change_Name.Font = new Font("Century Gothic", 14F);
            Change_Name.ForeColor = SystemColors.Desktop;
            Change_Name.Location = new Point(459, 409);
            Change_Name.Name = "Change_Name";
            Change_Name.Size = new Size(273, 30);
            Change_Name.TabIndex = 4;
            // 
            // ID_Title
            // 
            ID_Title.AutoSize = true;
            ID_Title.Font = new Font("Century Gothic", 19F);
            ID_Title.Location = new Point(47, 371);
            ID_Title.Name = "ID_Title";
            ID_Title.Size = new Size(148, 32);
            ID_Title.TabIndex = 3;
            ID_Title.Text = "ID Number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(459, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 257);
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
            Change_ID.Location = new Point(50, 409);
            Change_ID.Name = "Change_ID";
            Change_ID.Size = new Size(273, 30);
            Change_ID.TabIndex = 1;
            // 
            // Personal_Details
            // 
            Personal_Details.AutoSize = true;
            Personal_Details.Font = new Font("Century Gothic", 28F);
            Personal_Details.Location = new Point(439, 285);
            Personal_Details.Name = "Personal_Details";
            Personal_Details.Size = new Size(313, 45);
            Personal_Details.TabIndex = 0;
            Personal_Details.Text = "Personal Details";
            // 
            // ExamView_Panel
            // 
            ExamView_Panel.Controls.Add(LowerLarrow);
            ExamView_Panel.Controls.Add(LowerRarrow);
            ExamView_Panel.Controls.Add(Larrow);
            ExamView_Panel.Controls.Add(Rarrow);
            ExamView_Panel.Controls.Add(pictureBox3);
            ExamView_Panel.Controls.Add(pictureBox2);
            ExamView_Panel.Location = new Point(232, 103);
            ExamView_Panel.Name = "ExamView_Panel";
            ExamView_Panel.Size = new Size(1189, 677);
            ExamView_Panel.TabIndex = 28;
            // 
            // LowerLarrow
            // 
            LowerLarrow.Cursor = Cursors.Hand;
            LowerLarrow.FlatAppearance.BorderSize = 0;
            LowerLarrow.FlatStyle = FlatStyle.Flat;
            LowerLarrow.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LowerLarrow.ForeColor = Color.White;
            LowerLarrow.Image = (Image)resources.GetObject("LowerLarrow.Image");
            LowerLarrow.Location = new Point(35, 517);
            LowerLarrow.Margin = new Padding(4, 3, 4, 3);
            LowerLarrow.Name = "LowerLarrow";
            LowerLarrow.Size = new Size(40, 55);
            LowerLarrow.TabIndex = 17;
            LowerLarrow.TextAlign = ContentAlignment.MiddleLeft;
            LowerLarrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            LowerLarrow.UseVisualStyleBackColor = true;
            LowerLarrow.Click += ExLarrow_Click;
            // 
            // LowerRarrow
            // 
            LowerRarrow.Cursor = Cursors.Hand;
            LowerRarrow.FlatAppearance.BorderSize = 0;
            LowerRarrow.FlatStyle = FlatStyle.Flat;
            LowerRarrow.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LowerRarrow.ForeColor = Color.White;
            LowerRarrow.Image = (Image)resources.GetObject("LowerRarrow.Image");
            LowerRarrow.Location = new Point(1073, 491);
            LowerRarrow.Margin = new Padding(4, 3, 4, 3);
            LowerRarrow.Name = "LowerRarrow";
            LowerRarrow.Size = new Size(40, 55);
            LowerRarrow.TabIndex = 16;
            LowerRarrow.TextAlign = ContentAlignment.MiddleLeft;
            LowerRarrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            LowerRarrow.UseVisualStyleBackColor = true;
            LowerRarrow.Click += ExRarrow_Click;
            // 
            // Larrow
            // 
            Larrow.Cursor = Cursors.Hand;
            Larrow.FlatAppearance.BorderSize = 0;
            Larrow.FlatStyle = FlatStyle.Flat;
            Larrow.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Larrow.ForeColor = Color.White;
            Larrow.Image = (Image)resources.GetObject("Larrow.Image");
            Larrow.Location = new Point(35, 199);
            Larrow.Margin = new Padding(4, 3, 4, 3);
            Larrow.Name = "Larrow";
            Larrow.Size = new Size(40, 55);
            Larrow.TabIndex = 15;
            Larrow.TextAlign = ContentAlignment.MiddleLeft;
            Larrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            Larrow.UseVisualStyleBackColor = true;
            Larrow.Click += ExLarrow_Click;
            // 
            // Rarrow
            // 
            Rarrow.Cursor = Cursors.Hand;
            Rarrow.FlatAppearance.BorderSize = 0;
            Rarrow.FlatStyle = FlatStyle.Flat;
            Rarrow.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Rarrow.ForeColor = Color.White;
            Rarrow.Image = (Image)resources.GetObject("Rarrow.Image");
            Rarrow.Location = new Point(1073, 199);
            Rarrow.Margin = new Padding(4, 3, 4, 3);
            Rarrow.Name = "Rarrow";
            Rarrow.Size = new Size(40, 55);
            Rarrow.TabIndex = 14;
            Rarrow.TextAlign = ContentAlignment.MiddleLeft;
            Rarrow.TextImageRelation = TextImageRelation.ImageBeforeText;
            Rarrow.UseVisualStyleBackColor = true;
            Rarrow.Click += ExRarrow_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1078, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 12);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1145, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 10);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // TakeExam_Panel
            // 
            TakeExam_Panel.Controls.Add(but_Previous);
            TakeExam_Panel.Controls.Add(but_Next);
            TakeExam_Panel.Controls.Add(Q_Label);
            TakeExam_Panel.Location = new Point(235, 77);
            TakeExam_Panel.Name = "TakeExam_Panel";
            TakeExam_Panel.Size = new Size(1198, 711);
            TakeExam_Panel.TabIndex = 29;
            // 
            // but_Previous
            // 
            but_Previous.BackColor = Color.FromArgb(178, 8, 55);
            but_Previous.FlatStyle = FlatStyle.Flat;
            but_Previous.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but_Previous.ForeColor = Color.White;
            but_Previous.Location = new Point(159, 444);
            but_Previous.Name = "but_Previous";
            but_Previous.RightToLeft = RightToLeft.No;
            but_Previous.Size = new Size(127, 46);
            but_Previous.TabIndex = 4;
            but_Previous.Text = "Previous";
            but_Previous.UseVisualStyleBackColor = false;
            but_Previous.Click += but_Previous_Click;
            // 
            // but_Next
            // 
            but_Next.BackColor = Color.FromArgb(178, 8, 55);
            but_Next.FlatStyle = FlatStyle.Flat;
            but_Next.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but_Next.ForeColor = Color.White;
            but_Next.Location = new Point(968, 444);
            but_Next.Name = "but_Next";
            but_Next.Size = new Size(127, 46);
            but_Next.TabIndex = 3;
            but_Next.Text = "Next";
            but_Next.UseVisualStyleBackColor = false;
            but_Next.Click += but_Next_Click;
            // 
            // Q_Label
            // 
            Q_Label.AutoSize = true;
            Q_Label.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Q_Label.Location = new Point(70, 150);
            Q_Label.MaximumSize = new Size(1100, 0);
            Q_Label.Name = "Q_Label";
            Q_Label.Size = new Size(1097, 36);
            Q_Label.TabIndex = 0;
            Q_Label.Text = "Q1) Why do programmers prefer dark mode? Because light attracts bugs!😂";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 800);
            Controls.Add(RedFlag);
            Controls.Add(TakeExam_Panel);
            Controls.Add(ExamView_Panel);
            Controls.Add(but_setting);
            Controls.Add(but_Notification);
            Controls.Add(but_Close);
            Controls.Add(but_instagram);
            Controls.Add(but_twitter);
            Controls.Add(but_FB);
            Controls.Add(RedBar);
            Controls.Add(SidePanel);
            Controls.Add(HomePanel);
            Controls.Add(Personal_info_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            SidePanel.ResumeLayout(false);
            RedFlag.ResumeLayout(false);
            RedFlag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Project_icon).EndInit();
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomePanel_img).EndInit();
            Personal_info_Panel.ResumeLayout(false);
            Personal_info_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ExamView_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            TakeExam_Panel.ResumeLayout(false);
            TakeExam_Panel.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button but_Home;
        private System.Windows.Forms.Panel RedBar;
        private System.Windows.Forms.Button but_Pinfo;
        private System.Windows.Forms.Button but_Exams;
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
        private Label Speciality_Title;
        private TextBox Change_Speciality;
        private Label Address_Title;
        private TextBox Change_Address;
        private Label Type_Title;
        private TextBox Change_Type;
        private Label Gender_Title;
        private TextBox Change_Gender;
        private Label DOB_Title;
        private TextBox Change_DOB;
        private Panel ExamView_Panel;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button Rarrow;
        private Button Larrow;
        private Button LowerLarrow;
        private Button LowerRarrow;
        private Panel TakeExam_Panel;
        private Label Q_Label;
        private Button but_Previous;
        private Button but_Next;

        //Image = (Image)resources.GetObject("Project_icon.Image");
    }
}

