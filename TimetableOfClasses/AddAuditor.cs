using LibOfTimetableOfClasses;
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
	public partial class AddAuditor : Form
	{
		public AddAuditor()
		{
			InitializeComponent();
		}

		private void btCancel_Click(object sender, EventArgs e)// отмена
		{
			Close();
		}

		private void bt_Cr_n_Cl_Click(object sender, EventArgs e)// создать и очистить
		{
			if (tbAuditor.Text.Contains(" ") || tbKaf.Text.Contains(" ") || tbCorpus.Text.Contains(" ") || Convert.ToString(nuPlaces.Value) == "")
				MessageBox.Show("Заполните все поля");
			MAuditor Auditor = new MAuditor(tbAuditor.Text, tbKaf.Text, (ushort)nuPlaces.Value, Convert.ToByte(tbCorpus.Text));
			try
			{
				Controllers.CAuditor.Insert(Auditor);
				tbAuditor.Text = "";
				tbKaf.Text = "";
				tbCorpus.Text = "";
				nuPlaces.Value = 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void bt_Cr_n_Close_Click(object sender, EventArgs e)// создать и закрыть
		{
			if (tbAuditor.Text.Contains(" ") || tbKaf.Text.Contains(" ") || tbCorpus.Text.Contains(" ") || Convert.ToString(nuPlaces.Value) == "")
				MessageBox.Show("Заполните все поля");
			MAuditor Auditor = new MAuditor(tbAuditor.Text, tbKaf.Text, (ushort)nuPlaces.Value, Convert.ToByte(tbCorpus.Text));
			try
			{
				Controllers.CAuditor.Insert(Auditor);
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void tbAuditor_KeyPress(object sender, KeyPressEventArgs e)// Аудитория
		{
			if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == 8) return;
			else
				e.Handled = true;
		}

		private void tbKaf_KeyPress(object sender, KeyPressEventArgs e)// Кафедра
		{
			if (Char.IsLetter(e.KeyChar) || Convert.ToString(e.KeyChar) == " " || e.KeyChar == 8) return;
			else
				e.Handled = true;
		}

		private void tbCorpus_KeyPress(object sender, KeyPressEventArgs e)// Корпус
		{
			byte k;
			if (!(byte.TryParse(Convert.ToString(e.KeyChar), out k) || e.KeyChar == 8))
			{
				e.Handled = true;
			}
		}
	}
}
