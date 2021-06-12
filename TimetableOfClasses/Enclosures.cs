using LibOfTimetableOfClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Enclosures : Form
    {
        public string selectEnclosures;

        public Enclosures(bool forChoice = false)
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
            DG.DataSource = Program.refData.CEnclosures;
            if (forChoice)
            {
                Name = "Выбор корпуса";
            }
        }

        public void DG_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DG_ColumnHeaderMouseClick1.DG_Click1(sender, e, DG);
        }

        private void DG_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.DG.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.DG.Rows[index].HeaderCell.Value = indexStr;
        }

        private void DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in DG.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }

        }

        private void Deletet(object sender, EventArgs e)
        {
            if (DG.SelectedRows.Count == 0) return;
            DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MEnclosures mEnclosures;
                foreach (DataGridViewRow row in DG.SelectedRows)
                {
                    DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                    mEnclosures = new MEnclosures((string)Row["Name"], (string)Row["University"], (string)Row["Adress"], (string)Row["Phone"], (string)Row["Comment"]);
                    Program.refData.CEnclosures.Delete(mEnclosures);
                }
            }
        }

        private void Updatet(object sender, EventArgs e)
        {
            if (DG.SelectedRows.Count == 1)
            {
                DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;
                MEnclosures mEnclosures = new MEnclosures((string)Row[0], (string)Row[1], (string)Row[2], (string)Row[3], (string)Row[4]);
                AddEnclosures addEnclosures = new AddEnclosures(mEnclosures);
                addEnclosures.Owner = this;
                addEnclosures.ShowDialog();
            }
            else if (DG.SelectedRows.Count > 1) { MessageBox.Show("Для изменения выделите только одну строку!"); }
            else { MessageBox.Show("Для изменения выделите хотя бы одну строку !"); }
        }

        private void Added(object sender, EventArgs e)
        {
            AddEnclosures addEnclosures = new AddEnclosures();
            addEnclosures.Owner = this;
            addEnclosures.Show();
        }

        private void DG_DoubleClick(object sender, EventArgs e)
        {
            if (Name == "Выбор корпуса")
            {
                DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;
                selectEnclosures = (string)Row["Name"];
                Close();
            }
        }
    }
}
