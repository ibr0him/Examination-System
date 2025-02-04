using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{
    public partial class StudentExam : Form
    {
        public StudentExam()
        {
            InitializeComponent();
        }

        private void lab_ID_Click(object sender, EventArgs e)
        {
          
        }
        private void see_res_click(object sender, EventArgs e)
        {
            FinalResult final_sub = new FinalResult();
            this.Hide();
            final_sub.Show();
        }
    }
}
