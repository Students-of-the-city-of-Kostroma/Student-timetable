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
	public partial class University : Form
	{
		public University()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			AddUniversity a = new AddUniversity();
			a.Show();
		}
	}
}
