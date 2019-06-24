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
	public partial class AddStudyWeek : Form
	{
		private MStudyWeek Lehrer;

		public AddStudyWeek()
		{
			InitializeComponent();
		}

		private bool isEmpty(string[] strArgs)
		{
			foreach (var cur in strArgs)
			{
				if (cur.Length == 0)
				{
					return true;
				}
			}
			return false;
		}

		private void message()
		{
			MessageBox.Show("Заполните все пустые строки", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public AddStudyWeek(MStudyWeek mStudyWeek)
		{
			InitializeComponent();
			this.Text = "Изменение учебной недели";
			Lehrer = mStudyWeek;
			txtName.Text = Lehrer.Name;
			txtNumber.Text = Lehrer.Number.ToString();
		}

		private void createAndClose_Click(object sender, EventArgs e)
		{
			if (!isEmpty(new string[] {
				txtNumber.Text, txtName.Text}))
			{
				if (Add())
				{
					Close();
				}
			}
			else message();
		}

		private bool Add()
		{
			try
			{
				if (Lehrer == null)
				{
					string name = txtName.Text;
					int _number;
					if (int.TryParse(txtNumber.Text, out _number))
					{
						Lehrer = new MStudyWeek(_number, name);
						return RefData.CStudyWeek.Insert(Lehrer);
					}
					else MessageBox.Show("Номер должен являться числом", "Попробуйте снова");
				}
				else
				{
					Lehrer.Name = txtName.Text;
					int _number;
					if (int.TryParse(txtNumber.Text, out _number))
					{
						Lehrer.Number = _number;
						return RefData.CStudyWeek.Update(Lehrer);
					}
					else MessageBox.Show("Номер должен являться числом", "Попробуйте снова");
				}
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK);
			}
			return false;
		}

		private void B_Сancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
