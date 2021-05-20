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
                Logs.GetInfo("Click button Create in Teacher"); //Выводим сообщение "нажмите кнопку, чтобы добавить нового учителя"
                AddTeacher t = new AddTeacher();//Создаём экземпляр объекта - добавление учителя
                t.Show();//Выводим объект на экран
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);//Если ловим ошибку, то добавляем в логи ошибку
            }
        }

        private void RemoveTeacher(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Delete in Teacher");//Выводим сообщние об удалении учителя
                //DG.Rows.RemoveAt(DG.SelectedCells[0].RowIndex);
                if (DG.SelectedRows.Count == 0) return;//Если нет учителей, то ничего не делаем

                DialogResult dr = MessageBox.Show("Вы точно хотите удалить выделенный ряд(ы)", "Уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Подтверждение удаления
                MTeacher mTeacher;//Создаём объекты типа MTeacher

                if (dr == DialogResult.Yes)//Проверка нажатия кнопки в выборке(окне)
                {
                    foreach (DataGridViewRow row in DG.SelectedRows)//Перебираем список учителей
                    {
                        DataRow Row = ((DataRowView)row.DataBoundItem).Row;
                        String[] fullName = ((string)Row["FullName"]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//Записываем ФИО в массив
                        if (fullName.Length == 3)//Проверяем корректность ФИО учителя
                            mTeacher = new MTeacher(fullName[1], fullName[0], fullName[2], (string)Row["AcademicDegree"], (string)Row["AcademicTitle"], (string)Row["Departament"], (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);//Если ФИО корректно введено, то получаем данные об учителя в текущем формате
                        else mTeacher = new MTeacher(fullName[1], fullName[0], "", (string)Row["AcademicDegree"], (string)Row["AcademicTitle"], (string)Row["Departament"], (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);//Иначе получаем в другом формате
                        Program.refData.CTeacher.Delete(mTeacher);//Удаляем экземпляр учителя из БД(программы)
                    }
                }
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);//Если получаем ошибку, то она отправляется в файл лог
            }
        }

        private void Update(object sender, EventArgs e)
        {
            try
            {
                Logs.GetInfo("Click button Change is Teacher");//Изменить данные в логах об учителе
                if (DG.SelectedRows.Count == 1) //Если количество выделенных строк равно 1
                {

                    DataRow Row = ((DataRowView)DG.SelectedRows[0].DataBoundItem).Row;//
                    String[] fullName = ((string)Row["FullName"]).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //Записываем ФИО в массив
                    MTeacher mTeacher;//Создаём экземпляр класса MTeacher
                    if (fullName.Length == 3)//Проверка на правильность ФИО
                    {
                        mTeacher = new MTeacher(fullName[1], fullName[0], fullName[2], (string)Row["AcademicDegree"], (string)Row["AcademicTitle"], (string)Row["Departament"], (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]); //Если ФИО корректно введено, то получаем данные об учителя в текущем формате
                    }
                    else//Иначе получаем в другом формате
                    {
                        mTeacher = new MTeacher(fullName[1], fullName[0], "", (string)Row["AcademicDegree"], (string)Row["AcademicTitle"], (string)Row["Departament"], (string)Row["MetodicalDays"], (string)Row["Windows"], (string)Row["Weekends"]);
                    }
                    AddTeacher add = new AddTeacher(mTeacher); //Добавляем учителя
                    add.Owner = this;//Добавляем учителя в БД(программу)
                    add.ShowDialog();//Показываем диалог
                }
                else if (DG.SelectedRows.Count > 1) { MessageBox.Show("Для изменения выделите только одну строку!"); }//Если выделили больше 1 строки
                else { MessageBox.Show("Для изменения выделите хотя бы одну строку !"); }//Если вообще не выделили строку
            }
            catch (Exception ex)
            {
                Logs.GetError(ex);//Добавляем ошибку в лог
            }
        }

        private void DG_SelectionChanged(object sender, EventArgs e)
        {
            //button2.Enabled = ((DG.SelectedRows.Count > 0) && (DG.SelectedCells[0].RowIndex != DG.Rows.Count - 1));
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
