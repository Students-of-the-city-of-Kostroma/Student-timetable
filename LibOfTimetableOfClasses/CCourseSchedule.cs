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
    public CCourseSchedule() : base("Расписание")
        {
            var keys = new DataColumn[1];

            DataColumn idColumn = new DataColumn
            {
                DataType = typeof(int),
                ColumnName = "ID",
            };
            idColumn = LibOfTimetableOfClasses.CAcademicLoad.InpId(idColumn);
            Columns.Add(idColumn);
            keys[0] = idColumn;

            DataColumn column = new DataColumn("AcademicId", Type.GetType("System.Int32"));
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Building"
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
                DataType = typeof(string),
                ColumnName = "DayOfWeek"
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(TimeSpan),
                ColumnName = "StartTime"
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(TimeSpan),
                ColumnName = "EndTime"
            };
            Columns.Add(column);

            PrimaryKey = keys;
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

            if (mSchedule.Id <= 0 || mSchedule.Id == null)
                return false;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((int)Rows[i]["ID"] == mSchedule.Id)
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
        /// <remarks>Поле ID допускает значение null, оно автоинкрементное.</remarks>
        public bool Insert(Model model)
        {
            MCourseSchedule mSchedule = (MCourseSchedule)model;

            if (mSchedule.Id <= 0 || (mSchedule.AcademicId <= 0 || mSchedule.AcademicId == null))
                return false;

            try
            {
                DataRow newRow = NewRow();
                if (mSchedule.Id != null)
                {
                    newRow["ID"] = mSchedule.Id;
                }
                newRow["AcademicId"] = mSchedule.AcademicId;
                newRow["Building"] = mSchedule.Building;
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

            if (mSchedule.Id <= 0 || mSchedule.Id == null)
                return false;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((int)Rows[i]["ID"] == mSchedule.Id)
                {
                    try
                    {
                        Rows[i].BeginEdit();
                        Rows[i]["AcademicId"] = mSchedule.AcademicId;
                        Rows[i]["Building"] = mSchedule.Building;
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
