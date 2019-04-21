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
			FullName.Text = mTitle.FullName;
			Reduction.Text = mTitle.Reduction;
			update = true;
		}

		private void btCreateAndClose_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(FullName.Text) || String.IsNullOrWhiteSpace(Reduction.Text))
				MessageBox.Show("Заполните все поля");
			else
			{
				MTitle mtitle = new MTitle(FullName.Text, Reduction.Text);
				try
				{
					if (!update)
						Controllers.CTitle.Insert(mtitle);
					else Controllers.CTitle.Update(mtitle);
					Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

		}

		private void btCreateAndClean_Click(object sender, EventArgs e)
		{

			if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
			{
				if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
				{
					MTitle Title = new MTitle(FullName.Text, Reduction.Text);
					Controllers.CTitle.Insert(Title);
					FullName.Text = "";
					Reduction.Text = "";
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


	}
}
