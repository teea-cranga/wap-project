using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using wap_project.Classes;
using wap_project.Database;

namespace wap_project
{
    [Serializable]
    public partial class MainForm : Form
    {

        public Year Year;
        public void DisplayStudent()
        {
            lvStudents.Items.Clear();
            foreach (var stud in Year.StudentsFromYear)
            {
                ListViewItem lvi = new ListViewItem(stud.FirstName);
                lvi.SubItems.Add(stud.LastName);
                lvi.SubItems.Add(stud.Subject.ToString());
                lvi.SubItems.Add(Year.ToString());
                lvi.Tag = stud;
                lvStudents.Items.Add(lvi);
            }
            lblStrip.Text = Year.StudentsFromYear.Count.ToString();
        }

        public MainForm()
        {
            Year = new Year();
            InitializeComponent();
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            AddStudForm addStudForm = new AddStudForm();
            Student stud = new Student();
            addStudForm.Student = stud;
            if (addStudForm.ShowDialog()  == DialogResult.OK)
            {
                Year.StudentsFromYear.Add(stud);
                DisplayStudent();
            }
        }

        private void btnEditStud_Click(object sender, EventArgs e)
        {
            if(lvStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("No student was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddStudForm addStudForm = new AddStudForm();
            Student stud = lvStudents.SelectedItems[0].Tag as Student;
            if (lvStudents.SelectedItems.Count == 1)
            {
                
                addStudForm.Student = stud;
                if (addStudForm.ShowDialog() == DialogResult.OK)
                {
                    DisplayStudent();
                }
            }        
        }

        private void btnDelStud_Click(object sender, EventArgs e)
        {
            if (lvStudents.SelectedItems.Count == 0)
            {
                MessageBox.Show("No student was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Student stud = lvStudents.SelectedItems[0].Tag as Student;
            if (lvStudents.SelectedItems.Count == 1)
            {
                Year.StudentsFromYear.Remove(stud);
                DisplayStudent();
            }
        }

        private void createAReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createReport();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.S) {
                createReport();
                return;
            }

            if(e.Alt && e.KeyCode == Keys.C)
            {
                btnAddStud_Click(sender, e);
                return;
            }

            if(e.Alt && e.KeyCode == Keys.E)
            {
                btnEditStud_Click(sender, e);
                return;
            }

            if(e.Alt && e.KeyCode == Keys.D)
            {
                btnDelStud_Click(sender, e);
                return;
            }
        }

        private void createReport()
        {
            List<Student> students = new List<Student>(Year.StudentsFromYear);
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    if (students.Count == 0)
                    {
                        sw.WriteLine("No students found.");
                    }
                    sw.WriteLine("Student count: " + students.Count);
                    foreach (Student stud in students)
                    {
                        string line = "Student full name: " + stud.FirstName + " " + stud.LastName + " with subject: " + stud.Subject.ToString() + " during the years: " + Year.ToString();
                        sw.WriteLine(line);
                    }
                    sw.Close();
                    lblStrip2.Text = "Report created!";

                }
            }
        }
    }
}
