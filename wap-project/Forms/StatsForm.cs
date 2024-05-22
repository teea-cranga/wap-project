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

namespace wap_project.Forms
{

    public partial class StatsForm : Form
    {
        private readonly List<Student> students;

        public StatsForm(List<Student> students)
        {
            InitializeComponent();
            this.students = students;
        }


        // honestly, I looked at someone else's code and took it(changed the group by stuff tho)
        //  because I didn't quite understand the teacher's example :(
        private void DrawPieChart(Graphics g)
        {
            var studDist = students.GroupBy(c => c.Subject.stringToNumber(c.Subject.SubjectName))
                                   .Select(c => new { subName = c.Key, Count = c.Count() })
                                   .ToList();
            int chartWidth = 300;
            int chartHeight = 300;
            int chartX = 50;
            int chartY = 50;
            int total = studDist.Sum(cd => cd.Count);

            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow };
            Brush[] brushes = colors.Select(c => new SolidBrush(c)).ToArray();

            float startAngle = 0;
            foreach (var item in studDist)
            {
                float sweepAngle = item.Count / (float)total * 360;
                g.FillPie(brushes[item.subName - 1], chartX, chartY, chartWidth, chartHeight, startAngle, sweepAngle);
                startAngle += sweepAngle;
            }

            Font legendFont = new Font("Arial", 10);
            for (int i = 0; i < 4; i++)
            {
                String[] subjects = { "stats", "cyb", "info eco", "info eco en" };
                Brush brush = brushes[i];
                g.FillRectangle(brush, chartX + chartWidth + 20, chartY + i * 20, 15, 15);
                g.DrawString(subjects[i], legendFont, Brushes.Black, chartX + chartWidth + 40, chartY + i * 20);
            }

        }

        private void chart1_Paint(object sender, PaintEventArgs e)
        {
            DrawPieChart(e.Graphics);
        }
    }
}
