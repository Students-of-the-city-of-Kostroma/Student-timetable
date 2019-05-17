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
	public partial class TypesOfOccupations : Form
	{
		public TypesOfOccupations()
		{
			InitializeComponent();
            DG_TypesOfOccupations.AutoGenerateColumns = false;
            DG_TypesOfOccupations.DataSource = Controllers.CDiscipline;
        }

                private void DG_TypesOfOccupations_SelectionChanged(object sender, EventArgs e)
        {
            if (DG_TypesOfOccupations.SelectedCells.Count > 0)
            {
                btDelete.Enabled = true;
				btChange.Enabled = true;
			}
            else
            {
                btDelete.Enabled = false;
				btChange.Enabled = false;
			}
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string SelectedName = "";
            foreach (DataGridViewRow row in DG_TypesOfOccupations.SelectedRows)
            {
                DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                SelectedName += (string)Row["FullName"] + ", ";
            }
            if (SelectedName.Length > 2)
                SelectedName = SelectedName.Remove(SelectedName.Length - 2);
            DialogResult dr = MessageBox.Show("Удалить дисциплину - " + SelectedName + "?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DG_TypesOfOccupations.SelectedRows.Count > 0 && dr == DialogResult.OK)
            {
                int countSelected = DG_TypesOfOccupations.SelectedRows.Count;

                MTypesOfOccupations mTypesOfOccupations;
                foreach (DataGridViewRow row in DG_TypesOfOccupations.SelectedRows)
                {
                    DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                    mTypesOfOccupations = new MTypesOfOccupations((string)Row["FullName"], (string)Row["ShortName"]);
                    Controllers.CTypesOfOccupations.Delete(mTypesOfOccupations); 
                }
            }
        }
    }
}
