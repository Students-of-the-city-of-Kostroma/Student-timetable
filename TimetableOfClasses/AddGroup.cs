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
	public partial class AddGroup : Form
	{
		public AddGroup()
		{
			InitializeComponent();
		}

		private void B_Сancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void createAndClose_Click(object sender, EventArgs e)
		{
			if (Add())
				Close();
		}

		private void createAndClear_Click(object sender, EventArgs e)
		{
			if (Add())
			{
				nudSemest.Value = 1;
				nudSmena.Value = 1;
				nudMinPar.Value = 0;
				nudMaxPar.Value = 0;
				nudCountStudents.Value = 0;
				tbNameGroup.Text = "00-AAaa-0a";
				tbVixodnie.Text = "Воскресенье";
				tbNaprav.Text = "-";
			}
		}

		private bool Add()
		{
			string errors = "";
			ushort semest, smena, countStudents, minPar, maxPar;
			if (ushort.TryParse(nudSemest.Value.ToString(), out semest) && semest <= 8 && semest > 0)
				if (ushort.TryParse(nudSmena.Value.ToString(), out smena) && smena <= 4 && smena > 0)
					if (ushort.TryParse(nudCountStudents.Value.ToString(), out countStudents))
						if (ushort.TryParse(nudMinPar.Value.ToString(), out minPar))
							if (ushort.TryParse(nudMaxPar.Value.ToString(), out maxPar))
							{
								MGroup Group = new MGroup(tbNameGroup.Text, semest, tbNaprav.Text, smena, countStudents, minPar, maxPar, tbVixodnie.Text);
								if (Controllers.CGroup.Insert(Group))
									return true;
								else errors += "Новозможно добавить эту группу";
							}
							else errors = "Введите корректное максимальное количество пар!";
						else errors = "Введите корректное минимальное количество пар!";
					else errors = "Введите корректное количество студентов!";
				else errors = "Введите корректную смену! (1-4)";
			else errors = "Введите корректный семестр! (1-8)";
			if (errors != "") MessageBox.Show(errors, "Попробуйте еще раз");
			return false;
		}



		private void KeyPress1(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' && l != '-' && (l < '0' || l > '9'))
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

		private void KeyPress3(object sender, KeyPressEventArgs e)
		{
			char l = e.KeyChar;
			if ((l < 'А' || l > 'я') && l != '\b' && l != ' ' && l != ',')
			{
				e.Handled = true;
			}
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

		public static string FirstLetterToUpper(string str)
		{
			if (str.Length > 0)
			{
				return Char.ToUpper(str[0]) + str.Substring(1);
			}
			return "";
		}

		private void AddGroup_Load(object sender, EventArgs e)
		{
			tbNameGroup.Text = "00-AAaa-0a";
			tbVixodnie.Text = "Воскресенье";
			tbNaprav.Text = "-";
		}

	}
}
