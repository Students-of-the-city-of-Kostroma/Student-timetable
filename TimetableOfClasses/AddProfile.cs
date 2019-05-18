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
		public string codeSpec;
		bool itsupdate = false;
		public AddProfile()
		{			
			InitializeComponent();
			//cbFullName.Items.Clear();
			//DirectionOfPreparation dpForm = new DirectionOfPreparation();
			//cbFullName.DropDownStyle = ComboBoxStyle.DropDownList;
			//foreach (DataGridViewRow row in dpForm.dgDirectionOfPreparation.Rows)
			//{
			//	string s = row.Cells[1].Value.ToString();
			//	cbFullName.Items.Add(s);
			//}
			itsupdate = false;
		}
		public AddProfile(MTrainingProfile mProfile)
		{
			InitializeComponent();
			tbCodeSpec.ReadOnly = true;
			Text = "Изменение профиля подготовки";
			bt_Cr_n_Cl.Visible = false;
			bt_Cr_n_Close.Text = "Сохранить";
			tbFullName.Text = mProfile.FullName;
			tbFullName.Enabled = false;
			tbShortName.Text = mProfile.ShortName;
			tbCodeSpec.Text = mProfile.Shiphr;
			itsupdate = true;
		}
		private void btCancel_Click(object sender, EventArgs e)// отмена
		{
			Close();
		}

		private void bt_Cr_n_Cl_Click(object sender, EventArgs e)// создать и очистить
		{
			if (String.IsNullOrWhiteSpace(tbFullName.Text) || String.IsNullOrWhiteSpace(tbShortName.Text) || String.IsNullOrWhiteSpace(tbCodeSpec.Text))
				MessageBox.Show("Заполните все поля корректно");
			else
			{
				MTrainingProfile Profile = new MTrainingProfile(tbFullName.Text, tbShortName.Text, tbCodeSpec.Text);
				try
				{
					if (!Controllers.CTrainingProfile.Insert(Profile))
					{
						MessageBox.Show("Невозможно добавить профиль подготовки");
						return;
					}
					tbFullName.Text = "";
					tbShortName.Text = "";
					tbCodeSpec.Text = "";
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
				MTrainingProfile Profile = new MTrainingProfile(tbFullName.Text, tbShortName.Text, tbCodeSpec.Text);
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

		private void btCodeSpec_Click(object sender, EventArgs e)
		{
			DirectionOfPreparation selectCode = new DirectionOfPreparation(true);
			selectCode.Owner = this;
			selectCode.ShowDialog();
			tbCodeSpec.Text = codeSpec;
		}
	}
}
