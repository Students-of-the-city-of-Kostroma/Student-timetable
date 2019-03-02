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
    public partial class Auditor : Form
    {
        public Auditor()
        {
            InitializeComponent();
        }

		private void bt1_Click(object sender, EventArgs e)
		{
			AddAuditor t = new AddAuditor();
			t.ShowDialog();
		}
	}
}
