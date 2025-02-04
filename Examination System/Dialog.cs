using System;
using System.Windows.Forms;

public class InputDialog : Form
{
    private TextBox textBox1;
    private TextBox textBox2;
    private Button okButton;
    private Button cancelButton;

    public string Input1 => textBox1.Text;
    public string Input2 => textBox2.Text;

    public InputDialog(string courseName)
    {
        this.Text = "Generate Exam";
        this.Width = 350;
        this.Height = 200;
        this.StartPosition = FormStartPosition.CenterScreen;

        Label label1 = new Label() { Text = "Number of MCQ:", Left = 10, Top = 20, AutoSize = true };
        textBox1 = new TextBox() { Left = 175, Top = 20, Width = 150 };

        Label label2 = new Label() { Text = "Number of T/F:", Left = 10, Top = 60, AutoSize = true };
        textBox2 = new TextBox() { Left = 175, Top = 60, Width = 150 };

        okButton = new Button() { Text = "OK", Left = 50, Top = 100, Width = 80 , AutoSize = true };
        okButton.Click += (sender, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

        cancelButton = new Button() { Text = "Cancel", Left = 150, Top = 100, Width = 80, AutoSize = true };
        cancelButton.Click += (sender, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

        this.Controls.Add(label1);
        this.Controls.Add(textBox1);
        this.Controls.Add(label2);
        this.Controls.Add(textBox2);
        this.Controls.Add(okButton);
        this.Controls.Add(cancelButton);
    }
}