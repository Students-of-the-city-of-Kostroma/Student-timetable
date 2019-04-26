using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
	public partial class Institute : Form
	{
		public Institute()
		{
			InitializeComponent();
			DG_Institute.DataSource =Controllers.CInstitute.Select();
		}

		private void Add_Click(object sender, EventArgs e)
		{
			AddInstitute addInstitute = new AddInstitute();
			addInstitute.Show();
		}
	}
}
