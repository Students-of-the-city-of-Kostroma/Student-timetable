using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.ShowDialog();
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Groups group = new Groups();
            group.ShowDialog();
        }
        
        private void дисциплиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Discipline d = new Discipline();
            d.ShowDialog();
        }
        
        private void аудиторииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auditor audit = new Auditor();
            audit.ShowDialog();
        }
    }
}