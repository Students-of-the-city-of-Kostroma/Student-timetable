	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Diagnostics;
	using System.Threading.Tasks;
	using System.Windows.Forms;
	using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
	public partial class AddAcademicTitle : Form
	{

		private MTitle title;
		Random rand = new Random();
		public AddAcademicTitle()
		{
			InitializeComponent();
			Code.Text = Convert.ToString(rand.Next(100));
			
		}
		public AddAcademicTitle(MTitle mTitle)
		{
			InitializeComponent();
			this.Text = "Изменение уч. звания";
			this.btCreateAndClean.Visible = false;
			this.btCreateAndClose.Text = "Изменить";
			this.Code.Enabled = false;
			FullName.Text = mTitle.FullName;
			Reduction.Text = mTitle.Reduction;
			Code.Text = Convert.ToString(mTitle.Code);
			title = mTitle;
		}



		private void btCreateAndClose_Click(object sender, EventArgs e)
		{
			if (Add())
			{
				Close();
			}
			
		}

		private bool Add()
		{
			if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
			{
				if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
				{
					if (title == null)
					{
						try
						{
							MTitle Title = new MTitle(FullName.Text, Reduction.Text, Convert.ToInt32(Code.Text));
							Controllers.CTitle.Insert(Title);
							return true;

						}
						catch(FormatException)
						{
							MessageBox.Show("Недопустимые знаки", "Попробуйте еще раз", MessageBoxButtons.OK);
							return false;
						}
					}
					else
					{
						title.Reduction = Reduction.Text;
						title.FullName = FullName.Text;
						Controllers.CTitle.Update(title);
						return true;
					}
				}
				else
				{
					MessageBox.Show("Недопустимые знаки", "Попробуйте еще раз", MessageBoxButtons.OK);
					return false;
				}

				
			}
			else
			{
				MessageBox.Show("Пустые поля", "Попробуйте еще раз", MessageBoxButtons.OK);
				return false;
			}
		}

		private void btCreateAndClean_Click(object sender, EventArgs e)
		{

			if ((Reduction.Text.Length != 0) && (FullName.Text.Length != 0))
			{
				if (isNumberDontContains(Reduction.Text) && isNumberDontContains(FullName.Text))
				{
					
					MTitle Title = new MTitle(FullName.Text, Reduction.Text, Convert.ToInt32(Code.Text));
					Controllers.CTitle.Insert(Title);
					FullName.Text = "";
					Reduction.Text = "";
					Code.Text = Convert.ToString(rand.Next(100));

				}
				else MessageBox.Show("Недопустимые знаки", "Попробуйте снова", MessageBoxButtons.OK);
			}
			else MessageBox.Show("Пустые поля", "Попробуйте снова", MessageBoxButtons.OK);
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
					if (c == '.')
						continue;
					return false;
				}
			return true;
		}

		private void AddAcademicTitle_Load(object sender, EventArgs e)
		{

		}
	}
}
