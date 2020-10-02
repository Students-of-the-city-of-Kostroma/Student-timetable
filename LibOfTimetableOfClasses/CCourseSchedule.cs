using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Таблица, хранящая расписание занятий
    /// </summary>
    public class CCourseSchedule : DataTable, IController
    {
        /// <summary>
        /// Конструктор таблицы
        /// Формируются поля таблицы
        /// Уникальность строки в таблице определяется уникальностью поля ID
        /// </summary>
        public CCourseSchedule() : base("Расписание")
        {
            DataColumn idColumn = new DataColumn
            {
                DataType = typeof(Int32),
                ColumnName = "ID",
            };
            idColumn.Unique = true;
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 1;
            idColumn.AutoIncrementStep = 1;
            Columns.Add(idColumn);

            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Discipline",
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Classroom"
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(ushort),
                ColumnName = "DayOfWeek"
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "StartTime"
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "EndTime"
            };
            Columns.Add(column);
        }

        /// <summary>
        /// Метод удаления строки соответствующей переданной модели из таблицы CCourseSchedule.
        /// В таблице CCourseSchedule ищется строка с полем "ID" соответсвующим этому же полю модели, 
        /// переданной в качестве параметра.
        ///    В случае успеха поиска удаляется найденная строка. 
        /// </summary>
        /// <param name="model">Модель, выбранной строки в таблице</param>
        /// <returns>Результат удаления переданной строки из CCourseSchedule</returns>
        public bool Delete(Model model)
        {
            MCourseSchedule mSchedule = (MCourseSchedule)model;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((Int32)Rows[i]["ID"] == mSchedule.Id)
                {
                    Rows.Remove(Rows[i]);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод вставки переданной модели MCourseSchedule в таблицу CCourseSchedule
        /// в случае уникальности свойства ID модели для таблицы CCourseSchedule
        /// </summary>
        /// <param name="model">Вставляемая в CCourseSchedule модель</param>
        /// <returns>Результат вставки</returns>
        public bool Insert(Model model)
        {
            MCourseSchedule mSchedule = (MCourseSchedule)model;

            if (mSchedule.Id == 0)
                return false;

            try
            {
                DataRow newRow = NewRow();
                newRow["Discipline"] = mSchedule.Discipline;
                newRow["Classroom"] = mSchedule.Classroom;
                newRow["DayOfWeek"] = mSchedule.DayOfWeek;
                newRow["StartTime"] = mSchedule.StartTime;
                newRow["EndTime"] = mSchedule.EndTime;

                Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Обновление записи в таблице CCourseSchedule из переданной модели MCourseSchedule
        /// Поиск изменяемой строки в CCourseSchedule по полю "ID"
        /// </summary>
        /// <param name="model">Модель хранящая обновляемую запись таблицы</param>
        /// <returns>Результат обновления</returns>
        public bool Update(Model model)
        {
            MCourseSchedule mSchedule = (MCourseSchedule)model;

            if (mSchedule.Id == 0)
                return false;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((Int32)Rows[i]["ID"] == mSchedule.Id)
                {
                    try
                    {
                        Rows[i]["Discipline"] = mSchedule.Discipline;
                        Rows[i]["Classroom"] = mSchedule.Classroom;
                        Rows[i]["DayOfWeek"] = mSchedule.DayOfWeek;
                        Rows[i]["StartTime"] = mSchedule.StartTime;
                        Rows[i]["EndTime"] = mSchedule.EndTime;
                        Rows[i].EndEdit();
                        Rows[i].AcceptChanges();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
