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
using System.Diagnostics;

namespace TimetableOfClasses
{
	public partial class AddInstitute : Form
	{
		private CUniversity University = LibOfTimetableOfClasses.RefData.CUniversity;
		private CTeacher Teacher = LibOfTimetableOfClasses.RefData.CTeacher;
		public AddInstitute()
		{
			InitializeComponent();
			update = false;
			VUS.DataSource = University;
			VUS.DisplayMember = "FullName";
			Director.DataSource = Teacher;
			Director.DisplayMember = "FullName";

		}
		bool update = false;
		public AddInstitute(MInstitute mInstitute)
		{
			InitializeComponent();
			this.Text = "Изменение инстиута";
			this.btCreateAndClean.Visible = false;
			this.btCreateAndClose.Text = "Изменить";
			this.ShortName.Enabled = false;
			FullName.Text = mInstitute.FullName;
			ShortName.Text = mInstitute.ShortName;
			Director.Text = mInstitute.Director;
			VUS.DataSource = University;
			VUS.DisplayMember = "FullName";
			VUS.Text = mInstitute.VUS;
			Director.DataSource = Teacher;
			Director.DisplayMember = "FullName";
			Director.Text = mInstitute.Director;
			update = true;
		}

		private void Open_University_Click(object sender, EventArgs e)
		{
			AddUniversity addUniversity = new AddUniversity();
			addUniversity.Show();
		}
		private void Open_Teacher_Click(object sender, EventArgs e)
		{
			AddTeacher addTeacher = new AddTeacher();
			addTeacher.Show();
		}
		private void btCreateAndClose_Click(object sender, EventArgs e)
		{


			if (update)
			{
				try
				{
					MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.Text);
					LibOfTimetableOfClasses.RefData.CInstitute.Update(Institute);
					FullName.Text = "";
					ShortName.Text = "";
					Director.Text = "";
					VUS.Text = "";
					Close();
				}
				catch (DeletedRowInaccessibleException)
				{
					MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
				}
				catch (Exception)
				{
					MessageBox.Show("Заполенены не все поля или заполнены некорректно!", "Ошибка", MessageBoxButtons.OK);
				}



			}
			else
			{


				try
				{
					MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.Text);
					LibOfTimetableOfClasses.RefData.CInstitute.Insert(Institute);
					FullName.Text = "";
					ShortName.Text = "";
					Director.Text = "";
					VUS.Text = "";
					Close();
				}
				catch (DeletedRowInaccessibleException)
				{
					MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
				}
				catch (Exception)
				{
					MessageBox.Show("Заполенены не все поля или заполнены некорректно!", "Ошибка", MessageBoxButtons.OK);
				}

			}
		}



		private void btCreateAndClean_Click(object sender, EventArgs e)
		{


			try
			{
				MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.Text);
				LibOfTimetableOfClasses.RefData.CInstitute.Insert(Institute);
				FullName.Text = "";
				ShortName.Text = "";
				Director.Text = "";
				VUS.Text = "";
			}
			catch (DeletedRowInaccessibleException)
			{
				MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
			}
			catch (Exception)
			{
				MessageBox.Show("Заполенены не все поля или заполнены некорректно!", "Ошибка", MessageBoxButtons.OK);
			}

		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ShortName_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(ShortName.Text))
				errorProvider1.SetError(ShortName, "Пустое поле");

			if (!Regex.IsMatch(ShortName.Text, @"[А-Я]"))
				errorProvider1.SetError(ShortName, "Можно вводить только заглавные силволы русского алфавита");

			if (ShortName.Text.Length > 10)
				errorProvider1.SetError(ShortName, "Слишком длинное значение (не более 10)");

			if (ShortName.Text.Length <= 1)
				errorProvider1.SetError(ShortName, "Слишком короткое значение");
		}

		private void FullName_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(FullName.Text))
				errorProvider1.SetError(FullName, "Пустое поле");

			if (!Regex.IsMatch(FullName.Text, @"[А-Яа-я]"))
				errorProvider1.SetError(FullName, "Можно вводить только силволы русского алфавита");

			if (FullName.Text.Length > 50)
				errorProvider1.SetError(FullName, "Слишком длинное значение (не более 50)");

			if (FullName.Text.Length <= 1)
				errorProvider1.SetError(FullName, "Слишком короткое значение");
		}

		private void Director_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(Director.Text))
				errorProvider1.SetError(Director, "Пустое поле");
		}

		private void VUS_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(VUS.Text))
				errorProvider1.SetError(VUS, "Пустое поле");
		}

		private void ShortName_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}

		private void FullName_TextChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}

		private void Director_SelectedValueChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}

		private void VUS_SelectedValueChanged(object sender, EventArgs e)
		{
			errorProvider1.Clear();
		}

		private void FullName_Keypress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\"')
				e.Handled = true;
			else
				return;
		}
	}
}
