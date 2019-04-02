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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
			//привязываем таблицу контроллера CTeacher
			//DG.AutoGenerateColumns = false;
			DG.DataSource = Controllers.CTeacher.Select();
			var dt = Controllers.CTeacher.Select();
			for(int i = 1; i < dt.Columns.Count; i++) { 
				DG.Columns[i].HeaderText = dt.Columns[i].Caption;
			}
		}

        private void AddTeacher(object sender, EventArgs e)
        {
			AddTeacher t = new AddTeacher();
             t.ShowDialog();
        }

        private void RemoveTeacher(object sender, EventArgs e)
        {
            //DG.Rows.RemoveAt(DG.SelectedCells[0].RowIndex);

			if(DG.SelectedRows.Count>0)
			{
				MTeacher mTeacher;
				foreach(DataGridViewRow row in DG.SelectedRows)
				{
					DataRow Row = ((DataRowView)row.DataBoundItem).Row;
					mTeacher = new MTeacher((string)Row["FullName"], (string)Row["Departament"]);
					Controllers.CTeacher.Delete(mTeacher);
				}
			}
        }

        private void DG_SelectionChanged(object sender, EventArgs e)
        {
            //button2.Enabled = ((DG.SelectedRows.Count > 0) && (DG.SelectedCells[0].RowIndex != DG.Rows.Count - 1));
        }

    }
}
