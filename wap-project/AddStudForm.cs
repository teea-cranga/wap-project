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
            }
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            if(Student != null) 
            {
                Student.FirstName = tbFN.Text;
                Student.LastName = tbLN.Text;
            }
        }

        private void tbFN_Validated(object sender, EventArgs e)
        {
            errFName.SetError((Control)sender,"Mandatory field.");
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (tbFN.Text.Length == 0)
            {
                e.Cancel = true;
                errFName.SetError((Control)sender, "This field is mandatory.");
            }

        }
    }
}
