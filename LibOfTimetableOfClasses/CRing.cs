using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    // <summary>
    /// Таблица со строками, хранящими данные о расписании звонков Университета.
    /// </summary>
    public class CRing : DataTable, IController
    {
        /// <summary>
        /// Конструктор таблицы
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью полей University и Number
        /// </summary>
        public CRing() : base("Звонки")
        {
            DataColumn[] keys = new DataColumn[2];
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "University",
            };
            Columns.Add(column);
            keys[0] = column;

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Number",
            };
            Columns.Add(column);
            keys[1] = column;
            PrimaryKey = keys;

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "TimeOfStart",
            };
            Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "TimeOfEnd",
            };
            Columns.Add(column);

        }
        /// <summary>
        /// Метод вставки переданной модели MRing в таблицу CRing
        /// в случае уникальности полей University и Number
        /// </summary>
        /// <param name="model">Модель хранящая добавляемую запись таблицы</param>
        /// <returns>Результат вставки</returns>
        public bool Insert(Model model)
        {
            MRing MRing = (MRing)model;
            if (MRing.University == null)
                return false;

            try
            {
                DataRow newRow = NewRow();
                newRow["University"] = MRing.University;
                newRow["Number"] = MRing.Number;
                newRow["TimeOfStart"] = MRing.TimeOfStart;
                newRow["TimeOfEnd"] = MRing.TimeOfEnd;
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
        /// Обновление свойств строки в таблице CRing из переданной модели MRing
        /// Поиск изменяемой строки CAuditor осуществляется по полям "University" и "Number"
        /// </summary>
        /// <param name="model">Модель хранящая обновляемую запись таблицы</param>
        /// <returns>Результат обновления</returns>
        public bool Update(Model model)
        {
            MRing MRing = (MRing)model;

            if (MRing.University == null)
                return false;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["University"] == MRing.University
                    && (string)Rows[i]["Number"] == MRing.Number)
                {
                    try
                    {
                        Rows[i].BeginEdit();
                        Rows[i]["TimeOfStart"] = MRing.TimeOfStart;
                        Rows[i]["TimeOfEnd"] = MRing.TimeOfEnd;
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
        /// <summary>
        /// Метод удаления строки соответствующей переданной модели из таблицы CRing.
        /// В таблице CRing ищется строка с полями "University" и "Number" соответсвующими этим же полям модели, 
        /// переданной в качестве параметра.
        ///    В случае успеха поиска удаляется найденная строка.
        /// </summary>
        /// <param name="model">Модель, хранящая выбранную строку в таблице</param>
        /// <returns>Результат удаления переданной строки из CAuditor</returns>
        public bool Delete(Model model)
        {
            MRing MRing = (MRing)model;

            for (int i = 0; i < Rows.Count; i++)
            {
                if ((string)Rows[i]["University"] == MRing.University
                    && (string)Rows[i]["Number"] == MRing.Number)
                {
                    Rows.Remove(Rows[i]);
                    return true;
                }
            }
            return false;
        }
    }
}