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
	public partial class AddAcademicTitle : Form
	{


		public AddAcademicTitle()
		{
			InitializeComponent();
			update = false;
		}
		bool update = false;
		public AddAcademicTitle(MTitle mTitle)
		{
			InitializeComponent();
			this.Text = "Изменение уч. звания";
			this.btCreateAndClean.Visible = false;
			this.btCreateAndClose.Text = "Изменить";
			this.Reduction.Enabled = false;
			FullName.Text = mTitle.FullName;
			Reduction.Text = mTitle.Reduction;
			update = true;
		}

		private void btCreateAndClose_Click(object sender, EventArgs e)
		{
			if (update)
			{
				if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
				{
					if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
					{
						try
						{
							MTitle Title = new MTitle(FullName.Text, Reduction.Text);
							Controllers.CTitle.Update(Title);
							FullName.Text = "";
							Reduction.Text = "";
							Close();
						}
						catch (DeletedRowInaccessibleException)
						{
							MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
						}

						catch (Exception)
						{
							MessageBox.Show("Некорректно заполнены поля", "Ошибка");
						}

					}
					else MessageBox.Show("Можно вводить только буквы и знаки: точка и тире", "Попробуйте снова");
				}
				else MessageBox.Show("Невозможно добавить это уч. звание", "Попробуйте снова");
			}
			else
			{

				if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
				{
					if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
					{
						try
						{
							MTitle Title = new MTitle(FullName.Text, Reduction.Text);
							Controllers.CTitle.Insert(Title);
							FullName.Text = "";
							Reduction.Text = "";
							Close();
						}
						catch (DeletedRowInaccessibleException)
						{
							MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
						}
						catch (Exception)
						{
							MessageBox.Show("Некорректно заполнены поля", "Ошибка");
						}
					}
					else MessageBox.Show("Можно вводить только буквы и знаки: точка и тире", "Попробуйте снова");

				}
				else MessageBox.Show("Невозможно добавить это уч. звание", "Попробуйте снова");
			}
		}

		private void btCreateAndClean_Click(object sender, EventArgs e)
		{

			if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
			{
				if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
				{
					try
					{
						MTitle Title = new MTitle(FullName.Text, Reduction.Text);
						Controllers.CTitle.Insert(Title);
						FullName.Text = "";
						Reduction.Text = "";
					}
					catch (DeletedRowInaccessibleException)
					{
						MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
					}

					catch (Exception)
					{
						MessageBox.Show("Некорректно заполнены поля", "Ошибка");
					}
				}
				else MessageBox.Show("Можно вводить только буквы и знаки: точка и тире", "Попробуйте снова");
			}
			else MessageBox.Show("Невозможно добавить это уч. звание!", "Попробуйте снова", MessageBoxButtons.OK);
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		static bool isNumberDontContains(string input)
		{
			foreach (char c in input)
				if (Char.IsNumber(c) || Char.IsPunctuation(c) || Char.IsSymbol(c))
				{
					if (c == '.' || c == '-')
						continue;
					return false;
				}
			return true;
		}

		private void Reduction_TextChanged(object sender, EventArgs e)
		{
			if (((TextBox)sender).Text.Length == 1)
				((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
			((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);

		}

		private void FullName_TextChanged(object sender, EventArgs e)
		{
			if (((TextBox)sender).Text.Length == 1)
				((TextBox)sender).Text = ((TextBox)sender).Text.ToUpper();
			((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
		}

		private void Reduction_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(FullName.Text))
				errorProvider1.SetError(FullName, "Пустое поле");

			if (!Regex.IsMatch(Reduction.Text, @"[А-Яа-я\-\' ']"))
				errorProvider1.SetError(Reduction, "Можно вводить только силволы русского алфавита и тире");

			if (Reduction.Text.Length > 25)
				errorProvider1.SetError(Reduction, "Слишком длинное значение (не более 25)");

		}

		private void FullName_Validating(object sender, CancelEventArgs e)
		{
			if (String.IsNullOrEmpty(FullName.Text))
				errorProvider1.SetError(FullName, "Пустое поле");

			if (!Regex.IsMatch(FullName.Text, @"[А-Яа-я\-\' ']"))
				errorProvider1.SetError(FullName, "Можно вводить только силволы русского алфавита и тире");

			if (FullName.Text.Length > 25)
				errorProvider1.SetError(FullName, "Слишком длинное значение (не более 25)");

		}
	}
}
