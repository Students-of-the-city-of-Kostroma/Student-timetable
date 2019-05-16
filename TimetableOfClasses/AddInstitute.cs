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
				try
				{
					MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.SelectedItem.ToString());
					Controllers.CInstitute.Update(Institute);
					FullName.Text = "";
					ShortName.Text = "";
					Director.Text = "";
					Close();
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
					MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.SelectedItem.ToString());
					Controllers.CInstitute.Insert(Institute);
					FullName.Text = "";
					ShortName.Text = "";
					Director.Text = "";
					Close();
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
				MInstitute Institute = new MInstitute(FullName.Text, ShortName.Text, Director.Text, VUS.SelectedItem.ToString());
				Controllers.CInstitute.Insert(Institute);
				FullName.Text = "";
				ShortName.Text = "";
				Director.Text = "";
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
