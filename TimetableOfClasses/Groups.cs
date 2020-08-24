using LibOfTimetableOfClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Groups : Form
    {
        public string ChoseGroupe;
        public Groups()
        {
            InitializeComponent();
            DG_Group.AutoGenerateColumns = false;
            DG_Group.DataSource = Program.refData.CGroup;
        }

        private void DeleteRow(object sender, EventArgs e)
        {
            if (DG_Group.SelectedRows.Count == 0) return;

            DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MGroup mGroup;
                foreach (DataGridViewRow row in DG_Group.SelectedRows)
                {
                    DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                    mGroup = new MGroup((string)Row["Group"], (ushort)Row["Semestr"], (string)Row["Specialty"], (ushort)Row["Shift"], (ushort)Row["Students"], (ushort)Row["MinNumberOfClass"], (ushort)Row["MaxNumberOfClass"], (string)Row["Weekends"]);
                    Program.refData.CGroup.Delete(mGroup);
                }
            }

        }

        private void AddRow(object sender, EventArgs e)
        {
            AddGroup addDiscipline = new AddGroup();
            addDiscipline.Owner = this;
            addDiscipline.Show();
        }

        private void Update(object sender, EventArgs e)
        {
            if (DG_Group.SelectedRows.Count == 1)
            {
                DataRow Row = ((DataRowView)DG_Group.SelectedRows[0].DataBoundItem).Row;
                MGroup mGroup = new MGroup((string)Row["Group"], (ushort)Row["Semestr"], (string)Row["Specialty"], (ushort)Row["Shift"], (ushort)Row["Students"], (ushort)Row["MinNumberOfClass"], (ushort)Row["MaxNumberOfClass"], (string)Row["Weekends"]);
                AddGroup addDiscipline = new AddGroup(mGroup);
                addDiscipline.Owner = this;
                addDiscipline.ShowDialog();
            }
            else if (DG_Group.SelectedRows.Count > 1) { MessageBox.Show("Для изменения выделите только одну строку!"); }
            else { MessageBox.Show("Для изменения выделите хотя бы одну строку !"); }
        }

        private void DG_Group_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = DG_Group.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = DG_Group.SortedColumn;
            ListSortDirection direction;

            if (DG_Group.SelectedRows.Count == 0) return;
            DataRow Row = ((DataRowView)DG_Group?.SelectedRows[0]?.DataBoundItem)?.Row;
            if (Row == null) return;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn &&
                    DG_Group.SortOrder == SortOrder.Ascending)
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
            foreach (DataGridViewRow item in DG_Group.SelectedRows)
            {
                arraySelectedRows.Add(item.DataBoundItem);
            }

            DG_Group.Sort(newColumn, direction);

            foreach (DataGridViewRow item in DG_Group.Rows)
            {
                if (arraySelectedRows.Contains(item.DataBoundItem))
                {
                    item.Selected = true;
                }
            }
        }

        private void DG_Group_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in DG_Group.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void DG_Group_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index + 1).ToString();
            object header = this.DG_Group.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.DG_Group.Rows[index].HeaderCell.Value = indexStr;
        }
        private void DG_Group_DoubleClick(object sender, EventArgs e)
        {
            if (DG_Group.SelectedRows.Count == 1 && this.Name == "Groups")
            {
                DataRow Row = ((DataRowView)DG_Group.SelectedRows[0].DataBoundItem).Row;
                ChoseGroupe = (string)Row["Group"];
                Close();
            }
        }
    }

}
