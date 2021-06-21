using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Генератор таблиц со строками, хранящими данные о профилях или дисциплинах.
    /// </summary>
    public class ColumnGenerator_Schedule_ : DataTable
    {
        /// <summary>
        /// Конструктор, передающий имя таблицы в родительский класс.
        /// </summary>
        /// <param name="TableName"></param>
        public ColumnGenerator_Schedule_(string TableName) : base(TableName) { }
        /// <summary>
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью полей Fullname и Shortname.
        /// </summary>
        /// <param name="columnName">Имя столбца</param>
        /// <param name="type">Тип</param>
        /// <param name="unique">Уникальность столбца</param>
        public void AddColumns(string columnName, Type type, bool unique = false)
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