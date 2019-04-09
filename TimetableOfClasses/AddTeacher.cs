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
		private MTeacher Lehrer;

		public AddTeacher()
		{
			InitializeComponent();
			firstName.Text = "Иван";
			secondName.Text = "Иванов";
			patronymic.Text = "Иванович";
			department.Text = "ФАСТ";
			metodDays.Text = "Пн, Вт";
			windows.Text = "Ср, Чт, Пт";
			weekends.Text = "Сб, Вс";
		}

		public AddTeacher(MTeacher mTeacher)
		{
			InitializeComponent();
			this.Text = "Изменение преподавателя";			
			string[] split = mTeacher.FullName.Split(' ');

			#region(FullName)

			firstName.Text = split[1];
			firstName.Enabled = false;

			secondName.Text = split[0];
			secondName.Enabled = false;

			patronymic.Text = split[2];
			patronymic.Enabled = false;

			#endregion

			notes.Text = mTeacher.Note;

			department.Text = mTeacher.Departament;
			department.Enabled = false;

			metodDays.Text = mTeacher.MetodicalDays;

			windows.Text = mTeacher.Windows;

			weekends.Text = mTeacher.Weekends;

			Lehrer = mTeacher;


		}

		private void createAndClose_Click(object sender, EventArgs e)
		{
			if (Add())
			{
				Close();
			}
			else MessageBox.Show("Новозможно добавить этого преподавателя", "Попробуйте снова");			
		}

		private bool Add()
		{
			if (Lehrer == null)
			{
				string fullName = secondName.Text + " " + firstName.Text + " " + patronymic.Text;
				MTeacher Prepodavatel = new MTeacher(fullName, notes.Text, department.Text, metodDays.Text, windows.Text, weekends.Text);
				return Controllers.CTeacher.Insert(Prepodavatel);
			}
			else
			{

				string fullName = secondName.Text + " " + firstName.Text + " " + patronymic.Text;
				Lehrer.FullName = fullName;
				Lehrer.Note = notes.Text;
				Lehrer.Departament = department.Text;
				Lehrer.MetodicalDays = metodDays.Text;
				Lehrer.Windows = windows.Text;
				Lehrer.Weekends = weekends.Text;
				return Controllers.CTeacher.Update(Lehrer);					
			}
		}

		/// <summary>
		/// Здесь должны быть комментарии
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddTeacher_Load(object sender, EventArgs e)
		{
			
		}

		private void SelectionOfLetters1(object sender, EventArgs e)
		{
			TextBox R = sender as TextBox;
			R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
			R.Text = Regex.Replace(R.Text, "[, ]+", ", ");
			if (R.Text.Length > 2)
			{
				if (R.Text.IndexOf(", ") == 0)
					R.Text = R.Text.Substring(1);
				if (R.Text.LastIndexOf(", ") == R.Text.Length - 1)
					R.Text = R.Text.Remove(R.Text.Length - 1);
				R.Text = R.Text.ToLower();
				R.Text = PeriodLetterToUpper(R.Text);
			}

		}

		private void SelectionOfLetters2(object sender, EventArgs e)
		{
			TextBox R = sender as TextBox;
			R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
			R.Text = Regex.Replace(R.Text, "[ ]+", " ");
			if(R.Text.Length > 2)
			{
				if (R.Text.IndexOf(" ") == 0)
					R.Text = R.Text.Substring(1);
				if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
					R.Text = R.Text.Remove(R.Text.Length - 1);
				R.Text = R.Text.ToLower();
				R.Text = FirstLetterToUpper(R.Text);
			}
		}

		private void SelectionOfLetters3(object sender, EventArgs e)
		{
			TextBox R = sender as TextBox;
			R.Text = Regex.Replace(R.Text, "[^а-яА-Я ]", "");
			R.Text = Regex.Replace(R.Text, "[ ]+", " ");
			if (R.Text.Length > 2)
			{
				if (R.Text.IndexOf(" ") == 0)
					R.Text = R.Text.Substring(1);
				if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
					R.Text = R.Text.Remove(R.Text.Length - 1);
				R.Text = R.Text.ToUpper();
			}
		}

		private void SelectionOfLetters4(object sender, EventArgs e)
		{
			TextBox R = sender as TextBox;
			R.Text = Regex.Replace(R.Text, "[^0-9а-яА-Я-, ]", "");
			R.Text = Regex.Replace(R.Text, "[ ]+", " ");
			if (R.Text.Length > 2)
			{
				if (R.Text.IndexOf(" ") == 0)
					R.Text = R.Text.Substring(1);
				if (R.Text.LastIndexOf(" ") == R.Text.Length - 1)
					R.Text = R.Text.Remove(R.Text.Length - 1);
				R.Text = R.Text.ToLower();
				R.Text = FirstLetterToUpper(R.Text);
			}
		}

		private static string FirstLetterToUpper(string str)
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

		private static string PeriodLetterToUpper(string str)
		{
			if (str.Length > 0)
			{
				if (str.IndexOf(",") > 0)
				{
					char p;
					str = Char.ToUpper(str[0]) + str.Substring(1);
					for (int i=0; i < str.Length; i++)
					{   
						if(str[i] == ',')
						{
							p = Char.ToUpper(str[i + 2]);
							str = str.Remove(i + 2, 1);
							str = str.Insert(i + 2, ""+p);
						}
					}
					return str;
				}
				else
					return Char.ToUpper(str[0]) + str.Substring(1);
			}
			return "";
		}



		private void KeyPress1(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' )
			{
				e.Handled = true;
			}
		}

		private void KeyPress2(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' && l != '-' && l != ' '  && l != ',' && (l < '0' || l > '9'))
			{
				e.Handled = true;
			}
		}

		private void KeyPress3(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
			{
				e.Handled = true;
			}
			e.Handled = false;
		}

		private void B_Сancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}