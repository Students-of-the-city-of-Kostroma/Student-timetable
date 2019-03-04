using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibOfTimetableOfClasses
{
    interface IController
    {
        bool Delete(Model model);
        bool Insert(Model model);
        bool Update(Model model);
    }
    /// <summary>
    /// Абстракция реадизуюящая основной функционал управления данными
    /// </summary>
    public abstract class Controller
    {
        /// <summary>
        /// Общий ресурс для хранения таблиц
        /// </summary>
        public static DataSet DataSet = new DataSet();
        /// <summary>
        /// Таблица с данными
        /// </summary>
        protected DataTable table;
        /// <summary>
        /// Создает таблицу с указаным именем
        /// </summary>
        /// <param name="tableName">Имя таблицы</param>
        public Controller(string tableName="Controller")
        {
            table = new DataTable(tableName);
            DataColumn column = new DataColumn();
            column.DataType = typeof(Guid);
            column.ColumnName = "ID";
            column.ReadOnly = true;
            column.Unique = true;
            table.Columns.Add(column);
            DataSet.Tables.Add(table);
        }
        /// <summary>
        /// Добавление экземпляра в таблицу
        /// </summary>
        /// <param name="model">Добавляемый экземпляр</param>
        /// <returns>Вернет истину если удалось добавить экземпляр</returns>
        public abstract bool Insert(Model model);
        /// <summary>
        /// Изменение экземпляра в таблице
        /// </summary>
        /// <param name="model">Изменяемый экземпляр</param>
        /// <returns>Вернет истину если удалось изменить экземпляр</returns>
        public abstract bool Update(Model model);
        /// <summary>
        /// Удаление экземпляра из таблицы
        /// </summary>
        /// <param name="model">Удаляемый экземпляр</param>
        /// <returns>Вернет истину если удалось изменить экземпляр</returns>
        public abstract bool Delete(Model model);
        /// <summary>
        /// Возвращает таблицу
        /// </summary>
        /// <returns></returns>
        public DataTable Select()
        {
            return table;
        }
        /// <summary>
        /// Возвращает отсортироыванную таблицу по одному столбцу
        /// </summary>
        /// <param name="columnName">Имя столбца</param>
        /// <param name="order">порядок сортировки true-ASC false-DESC</param>
        /// <returns></returns>
        public DataTable Select(string columnName, bool order)
        {
            table.DefaultView.Sort = columnName + " " + ((order)?"ASC":"DESC");
            return table;
        }
    }
}
