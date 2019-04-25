using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibOfTimetableOfClasses;

namespace TimetableOfClasses
{
	public partial class AcademicTitle : Form
	{
		public AcademicTitle()
		{
			InitializeComponent();
			DG_AcademicTitle.DataSource = Controllers.CTitle.Select();
		}


		private void DG_AcademicTitle_SelectionChanged(object sender, EventArgs e)
		{
			if (DG_AcademicTitle.SelectedCells.Count > 0)
			{
				Delete.Enabled = true;
			}
			else
			{
				Delete.Enabled = false;
			}
		}

		private void Add_Click(object sender, System.EventArgs e)
		{
			AddAcademicTitle addAcademicTitle = new AddAcademicTitle();
			addAcademicTitle.ShowDialog();
		}

		private void Delete_Click(object sender, System.EventArgs e)
		{
			if (DG_AcademicTitle.Rows.Count == 0)
			{
				MessageBox.Show("Таблица пуста", "Предупреждение");
			}
			else
			{
					string message = "Вы уверны что хотите удалить уч. звание?";
					string caption = "Подтверждение удаления";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult result;

					result = MessageBox.Show(message, caption, buttons);
					if (result == System.Windows.Forms.DialogResult.Yes)
					{
						DG_AcademicTitle.Rows.RemoveAt(DG_AcademicTitle.SelectedCells[0].RowIndex);
					}
				
			}
		}
	}
}



