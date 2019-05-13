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
	public partial class AddProfile : Form
	{
		bool itsupdate = false;
		public AddProfile()
		{			
			InitializeComponent();
			cbFullName.Items.Clear();
			DirectionOfPreparation dpForm = new DirectionOfPreparation();
			cbFullName.DropDownStyle = ComboBoxStyle.DropDownList;
			foreach (DataGridViewRow row in dpForm.dgDirectionOfPreparation.Rows)
			{
				string s = row.Cells[1].Value.ToString();
				cbFullName.Items.Add(s);
			}
			itsupdate = false;
		}
		public AddProfile(MTrainingProfile mProfile)
		{
			InitializeComponent();
			Text = "Изменение профиля подготовки";
			bt_Cr_n_Cl.Visible = false;
			bt_Cr_n_Close.Text = "Сохранить";
			cbFullName.Text = mProfile.FullName;
			cbFullName.Enabled = false;
			tbShortName.Text = mProfile.ShortName;
			itsupdate = true;
		}
		private void btCancel_Click(object sender, EventArgs e)// отмена
		{
			Close();
		}

		private void bt_Cr_n_Cl_Click(object sender, EventArgs e)// создать и очистить
		{
			if (String.IsNullOrWhiteSpace(cbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
				MessageBox.Show("Заполните все поля корректно");
			else
			{
				MTrainingProfile Profile = new MTrainingProfile(cbFullName.Text, tbShortName.Text);
				try
				{
					if (!Controllers.CTrainingProfile.Insert(Profile))
					{
						MessageBox.Show("Невозможно добавить профиль подготовки");
						return;
					}
					cbFullName.Text = "";
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
			if (String.IsNullOrWhiteSpace(cbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text))
				MessageBox.Show("Заполните все поля корректно");
			else
			{
				MTrainingProfile Profile = new MTrainingProfile(cbFullName.Text, tbShortName.Text);
				try
				{
					if (!itsupdate)
					{
						if (!Controllers.CTrainingProfile.Insert(Profile))
						{
							MessageBox.Show("Невозможно добавить профиль подготовки");
							return;
						}
					}
					else Controllers.CTrainingProfile.Update(Profile);
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
