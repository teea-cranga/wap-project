using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wap_project.Classes;

namespace wap_project
{
    public partial class AddStudForm : Form
    {
        public Student Student {  get; set; }
        public AddStudForm()
        {
            InitializeComponent();
        }

        public AddStudForm(Student student)
        {
            Student = student;
        }

        private void AddStudForm_Load(object sender, EventArgs e)
        {
            if(Student != null)
            {
                tbFN.Text = Student.FirstName;
                tbLN.Text = Student.LastName;
                cbFAC.SelectedIndex = 0;
            }
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            if(Student != null) 
            {
                Student.FirstName = tbFN.Text;
                Student.LastName = tbLN.Text;
                Student.Subject = new Subject(cbFAC.Text, 3);
            }
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (tbFN.Text.Length < 1 || tbFN.Text.Any(Char.IsDigit))
            {
                e.Cancel = true;
                errFName.SetError((Control)sender, "Invalid name.");
            }
        }

        private void tbLN_Validating(object sender, CancelEventArgs e)
        {
            if (tbLN.Text.Length < 3 || tbLN.Text.Any(Char.IsDigit))
            {
                e.Cancel = true;
                errFName.SetError((Control)sender, "Invalid name.");
            }
        }
    }
}
