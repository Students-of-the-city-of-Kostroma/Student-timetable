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
			byte a;
			if ((byte.TryParse(textCodeOfDiscipline.Text.ToString(), out a)) && (textCodeOfDiscipline.Text.Length != 0) && (textNameOfDiscipline.Text.Length != 0))
			{
				MDiscipline Discipline = new MDiscipline(textNameOfDiscipline.Text, textCodeOfDiscipline.Text);
				Controllers.CDiscipline.Insert(Discipline);
				textNameOfDiscipline.Text = "";
				textCodeOfDiscipline.Text = "";
			}
			else MessageBox.Show("Невозможно добавить эту дисциплину!", "Попробуйте снова", MessageBoxButtons.OK);
		}

		private void btCreateAndClose_Click(object sender, EventArgs e)
		{
			byte a;
			if ((byte.TryParse(textCodeOfDiscipline.Text.ToString(), out a)) && (textCodeOfDiscipline.Text.Length != 0) && (textNameOfDiscipline.Text.Length != 0))
			{
				MDiscipline Discipline = new MDiscipline(textNameOfDiscipline.Text, textCodeOfDiscipline.Text);
				Controllers.CDiscipline.Insert(Discipline);
				this.Close();
			}
			else MessageBox.Show("Невозможно добавить эту дисциплину!", "Попробуйте снова", MessageBoxButtons.OK);
		}
	}
}
