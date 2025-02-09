namespace Examination_System
{
    partial class PopUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));
            HeaderBar = new Panel();
            MiniPhoto = new PictureBox();
            CloseButton = new PictureBox();
            Header = new Label();
            MainImage = new PictureBox();
            ok = new Button();
            Message = new Label();
            ConfusionPhoto = new PictureBox();
            Done = new PictureBox();
            HeaderBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiniPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MainImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ConfusionPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Done).BeginInit();
            SuspendLayout();
            // 
            // HeaderBar
            // 
            HeaderBar.BackColor = Color.FromArgb(178, 8, 55);
            HeaderBar.Controls.Add(MiniPhoto);
            HeaderBar.Controls.Add(CloseButton);
            HeaderBar.Controls.Add(Header);
            HeaderBar.Location = new Point(-2, 0);
            HeaderBar.Name = "HeaderBar";
            HeaderBar.Size = new Size(439, 57);
            HeaderBar.TabIndex = 0;
            HeaderBar.MouseDown += Panel_MouseDown;
            HeaderBar.MouseMove += Panel_MouseMove;
            HeaderBar.MouseUp += Panel_MouseUp;
            // 
            // MiniPhoto
            // 
            MiniPhoto.Image = (Image)resources.GetObject("MiniPhoto.Image");
            MiniPhoto.Location = new Point(361, 12);
            MiniPhoto.Name = "MiniPhoto";
            MiniPhoto.Size = new Size(30, 30);
            MiniPhoto.SizeMode = PictureBoxSizeMode.AutoSize;
            MiniPhoto.TabIndex = 1;
            MiniPhoto.TabStop = false;
            MiniPhoto.Click += MiniPhoto_Click;
            // 
            // CloseButton
            // 
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(397, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(30, 30);
            CloseButton.SizeMode = PictureBoxSizeMode.AutoSize;
            CloseButton.TabIndex = 2;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.BackColor = Color.FromArgb(175, 8, 55);
            Header.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.White;
            Header.Location = new Point(177, 9);
            Header.Name = "Header";
            Header.Size = new Size(104, 41);
            Header.TabIndex = 1;
            Header.Text = "Error";
            Header.MouseDown += Panel_MouseDown;
            Header.MouseMove += Panel_MouseMove;
            Header.MouseUp += Panel_MouseUp;
            // 
            // MainImage
            // 
            MainImage.Image = (Image)resources.GetObject("MainImage.Image");
            MainImage.Location = new Point(223, 63);
            MainImage.Name = "MainImage";
            MainImage.Size = new Size(202, 209);
            MainImage.SizeMode = PictureBoxSizeMode.AutoSize;
            MainImage.TabIndex = 1;
            MainImage.TabStop = false;
            // 
            // ok
            // 
            ok.BackColor = Color.FromArgb(178, 8, 55);
            ok.FlatStyle = FlatStyle.Flat;
            ok.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ok.ForeColor = Color.White;
            ok.Location = new Point(40, 229);
            ok.Name = "ok";
            ok.Size = new Size(102, 39);
            ok.TabIndex = 2;
            ok.Text = "Okey";
            ok.UseVisualStyleBackColor = false;
            ok.Click += button_Click;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Message.Location = new Point(12, 132);
            Message.MaximumSize = new Size(215, 0);
            Message.Name = "Message";
            Message.Size = new Size(200, 46);
            Message.TabIndex = 3;
            Message.Text = "Please Enter Vaild User Na And Passord";
            // 
            // ConfusionPhoto
            // 
            ConfusionPhoto.Image = (Image)resources.GetObject("ConfusionPhoto.Image");
            ConfusionPhoto.Location = new Point(171, 63);
            ConfusionPhoto.Name = "ConfusionPhoto";
            ConfusionPhoto.Size = new Size(41, 19);
            ConfusionPhoto.TabIndex = 4;
            ConfusionPhoto.TabStop = false;
            // 
            // Done
            // 
            Done.Image = (Image)resources.GetObject("Done.Image");
            Done.Location = new Point(175, 88);
            Done.Name = "Done";
            Done.Size = new Size(36, 20);
            Done.TabIndex = 5;
            Done.TabStop = false;
            // 
            // PopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(437, 280);
            Controls.Add(MainImage);
            Controls.Add(Message);
            Controls.Add(ok);
            Controls.Add(HeaderBar);
            Controls.Add(ConfusionPhoto);
            Controls.Add(Done);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUp";
            MouseDown += Panel_MouseDown;
            MouseMove += Panel_MouseMove;
            MouseUp += Panel_MouseUp;
            HeaderBar.ResumeLayout(false);
            HeaderBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MiniPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MainImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)ConfusionPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Done).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel HeaderBar;
        private Label Header;
        private PictureBox CloseButton;
        private PictureBox MiniPhoto;
        private PictureBox MainImage;
        private Button ok;
        private Label Message;
        private PictureBox ConfusionPhoto;
        private PictureBox Done;
    }
}