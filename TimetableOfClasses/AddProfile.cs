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
	public partial class AddProfile : Form
	{
		bool itsupdate = false;
		public AddProfile()
		{
			InitializeComponent();
			itsupdate = false;
		}
		public AddProfile(MTrainingProfile mProfile)
		{
			InitializeComponent();
			Text = "Изменение профиля подготовки";
			bt_Cr_n_Cl.Visible = false;
			bt_Cr_n_Close.Text = "Сохранить";
			tbFullName.Text = mProfile.FullName;
			tbFullName.Enabled = false;
			tbShortName.Text = mProfile.ShortName;
			itsupdate = true;
		}
		private void btCancel_Click(object sender, EventArgs e)// отмена
		{
			Close();
		}

		private void bt_Cr_n_Cl_Click(object sender, EventArgs e)// создать и очистить
		{
			if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
				MessageBox.Show("Заполните все поля корректно");
			else
			{
				try
				{
					MTrainingProfile Profile = new MTrainingProfile(tbFullName.Text, tbShortName.Text);
					RefData.CTrainingProfile.Insert(Profile);
					tbFullName.Text = "";
					tbShortName.Text = "";
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void bt_Cr_n_Close_Click(object sender, EventArgs e)// создать и закрыть
		{
			if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
				MessageBox.Show("Заполните все поля корректно");
			else
			{
				try
				{
					MTrainingProfile Profile = new MTrainingProfile(tbFullName.Text, tbShortName.Text);
					if (!itsupdate)
						RefData.CTrainingProfile.Insert(Profile);
					else RefData.CTrainingProfile.Update(Profile);
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void tbFullName_Leave(object sender, EventArgs e)
		{
			var R = sender as TextBox;
			R.Text = Regex.Replace(R.Text, @"[^А-Яа-я ]", "");
			if (R.Text.Length != 0)
				R.Text = R.Text.First().ToString().ToUpper() + R.Text.Substring(1);

		}

		private void tbShortName_Leave(object sender, EventArgs e)
		{
			var R = sender as TextBox;
			R.Text = R.Text.ToUpper();
			R.Text = Regex.Replace(R.Text, @"[^А-Я]", "");
		}

		private void tbFullName_KeyPress(object sender, KeyPressEventArgs e)
		{
			Regex regex = new Regex(@"[а-яА-Я ]");
			if (!regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				return;
			}
		}

		private void tbShortName_KeyPress(object sender, KeyPressEventArgs e)
		{
			Regex regex = new Regex(@"[А-Яа-я]");
			if (!regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
				return;
			}
		}
	}
}
