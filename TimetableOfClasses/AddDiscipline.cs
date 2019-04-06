using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
	public partial class AddDiscipline : Form
	{
		public AddDiscipline()
		{
			InitializeComponent();
		}

		private void btCreateAndClean_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text) || String.IsNullOrWhiteSpace(tbCycleOfDis.Text))
				MessageBox.Show("Заполните все поля");
			else
			{
				MDiscipline mDiscipline = new MDiscipline(tbFullName.Text, tbShortName.Text, tbCycleOfDis.Text);
				try
				{
					Controllers.CDiscipline.Insert(mDiscipline);
					tbFullName.Text = "";
					tbShortName.Text = "";
					tbCycleOfDis.Text = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btCreateAndClose_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text) || String.IsNullOrWhiteSpace(tbCycleOfDis.Text))
				MessageBox.Show("Заполните все поля");
			else
			{
				MDiscipline mDiscipline = new MDiscipline(tbFullName.Text, tbShortName.Text, tbCycleOfDis.Text);
				try
				{
					Controllers.CDiscipline.Insert(mDiscipline);
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
