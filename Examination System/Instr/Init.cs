using static DBConnect;
using Examination_System.Instr;

namespace Examination_System
{
    public partial class InstructorForm : Form
    {

        List<Course> coursesList = new List<Course>();
        List<Exam> examList = new List<Exam>();
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;

        private void InitializePdfViewer()
        {
            webView = new Microsoft.Web.WebView2.WinForms.WebView2
            {
                Source = new Uri("about:blank"), // Initialize with a blank page
                Visible = false
            };

            // Set initial size to match parent panel
            webView.Size = this.ClientSize;
            webView.Location = gen_exam_panel.Location;

            // Handle resizing dynamically
            this.SizeChanged += (sender, e) =>
            {
                webView.Size = gen_exam_panel.Size;
            };
            // Add the WebView2 control to the form/container
            this.Controls.Add(webView);

            // Initialize the CoreWebView2 environment
            webView.EnsureCoreWebView2Async();
        }


        System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
        // To Transfer Teacher's Personal Data
        private static string[] Teachers;
        public InstructorForm(string[] Teacher)
        {

            InitializeComponent();
            InitializePdfViewer();


            string[] temp;

            Highlighter.Height = but_Home.Height;
            Highlighter.Top = but_Home.Top;

            SelectQ(@$"Select COUNT(T.Crs_ID)
                        From Ins I join Teach T
                        on T.Ins_ID = I.ID
                        Group By I.ID
                        Having I.ID = {Teacher[0]}", out temp);

            Clab_ID.Text = Teacher[0];
            Clab_crs.Text = temp[0];

            SelectQ(@$"Select T.Name
                        From Ins I join Track T
                        on I.Track_ID=T.ID
                        Where T.ID ={Teacher[0]}", out temp);
            Clab_track.Text = temp[0];


            ProcedureQ("ReportInstCourses", new string[] { "@Inst_Id" }, new object[] { Teacher[0] }, out string[] coursesArray);

            if (coursesArray.Length % 3 != 0)
                PopUp.ErrorMessage("Error: Unexpected course data format.");
            else
            {
                for (int i = 0; i < coursesArray.Length; i += 3)
                {
                    var course = new Course(
                        coursesArray[i], // Course Name
                        int.Parse(coursesArray[i + 1]), // Course ID
                        int.Parse(coursesArray[i + 2])  // Student Number
                    );

                    coursesList.Add(course);

                    dataGridView1.Rows.Add(course.Id, course.Name, course.StudentCount);
                }
            }

            gen_exam_panel.Visible = false;
            
            
            // Personal Info Page
            Personal_info_Panel.Visible = false;
            Pinfo_Save.Visible = false;

            Change_ID.Text = " " + Teacher[0];
            Change_Name.Text = " " + Teacher[1];
            Change_Email.Text = " " + Teacher[3];
            Change_DOB.Text = " " + Teacher[4];
            Change_Gender.Text = " " + Teacher[5];
            Change_Type.Text = " " + Teacher[6];
            Change_Address.Text = " " + Teacher[7];
            Change_Salary.Text = $"{decimal.Parse(Teacher[8]):N2} EGP";

            Teachers = Teacher;

        }


    }
}
