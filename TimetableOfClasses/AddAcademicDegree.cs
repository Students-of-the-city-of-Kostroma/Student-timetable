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
	public partial class AddAcademicDegree : Form
	{
		public AddAcademicDegree()
		{
			InitializeComponent();
			update = false;
		}
		bool update = false;

		public AddAcademicDegree(MAcademicDegree mAcademicDegree)
		{
			InitializeComponent();
			this.Text = "Изменение учёной степени";
			this.button1.Visible = false;
			this.button2.Text = "Изменить";
			this.Reduction.Enabled = false;
			FullName.Text = mAcademicDegree.FullName;
			Reduction.Text = mAcademicDegree.Reduction;
			update = true;
		}

		private void Button1_Click(object sender, EventArgs e)  // Создать и очистить
		{
			if ((Reduction.Text.Length != 0) || (FullName.Text.Length != 0))
			{
				if (Reduction.Text.Length != 0)
				{
					if (FullName.Text.Length != 0)
					{
							try
							{
								MAcademicDegree AcademicDegree = new MAcademicDegree(FullName.Text, Reduction.Text);
								Controllers.CAcademicDegree.Insert(AcademicDegree);
								FullName.Text = "";
								Reduction.Text = "";
							}
							catch (Exception)
							{
								MessageBox.Show("Некорректно заполнены поля", "Ошибка");
							}
					}
					else MessageBox.Show("Заполните полe 'Полная запись учёной степени'", "Попробуйте снова", MessageBoxButtons.OK);
				}
				else MessageBox.Show("Заполните полe 'Сокращённая запись учёной степени'", "Попробуйте снова", MessageBoxButtons.OK);
			}
			else MessageBox.Show("Заполните поля", "Попробуйте снова", MessageBoxButtons.OK);
		}

			private void Button2_Click(object sender, EventArgs e) //Создать и закрыть
		{

			if (update)
			{
				if ((Reduction.Text.Length != 0) || (FullName.Text.Length != 0))
				{
					if (Reduction.Text.Length != 0)
					{
						if (FullName.Text.Length != 0)
						{
								try
								{
									MAcademicDegree AcademicDegree = new MAcademicDegree(FullName.Text, Reduction.Text);
									Controllers.CAcademicDegree.Insert(AcademicDegree);
									FullName.Text = "";
									Reduction.Text = "";
									Close();
								}
								catch (Exception)
								{
									MessageBox.Show("Некорректно заполнены поля", "Ошибка");
								}
						}
						else MessageBox.Show("Заполните полe 'Полная запись учёной степени'", "Попробуйте снова", MessageBoxButtons.OK);
					}
					else MessageBox.Show("Заполните полe 'Сокращённая запись учёной степени'", "Попробуйте снова", MessageBoxButtons.OK);
				}
				else MessageBox.Show("Заполните поля", "Попробуйте снова", MessageBoxButtons.OK);
			}
			else
			{

				if ((Reduction.Text.Length != 0) || (FullName.Text.Length != 0))
				{
					if (Reduction.Text.Length != 0)
					{
						if (FullName.Text.Length != 0)
						{
							try
							{
								MAcademicDegree AcademicDegree = new MAcademicDegree(FullName.Text, Reduction.Text);
								Controllers.CAcademicDegree.Insert(AcademicDegree);
								FullName.Text = "";
								Reduction.Text = "";
								Close();
							}
							catch (Exception)
							{
								MessageBox.Show("Некорректно заполнены поля", "Ошибка");
							}
						}
						else MessageBox.Show("Заполните полe 'Полная запись учёной степени'", "Попробуйте снова", MessageBoxButtons.OK);
					}
					else MessageBox.Show("Заполните полe 'Сокращённая запись учёной степени'", "Попробуйте снова", MessageBoxButtons.OK);
				}
				else MessageBox.Show("Заполните поля", "Попробуйте снова", MessageBoxButtons.OK);
			}
		}

		private void Button3_Click(object sender, EventArgs e) //Отмена
		{
			this.Close();
		}

		private void Reduction_KeyPress(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != '-')
			{
				e.Handled = true;
			}
		}

		private void FullName_KeyPress(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != '-')
			{
				e.Handled = true;
			}
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
	}
}

