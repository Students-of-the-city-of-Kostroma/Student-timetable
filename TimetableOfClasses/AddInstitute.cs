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


		private void fillingOutTheList()
		{
			for (int i = 0; i < Controllers.CUniversity.Rows.Count; i++)
				VUS.Items.Add(Controllers.CUniversity.Rows[i]["FullName"]);
		}

		public AddInstitute()
		{
			InitializeComponent();
			update = false;
			fillingOutTheList();
			
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
			fillingOutTheList();
			update = true;
		}

		private void btCreateAndClose_Click(object sender, EventArgs e)
		{
		

			if (update)
			{
				if ((ShortName.Text.Length != 0) && (FullName.Text.Length != 0) && (Director.Text.Length!=0))
				{
					if (isNumberDontContains(ShortName.Text) && isNumberDontContains(FullName.Text) &&(Director.Text.Length!=0))
					{
						try
						{
							MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.SelectedItem.ToString());
							Controllers.CInstitute.Update(Institute);
							FullName.Text = "";
							ShortName.Text = "";
							Director.Text = "";
							Close();
						}
						catch
						{
							MessageBox.Show("Выберите пожалуйста ВУЗ!", "Попробуйте снова", MessageBoxButtons.OK);
						}
					}
					else MessageBox.Show("Можно вводить только буквы", "Попробуйте снова");
				}
				else MessageBox.Show("Невозможно добавить этот институт!", "Попробуйте снова");
			}
			else
			{

				if ((ShortName.Text.Length != 0) && (FullName.Text.Length != 0)&&(Director.Text.Length!=0))
				{
					if (isNumberDontContains(ShortName.Text) && isNumberDontContains(FullName.Text)&&isNumberDontContains(Director.Text))
					{
						try
						{
							MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.SelectedItem.ToString());
							Controllers.CInstitute.Insert(Institute);
							FullName.Text = "";
							ShortName.Text = "";
							Director.Text = "";
							Close();
						}
						catch
						{
							MessageBox.Show("Выберите пожалуйста ВУЗ!", "Попробуйте снова", MessageBoxButtons.OK);
						}
					}
					else MessageBox.Show("Можно вводить только буквы", "Попробуйте снова");

				}
				else MessageBox.Show("Невозможно добавить этот институт!", "Попробуйте снова");
			}
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

		private void btCreateAndClean_Click(object sender, EventArgs e)
		{
			
			if ((ShortName.Text.Length != 0) && (FullName.Text.Length != 0) &&(Director.Text.Length!=0))
			{
				if (isNumberDontContains(ShortName.Text) && isNumberDontContains(FullName.Text) &&isNumberDontContains(Director.Text))
				{
					try
					{
						MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.SelectedItem.ToString());
						Controllers.CInstitute.Insert(Institute);
						FullName.Text = "";
						ShortName.Text = "";
						Director.Text = "";
					}
					catch
					{
						MessageBox.Show("Выберите пожалуйста ВУЗ!", "Попробуйте снова", MessageBoxButtons.OK);
					}
				}
				else MessageBox.Show("Можно вводить только буквы", "Попробуйте снова");
			}
			else MessageBox.Show("Невозможно добавить этот институт!", "Попробуйте снова", MessageBoxButtons.OK);
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
