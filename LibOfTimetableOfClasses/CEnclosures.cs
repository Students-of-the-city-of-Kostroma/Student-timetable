using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Таблица со строками, хранящими данные о разных корпусах Университета.
    /// </summary>
    public class CEnclosures : DataTable, IController
    {
        /// <summary>
        /// Конструктор таблицы
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью полей Name и University
        /// </summary>
        public CEnclosures() : base("Корпус")
        {
            if (RefData.CEnclosures != null) throw new Exception("Контроллер уже существует");

            DataColumn[] keys = new DataColumn[2];
            DataColumn column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Name"
            };
            this.Columns.Add(column);
            keys[0] = column;

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "University"
            };
            this.Columns.Add(column);
            keys[1] = column;

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Address",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Phone",
                Unique = true
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Comment"
            };
            this.Columns.Add(column);

            this.PrimaryKey = keys;
        }

        /// <summary>
        /// Метод удаления строки соответствующей переданной модели из таблицы  CEnclosures.
        /// В таблице CGroup ищется строка с полем "Name" и "University" соответсвующим этому же полю модели, 
        /// переданной в качестве параметра.
        ///    В случае успеха поиска удаляется найденная строка.
        /// </summary>
        /// <param name="model">Модель, хранящая выбранную строку в таблице</param>
        /// <returns>Результат удаления переданной строки из CGroup</returns>
        public bool Delete(Model model)
        {
            MEnclosures mEnclosures = (MEnclosures)model;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["Name"] == mEnclosures.Name && (string)this.Rows[i]["University"] == mEnclosures.University)
                {
                    this.Rows[i].Delete();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод вставки переданной модели MEnclosures в таблицу CEnclosures
        /// в случае уникальности свойства Name и University модели для таблицы CGroup
        /// </summary>
        /// <param name="model">Модель хранящая добавляемую запись таблицы</param>
        /// <returns>Результат вставки</returns>
        public bool Insert(Model model)
        {
            MEnclosures mEnclosures = (MEnclosures)model;


            try
            {

                DataRow newRow = this.NewRow();
                newRow["Name"] = mEnclosures.Name;
                newRow["University"] = mEnclosures.University;
                newRow["Address"] = mEnclosures.Address;
                newRow["Phone"] = mEnclosures.Phone;
                newRow["Comment"] = mEnclosures.Comment;
                this.Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Source);
                return false;
            }
        }

        /// <summary>
        /// Обновление свойств строки в таблице CEnclosures из переданной модели MEnclosures
        /// Поиск изменяемой строки  CEnclosures осуществляется по полю "Name" и "University"
        /// </summary>
        /// <param name="model">Модель хранящая обновляемую запись таблицы</param>
        /// <returns>Результат обновления</returns>
        public bool Update(Model model)
        {
            MEnclosures mEnclosures = (MEnclosures)model;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["Name"] == mEnclosures.Name && (string)this.Rows[i]["University"] == mEnclosures.University)
                    try
                    {
                        DataRow newRow = this.Rows[i];
                        newRow["Address"] = mEnclosures.Address;
                        newRow["Phone"] = mEnclosures.Phone;
                        newRow["Comment"] = mEnclosures.Comment;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Source);
                        return false;
                    }
            }
            return false;
        }
    }
}