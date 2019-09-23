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
    public partial class StudyWeek : Form
    {

        public StudyWeek()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
            DG.DataSource = RefData.CStudyWeek;
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
                    RefData.CStudyWeek.Delete(mStudyWeek);
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
            DataGridViewColumn newColumn = DG.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = DG.SortedColumn;
            ListSortDirection direction;

            if (DG.SelectedRows.Count == 0) return;
            DataRow Row = ((DataRowView)DG.SelectedRows[0]?.DataBoundItem)?.Row;
            if (Row == null) return;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    DG.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            //сохраняем номер выделенной строки
            List<object> arraySelectedRows = new List<object>();
            foreach (DataGridViewRow item in DG.SelectedRows)
            {
                arraySelectedRows.Add(item.DataBoundItem);
            }

            DG.Sort(newColumn, direction);

            foreach (DataGridViewRow item in DG.Rows)
            {
                if (arraySelectedRows.Contains(item.DataBoundItem))
                {
                    item.Selected = true;
                }
            }
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
