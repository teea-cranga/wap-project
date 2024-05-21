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
    public partial class MainForm : Form
    {
        public void DisplayStudent()
        {

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            AddStudForm addStudForm = new AddStudForm();
            Student stud = new Student();
            addStudForm.Student = stud;
            if (addStudForm.ShowDialog()  == DialogResult.OK)
            {
                DisplayStudent();
            }
        }
    }
}
