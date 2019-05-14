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
	public partial class AddAcademicTitle : Form
	{
		public AddAcademicTitle()
		{
			InitializeComponent();
		}

		private void btCreateAndClose_Click(object sender, EventArgs e)
		{
			
			if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
			{
				MTitle Title = new MTitle(FullName.Text, Reduction.Text);
				RefData.CTitle.Insert(Title);
				this.Close();
			}
			else MessageBox.Show("Невозможно добавить эту дисциплину!", "Попробуйте снова", MessageBoxButtons.OK);
		}

		private void btCreateAndClean_Click(object sender, EventArgs e)
		{
			
			if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
			{
				MTitle Title = new MTitle(FullName.Text, Reduction.Text);
				RefData.CTitle.Insert(Title);
				FullName.Text = "";
				Reduction.Text = "";
			}
			else MessageBox.Show("Невозможно добавить эту дисциплину!", "Попробуйте снова", MessageBoxButtons.OK);
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
