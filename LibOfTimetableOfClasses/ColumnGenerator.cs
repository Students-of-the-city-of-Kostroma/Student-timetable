using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Генератор таблиц со строками, хранящими данные о профилях или дисциплинах.
    /// </summary>
    class ColumnGenerator: DataTable
    {
        /// <summary>
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью полей Fullname и Shortname
        /// </summary>
        public void AddColumns(string ColName)
        {
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Fullname",
                Unique = true
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Shortname"
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = ColName
            };

            Columns.Add(column);
        }
    }
}
