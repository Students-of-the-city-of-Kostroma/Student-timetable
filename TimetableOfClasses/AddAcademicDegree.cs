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
			if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
			{
				if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
				{
					MAcademicDegree AcademicDegree = new MAcademicDegree(FullName.Text, Reduction.Text);
					Controllers.CAcademicDegree.Insert(AcademicDegree);
					FullName.Text = "";
					Reduction.Text = "";
				}
				else MessageBox.Show("Можно вводить только буквы и знаки: точка и тире", "Попробуйте снова");
			}
			else MessageBox.Show("Невозможно добавить это учёную степень", "Попробуйте снова", MessageBoxButtons.OK);
		}

		private void Button2_Click(object sender, EventArgs e) //Создать и закрыть
		{
			if (update)
			{
				if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
				{
					if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
					{
						MAcademicDegree AcademicDegree = new MAcademicDegree(FullName.Text, Reduction.Text);
						Controllers.CAcademicDegree.Update(AcademicDegree);
						FullName.Text = "";
						Reduction.Text = "";
						Close();
					}
					else MessageBox.Show("Можно вводить только буквы и знаки: точка и тире", "Попробуйте снова");
				}
				else MessageBox.Show("Невозможно добавить эту учёную степень", "Попробуйте снова");
			}
			else
			{

				if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
				{
					if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
					{
						MAcademicDegree AcademicDegree = new MAcademicDegree(FullName.Text, Reduction.Text);
						Controllers.CAcademicDegree.Insert(AcademicDegree);
						FullName.Text = "";
						Reduction.Text = "";
						Close();
					}
					else MessageBox.Show("Можно вводить только буквы и знаки: точка и тире", "Попробуйте снова");

				}
				else MessageBox.Show("Невозможно добавить эту учёную степень", "Попробуйте снова");
			}
		}

		private void Button3_Click(object sender, EventArgs e) //Отмена
		{
			this.Close();
		}
		static bool isNumberDontContains(string input)
		{
			foreach (char c in input)
				if (Char.IsNumber(c) || Char.IsPunctuation(c) || Char.IsSymbol(c))
				{
					if (c == '.')
						continue;
					return false;
				}
			return true;
		}
	}
}
