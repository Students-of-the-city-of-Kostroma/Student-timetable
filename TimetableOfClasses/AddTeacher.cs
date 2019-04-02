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
	public partial class AddTeacher : Form
	{
		public AddTeacher()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
				string fullName = secondName.Text + " " + firstName.Text + " " + patronymic.Text;
				MTeacher Prepodavatel = new MTeacher(fullName,notes.Text, department.Text, metodDays.Text, windows.Text, weekends.Text);
					if (Controllers.CTeacher.Insert(Prepodavatel))
						Close();
					else MessageBox.Show("Новозможно добавить этого преподавателя", "Попробуйте снова");
				
		}
		/// <summary>
		/// Здесь должны быть комментарии
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddTeacher_Load(object sender, EventArgs e)
		{
			firstName.Text = "Иван";
			secondName.Text = "Иванов";
			patronymic.Text = "Иванович";
			department.Text = "фаст";
			metodDays.Text = "методические дни";
			windows.Text = "окна";
			weekends.Text = "Выходные";
		}

		private void SelectionOfLetters1(object sender, EventArgs e)
		{
			TextBox R = sender as TextBox;
			R.Text = Regex.Replace(R.Text, "[^а-яА-Я- ]", "");
			R.Text = Regex.Replace(R.Text, "[ ]", "-");
			R.Text = Regex.Replace(R.Text, "[-]+", "-");
			if (R.Text.IndexOf("-") == 0)
				R.Text = R.Text.Substring(1);
			if (R.Text.LastIndexOf("-") == R.Text.Length - 1)
				R.Text = R.Text.Remove(R.Text.Length - 1);
			R.Text = R.Text.ToLower();
			R.Text = FirstLetterToUpper(R.Text);

		}

		private void SelectionOfLetters2(object sender, EventArgs e)
		{
			TextBox R = sender as TextBox;
			R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
			R.Text = Regex.Replace(R.Text, "[ ]+", " ");
			if (R.Text.IndexOf(" ") == 0)
				R.Text = R.Text.Substring(1);
			if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
				R.Text = R.Text.Remove(R.Text.Length - 1);
			R.Text = R.Text.ToLower();
			R.Text = FirstLetterToUpper(R.Text);
		}

		public static string FirstLetterToUpper(string str)
		{
			if (str.Length > 0)
			{
				if (str.IndexOf("-") > 0)
				{
					return Char.ToUpper(str[0]) + str.Substring(1, str.IndexOf("-")) + Char.ToUpper(str[str.IndexOf("-") + 1]) + str.Substring(str.IndexOf("-") + 2);
				}
				else
					return Char.ToUpper(str[0]) + str.Substring(1);
			}
			return "";
		}


		private void KeyPress1(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' && l != '-')
			{
				e.Handled = true;
			}
		}

		private void KeyPress2(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
			{
				e.Handled = true;
			}
		}

		private void KeyPressNumber(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
			{
				e.Handled = true;
			}
		}

		private void B_Сancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void B_Cr_n_Cl_Click(object sender, EventArgs e)
		{
			string fullName = secondName.Text+" "+ firstName.Text + " " + patronymic.Text;
			MTeacher Prepodavatel = new MTeacher(fullName, notes.Text, department.Text, metodDays.Text, windows.Text, weekends.Text);
			if (Controllers.CTeacher.Insert(Prepodavatel))
				{
				firstName.Text = "";
				secondName.Text = "";
				patronymic.Text = "";
				department.Text = "фаст";
				metodDays.Text = "";
				windows.Text = "";
				weekends.Text = "";
			}
				else MessageBox.Show("Новозможно добавить этого преподавателя", "Попробуйте снова");			
		}
	}
}