using LibOfTimetableOfClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class StudyWeek : Form
    {

        public StudyWeek()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
            DG.DataSource = Program.refData.CStudyWeek;
        }

        private void AddStudyWeek(object sender, EventArgs e)
        {
            AddStudyWeek t = new AddStudyWeek();
            t.Show();
        }

        private void RemoveStudyWeek(object sender, EventArgs e)
        {
            //DG.Rows.RemoveAt(DG.SelectedCells[0].RowIndex);
            if (DG.SelectedRows.Count == 0) return;

            DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MStudyWeek mStudyWeek;
            if (dr == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in DG.SelectedRows)
                {
                    DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                    int number = int.Parse(Row["Number"].ToString());
                    String name = Row["Name"].ToString();
                    mStudyWeek = new MStudyWeek(number, name);
                    Program.refData.CStudyWeek.Delete(mStudyWeek);
                }
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if (DG.SelectedRows.Count == 1)
            {
                DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;
                MStudyWeek mStudyWeek;

                mStudyWeek = new MStudyWeek(int.Parse(Row["Number"].ToString()), Row["Name"].ToString());

                AddStudyWeek add = new AddStudyWeek(mStudyWeek);
                add.Owner = this;
                add.ShowDialog();
            }
            else if (DG.SelectedRows.Count > 1) { MessageBox.Show("Для изменения выделите только одну строку!"); }
            else { MessageBox.Show("Для изменения выделите хотя бы одну строку !"); }
        }

        private void DG_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DG_ColumnHeader.DG_Click(sender, e, DG);
        }

        private void DG_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in DG.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void DG_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.DG.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.DG.Rows[index].HeaderCell.Value = indexStr;
        }
    }
}
