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
		private CUniversity University = RefData.CUniversity;
		private CTeacher Teacher = RefData.CTeacher;
		public AddInstitute()
		{
			InitializeComponent();
			update = false;
			VUS.DataSource = University;
			VUS.DisplayMember = "FullName";
			Director.DataSource = Teacher;
			Director.DisplayMember = "FullName";

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
			VUS.DataSource = University;
			VUS.DisplayMember = "FullName";
			VUS.Text = mInstitute.VUS;
			Director.DataSource = Teacher;
			Director.DisplayMember = "FullName";
			Director.Text = mInstitute.Director;
			update = true;
		}

		private void Open_University_Click(object sender, EventArgs e)
		{
			AddUniversity addUniversity = new AddUniversity();
			addUniversity.Show();
		}
		private void Open_Teacher_Click(object sender, EventArgs e)
		{
			AddTeacher addTeacher = new AddTeacher();
			addTeacher.Show();
		}
		private void btCreateAndClose_Click(object sender, EventArgs e)
		{


			if (update)
			{
				try
				{
					MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.Text);
					RefData.CInstitute.Update(Institute);
					FullName.Text = "";
					ShortName.Text = "";
					Director.Text = "";
					VUS.Text = "";
					Close();
				}
				catch (DeletedRowInaccessibleException)
				{
					MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
				}
				catch (Exception)
				{
					MessageBox.Show("Заполенены не все поля или заполнены некорректно!", "Ошибка", MessageBoxButtons.OK);
				}



			}
			else
			{


				try
				{
					MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.Text);
					RefData.CInstitute.Insert(Institute);
					FullName.Text = "";
					ShortName.Text = "";
					Director.Text = "";
					VUS.Text = "";
					Close();
				}
				catch (DeletedRowInaccessibleException)
				{
					MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
				}
				catch (Exception)
				{
					MessageBox.Show("Заполенены не все поля или заполнены некорректно!", "Ошибка", MessageBoxButtons.OK);
				}

			}
		}


		private void btCreateAndClean_Click(object sender, EventArgs e)
		{
			try
			{
				MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.Text);
				RefData.CInstitute.Insert(Institute);
				FullName.Text = "";
				ShortName.Text = "";
				Director.Text = "";
				VUS.Text = "";
			}
			catch (DeletedRowInaccessibleException)
			{
				MessageBox.Show("Невозможно получить доступ к удаленной информации строки через данную строку", "Ошибка");
			}
			catch (Exception)
			{
				MessageBox.Show("Заполенены не все поля или заполнены некорректно!", "Ошибка", MessageBoxButtons.OK);
			}

		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
