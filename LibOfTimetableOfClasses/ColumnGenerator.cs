using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Генератор таблиц со строками, хранящими данные о профилях или дисциплинах.
    /// </summary>
    public class ColumnGenerator: DataTable
    {
        public ColumnGenerator(string TableName) { }
        /// <summary>
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью полей Fullname и Shortname.
        /// </summary>
        /// <param name="columnName">Имя столбца</param>
        /// <param name="type">Тип</param>
        /// <param name="unique">Уникальность столбца</param>
        public void AddColumns(string columnName, Type type, bool unique )
        {
            DataColumn column = new DataColumn
            {
                DataType = type,
                ColumnName = columnName,
                Unique = unique
            };

            Columns.Add(column);
        }
    }
}
