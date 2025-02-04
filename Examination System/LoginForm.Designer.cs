

namespace Examination_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lab_email = new Label();
            lab_pass = new Label();
            textBox_email = new TextBox();
            textBox_password = new TextBox();
            button_login = new Button();
            Close_But = new Button();
            Mini_but = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(130, 89);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 251);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 33);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // lab_email
            // 
            lab_email.AutoSize = true;
            lab_email.BackColor = Color.White;
            lab_email.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_email.ForeColor = Color.FromArgb(178, 8, 55);
            lab_email.Location = new Point(34, 316);
            lab_email.Margin = new Padding(4, 0, 4, 0);
            lab_email.Name = "lab_email";
            lab_email.Size = new Size(71, 23);
            lab_email.TabIndex = 2;
            lab_email.Text = "Email :";
            // 
            // lab_pass
            // 
            lab_pass.AutoSize = true;
            lab_pass.BackColor = Color.White;
            lab_pass.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lab_pass.ForeColor = Color.FromArgb(178, 8, 55);
            lab_pass.Location = new Point(35, 392);
            lab_pass.Margin = new Padding(4, 0, 4, 0);
            lab_pass.Name = "lab_pass";
            lab_pass.Size = new Size(101, 23);
            lab_pass.TabIndex = 2;
            lab_pass.Text = "Password:";
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_email.Location = new Point(39, 345);
            textBox_email.Margin = new Padding(4, 3, 4, 3);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(378, 27);
            textBox_email.TabIndex = 3;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_password.Location = new Point(39, 421);
            textBox_password.Margin = new Padding(4, 3, 4, 3);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(378, 27);
            textBox_password.TabIndex = 4;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.BackColor = Color.FromArgb(178, 8, 55);
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(92, 482);
            button_login.Margin = new Padding(4, 3, 4, 3);
            button_login.Name = "button_login";
            button_login.Size = new Size(270, 57);
            button_login.TabIndex = 5;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // Close_But
            // 
            Close_But.BackColor = Color.White;
            Close_But.FlatAppearance.BorderSize = 0;
            Close_But.FlatStyle = FlatStyle.Flat;
            Close_But.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Close_But.ForeColor = Color.Black;
            Close_But.Image = (Image)resources.GetObject("Close_But.Image");
            Close_But.Location = new Point(418, 12);
            Close_But.Margin = new Padding(4, 3, 4, 3);
            Close_But.Name = "Close_But";
            Close_But.Size = new Size(30, 33);
            Close_But.TabIndex = 6;
            Close_But.UseVisualStyleBackColor = false;
            Close_But.Click += Close_But_Click;
            // 
            // Mini_but
            // 
            Mini_but.BackColor = Color.White;
            Mini_but.FlatAppearance.BorderSize = 0;
            Mini_but.FlatStyle = FlatStyle.Flat;
            Mini_but.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Mini_but.ForeColor = Color.Black;
            Mini_but.Image = (Image)resources.GetObject("Mini_but.Image");
            Mini_but.Location = new Point(381, 13);
            Mini_but.Margin = new Padding(4, 3, 4, 3);
            Mini_but.Name = "Mini_but";
            Mini_but.Size = new Size(30, 33);
            Mini_but.TabIndex = 7;
            Mini_but.UseVisualStyleBackColor = false;
            Mini_but.Click += Mini_but_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(461, 635);
            Controls.Add(Mini_but);
            Controls.Add(Close_But);
            Controls.Add(button_login);
            Controls.Add(textBox_email);
            Controls.Add(textBox_password);
            Controls.Add(lab_pass);
            Controls.Add(lab_email);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFormcs";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_email;
        private System.Windows.Forms.Label lab_pass;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button Close_But;
        private Button Mini_but;
    }
}