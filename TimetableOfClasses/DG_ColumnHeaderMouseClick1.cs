using LibOfTimetableOfClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TimetableOfClasses
{
	public class DG_ColumnHeader
	{
        public static void DG_Click(object sender, DataGridViewCellMouseEventArgs e,DataGridView DG)
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
    }
}
