using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{

    public partial class PopUp : Form
    {
        // For Making the form Dragable on dragging Certain Forms
        private bool Win_dragging = false;
        private Point Win_dragCursorPoint;
        private Point Win_dragFormPoint;

        // Flags
        private static bool Result
            ;
        private static int[] ColorCode = new int[] {178,8,55};
        public PopUp(string Mess)
        {
            InitializeComponent();
            Header.Location = new Point(((HeaderBar.Width - Header.Width) / 2), Header.Location.Y);
            Message.Text = Mess;
            int temp = (229 - 57 - Message.Height) / 2;
            temp += 57;
            Message.Location = new Point(Message.Location.X, temp);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Define border color and thickness
            Color borderColor = Color.FromArgb(ColorCode[0], ColorCode[1], ColorCode[2]);
            int borderWidth = 3;

            // Draw border
            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen,
                    borderWidth / 2, borderWidth / 2,
                    this.ClientSize.Width - borderWidth,
                    this.ClientSize.Height - borderWidth);
            }
        }



        private  void button_Click(object sender, EventArgs e)
        {
            Button But = sender as Button;

            if (But.Text == "Okey" || But.Text == "Yes")
                Result = true;
            
            if(But.Text == "No")
                Result= false;

            this.Close();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Result = false;
            this.Close();
        }

        private void MiniPhoto_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        public static void ErrorMessage(string Mess)
        {
            ColorCode = new int[] { 178, 8, 55 };
            PopUp temp = new PopUp(Mess);
            temp.Show();
        }
        public void DoneMessage(String Mess)
        {
            ColorCode = new int[] { 50, 213, 104 };
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));

            MainImage.Image = (Image)resources.GetObject("Done.Image");
            Header.Text = "Done";
            HeaderBar.BackColor = Color.FromArgb(ColorCode[0], ColorCode[1], ColorCode[2]);
            Header.BackColor= Color.FromArgb(ColorCode[0], ColorCode[1], ColorCode[2]);
            ok.BackColor = Color.FromArgb(ColorCode[0], ColorCode[1], ColorCode[2]);
            this.Show();

        }
        public bool ConfirmMessage(string Mess)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUp));

            ColorCode = new int[] { 39, 99, 210 };

            Header.Text = "Confirm";
            Header.BackColor = Color.FromArgb(ColorCode[0], ColorCode[1], ColorCode[2]);
            ok.BackColor = Color.FromArgb(ColorCode[0], ColorCode[1], ColorCode[2]);
            ok.Location = new Point(32, 229);
            ok.Size = new Size(69, 39);
            ok.Text = "Yes";
            Header.Location = new Point(((HeaderBar.Width - Header.Width) / 2), Header.Location.Y);
           

            Button but2 = new Button()
            {
                BackColor = Color.FromArgb(39, 99, 210),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                ForeColor = Color.White,
                Location = new Point(107, 229),
                Name = "button1",
                Size = new Size(69, 39),
                TabIndex = 5,
                Text = "No",
                UseVisualStyleBackColor = false
            };
            Controls.Add(but2);
            HeaderBar.BackColor = Color.FromArgb(ColorCode[0], ColorCode[1], ColorCode[2]);
            but2.Click += button_Click;
            MainImage.Image = (Image)resources.GetObject("ConfusionPhoto.Image");

            this.ShowDialog();
            
            return Result;

        }

    }
}
