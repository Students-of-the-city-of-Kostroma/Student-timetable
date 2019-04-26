using System;
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
	public partial class Institute : Form
	{
		public Institute()
		{
			InitializeComponent();
			DG_Institute.DataSource =Controllers.CInstitute.Select();
		}

		private void Add_Click(object sender, EventArgs e)
		{
			AddInstitute addInstitute = new AddInstitute();
			addInstitute.Show();
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			if (DG_Institute.Rows.Count == 0)
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
					DG_Institute.Rows.RemoveAt(DG_Institute.SelectedCells[0].RowIndex);
				}

			}
		}
	}
}
