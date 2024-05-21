using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using wap_project.Classes;

namespace wap_project
{
    public partial class MainForm : Form
    {
        private Year Year;
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
                MessageBox.Show("No student was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
    }
}
