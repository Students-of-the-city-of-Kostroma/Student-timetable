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

		MAuditor mAuditor;
		private СEnclosures СEnclosures = Controllers.СEnclosures;

		public AddAuditor()
		{
			InitializeComponent();
			СEnclosures cEsourse = Controllers.СEnclosures;
			cbCorpus.DropDownStyle = ComboBoxStyle.DropDownList;
			foreach (DataRow row in cEsourse.Rows)
			{
				string s = Convert.ToString(row["Name"]);
				cbCorpus.Items.Add(s);
			}
			itsupdate = false;
		}
		byte a;
		bool itsupdate = false;
		public AddAuditor(MAuditor mAuditor)
		{
			InitializeComponent();
			this.Text = "Изменение аудитории";
			bt_Cr_n_Cl.Visible = false;
			bt_Cr_n_Close.Text = "Сохранить";
			tbAuditor.Text = mAuditor.NameOfAuditor;
			tbAuditor.Enabled = false;
			tbKaf.Text = mAuditor.Cafedra;
			cbCorpus.Text = Convert.ToString(mAuditor.Building);
			cbCorpus.Enabled = false;
			nuPlaces.Value = mAuditor.Spacious;
			itsupdate = true;
		}

		private void btCancel_Click(object sender, EventArgs e)// отмена
		{
			Close();
		}

		private void bt_Cr_n_Cl_Click(object sender, EventArgs e)// создать и очистить
		{
			if (String.IsNullOrWhiteSpace(tbAuditor.Text) || String.IsNullOrWhiteSpace(tbKaf.Text) || String.IsNullOrWhiteSpace(cbCorpus.Text) || String.IsNullOrWhiteSpace(cbCorpus.Text) || String.IsNullOrWhiteSpace(nuPlaces.Text) || nuPlaces.Value == 0)
				MessageBox.Show("Заполните все поля корректно");
			else
			{
				MAuditor Auditor = new MAuditor(tbAuditor.Text, tbKaf.Text, (ushort)nuPlaces.Value, cbCorpus.Text);
				try
				{
					if (!Controllers.CAuditor.Insert(Auditor))
					{
						MessageBox.Show("Невозможно добавить аудиторию");
						return;
					}
					tbAuditor.Text = "";
					tbKaf.Text = "";
					cbCorpus.Text = "";
					nuPlaces.Value = 1;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void bt_Cr_n_Close_Click(object sender, EventArgs e)// создать и закрыть
		{
			if (String.IsNullOrWhiteSpace(tbAuditor.Text) || String.IsNullOrWhiteSpace(tbKaf.Text) || String.IsNullOrWhiteSpace(cbCorpus.Text) || String.IsNullOrWhiteSpace(cbCorpus.Text) || String.IsNullOrWhiteSpace(nuPlaces.Text) || nuPlaces.Value == 0)
				MessageBox.Show("Заполните все поля корректно");
			else
			{
				MAuditor Auditor = new MAuditor(tbAuditor.Text, tbKaf.Text, (ushort)nuPlaces.Value, cbCorpus.Text);
				try
				{
					if (!itsupdate)
						{ if (!Controllers.CAuditor.Insert(Auditor))
						{
							MessageBox.Show("Невозможно добавить аудиторию");
							return;
						}
					}
					else Controllers.CAuditor.Update(Auditor);
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
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
