using LibOfTimetableOfClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace TimetableOfClasses
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DG.AutoGenerateColumns = false;
            DG.DataSource = Program.refData.CTeacher;
        }

        private void AddTeacher(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Create in Teacher");
                AddTeacher t = new AddTeacher();
                t.Show();
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);
            }
        }

        private void RemoveTeacher(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Delete in Teacher");
                //DG.Rows.RemoveAt(DG.SelectedCells[0].RowIndex);
                if (DG.SelectedRows.Count == 0) return;

                DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MTeacher mTeacher;

                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in DG.SelectedRows)
                    {
                        DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                        String[] fullName = ((string)Row["FullName"]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (fullName.Length == 3)
                            mTeacher = new MTeacher(fullName[1], fullName[0], fullName[2], (string)Row["AcademicDegree"], (string)Row["AcademicTitle"], (string)Row["Departament"], (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);
                        else mTeacher = new MTeacher(fullName[1], fullName[0], "", (string)Row["AcademicDegree"], (string)Row["AcademicTitle"], (string)Row["Departament"], (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);
                        Program.refData.CTeacher.Delete(mTeacher);
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);
            }
        }

        private void Update(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Change is Teacher");
                if (DG.SelectedRows.Count == 1)
                {
                    DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;
                    String[] fullName = ((string)Row["FullName"]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    MTeacher mTeacher;
                    if (fullName.Length == 3)
                    {
                        mTeacher = new MTeacher(fullName[1], fullName[0], fullName[2], (string)Row["AcademicDegree"], (string)Row["AcademicTitle"], (string)Row["Departament"], (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);
                    }
                    else
                    {
                        mTeacher = new MTeacher(fullName[1], fullName[0], "", (string)Row["AcademicDegree"], (string)Row["AcademicTitle"], (string)Row["Departament"], (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);
                    }
                    AddTeacher add = new AddTeacher(mTeacher);
                    add.Owner = this;
                    add.ShowDialog();
                }
                else if (DG.SelectedRows.Count > 1) { MessageBox.Show("Для изменения выделите только одну строку!"); }
                else { MessageBox.Show("Для изменения выделите хотя бы одну строку !"); }
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);
            }
        }

        private void DG_SelectionChanged(object sender, EventArgs e)
        {
            //button2.Enabled = ((DG.SelectedRows.Count > 0) && (DG.SelectedCells[0].RowIndex != DG.Rows.Count - 1));
        }
        Enclosures form = new Enclosures();
        /// <summary>
        /// Создаем объект form класса Enclosures для получения доступа к методу OurDG_ColumnHeaderMouseClick
        /// </summary>
        private void DG_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) // Создаем объект form класса Enclosures для получения доступа к методу OurDG_ColumnHeaderMouseClick
        {
            form.OurDG_ColumnHeaderMouseClick(e);  // Используем метод из класса Enclosures
        }
        /// <summary>
        /// Используем метод из класса Enclosures
        /// </summary>
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
