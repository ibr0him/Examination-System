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
            MainPanel = new Panel();
            Clab_ID = new Label();
            Clab_track = new Label();
            Clab_crs = new Label();
            lab_ID = new Label();
            lab_crs = new Label();
            lab_track = new Label();
            HomePanel_img = new PictureBox();
            SidePanel.SuspendLayout();
            RedFlag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Project_icon).BeginInit();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HomePanel_img).BeginInit();
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
            // 
            // but_Logout
            // 
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
            but_instagram.Size = new Size(42, 39);
            but_instagram.TabIndex = 6;
            but_instagram.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_instagram.UseVisualStyleBackColor = true;
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
            but_twitter.Size = new Size(42, 39);
            but_twitter.TabIndex = 7;
            but_twitter.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_twitter.UseVisualStyleBackColor = true;
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
            but_FB.Size = new Size(42, 39);
            but_FB.TabIndex = 8;
            but_FB.TextImageRelation = TextImageRelation.ImageBeforeText;
            but_FB.UseVisualStyleBackColor = true;
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
            // MainPanel
            // 
            MainPanel.Controls.Add(Clab_ID);
            MainPanel.Controls.Add(Clab_track);
            MainPanel.Controls.Add(Clab_crs);
            MainPanel.Controls.Add(lab_ID);
            MainPanel.Controls.Add(lab_crs);
            MainPanel.Controls.Add(lab_track);
            MainPanel.Controls.Add(HomePanel_img);
            MainPanel.Location = new Point(240, 100);
            MainPanel.Margin = new Padding(4, 3, 4, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1154, 699);
            MainPanel.TabIndex = 12;
            // 
            // Clab_ID
            // 
            Clab_ID.AutoSize = true;
            Clab_ID.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clab_ID.Location = new Point(221, 631);
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
            Clab_track.Location = new Point(530, 631);
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
            Clab_crs.Location = new Point(1054, 631);
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
            lab_ID.Location = new Point(148, 631);
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
            lab_crs.Location = new Point(739, 631);
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
            lab_track.Location = new Point(424, 630);
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
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 800);
            Controls.Add(RedFlag);
            Controls.Add(but_setting);
            Controls.Add(but_Notification);
            Controls.Add(but_Close);
            Controls.Add(but_instagram);
            Controls.Add(but_twitter);
            Controls.Add(but_FB);
            Controls.Add(RedBar);
            Controls.Add(SidePanel);
            Controls.Add(MainPanel);
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
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HomePanel_img).EndInit();
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
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label Clab_ID;
        private System.Windows.Forms.Label Clab_track;
        private System.Windows.Forms.Label Clab_crs;
        private System.Windows.Forms.Label lab_ID;
        private System.Windows.Forms.Label lab_crs;
        private System.Windows.Forms.Label lab_track;
        private System.Windows.Forms.PictureBox HomePanel_img;
        private Button but_Logout;
    }
}

