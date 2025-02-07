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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var columnIndex = e.ColumnIndex;

                string courseName = dataGridView1.Rows[e.RowIndex].Cells["CourseName"].Value.ToString();
                int courseId = (int)dataGridView1.Rows[e.RowIndex].Cells["CourseID"].Value;

                if (dataGridView1.Columns[columnIndex].Name == "gen")
                {
                    using (InputDialog dialog = new InputDialog(courseName))
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            int input1 = int.Parse(dialog.Input1); // MCQ count
                            int input2 = int.Parse(dialog.Input2); // True/False count

                            ProcedureQ("GenerateExam",
                                new string[] { "@Crs_ID", "@MCQ_Count", "@TF_Count" },
                                new object[] { courseId, input1, input2 },
                                out string[] exam);

                            MessageBox.Show($"Exam generated for {courseName} with {input1} MCQs and {input2} True/False questions.");
                        }
                    }
                }
                else if (dataGridView1.Columns[columnIndex].Name == "viewExamsButton")
                {
                    ViewExams(courseName, courseId);
                }
            }
        }


    }
}
