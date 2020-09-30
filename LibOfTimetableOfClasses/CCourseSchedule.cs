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
        public CCourseSchedule() : base("Расписание")
        {
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

        public bool Delete(Model model)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Model model)
        {
            MCourseSchedule mSchedule = (MCourseSchedule)model;

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

        public bool Update(Model model)
        {
            throw new NotImplementedException();
        }
    }
}
