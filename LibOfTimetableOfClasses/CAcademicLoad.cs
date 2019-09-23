using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
	/// Таблица со строками, хранящими данные об Академической нагрузке
	/// </summary>
    public class CAcademicLoad : DataTable
    {
        /// <summary>
        /// Конструктор таблицы.
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью поля Group.
        /// </summary>
        public CAcademicLoad() : base("Нагрузка")
        {
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Group",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "HoursAll"
            };

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "DistributedHours"
            };
            this.Columns.Add(column);

            

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Discipline"
            };
            this.Columns.Add(column);
            
            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Professor"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Type of lesson"
            };
            this.Columns.Add(column);
        }
    }
}
