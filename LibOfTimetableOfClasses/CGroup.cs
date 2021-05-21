using System;
using System.Data;
using System.Diagnostics;

namespace LibOfTimetableOfClasses
{
    /// <summary>
    /// Таблица со строками, хранящими данные о разных учебных группах в Университете
    /// </summary>
    public class CGroup : DataTable, IController
    {
        /// <summary>
        /// Конструктор таблицы
        /// Формируются поля таблицы типа DataTable и их свойства.
        /// Уникальность строки в таблице определяется уникальностью поля Group.
        /// </summary>
        public CGroup() : base("Группа")
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
                DataType = typeof(ushort),
                ColumnName = "Semestr"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Specialty"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(ushort),
                ColumnName = "Shift"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(ushort),
                ColumnName = "Students"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(ushort),
                ColumnName = "MinNumberOfClass"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(ushort),
                ColumnName = "MaxNumberOfClass"
            };
            this.Columns.Add(column);

            column = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Weekends"
            };
            this.Columns.Add(column);
        }

        /// <summary>
        /// Метод удаления строки соответствующей переданной модели из таблицы CGroup.
        /// В таблице CGroup ищется строка с полем "Group" соответсвующим этому же полю модели, 
        /// переданной в качестве параметра.
        ///    В случае успеха поиска удаляется найденная строка. 
        /// </summary>
        /// <param name="model">Модель, выбранной строки в таблице</param>
        /// <returns>Результат удаления переданной строки из CGroup</returns>
        public bool Delete(Model model)

        {
            MGroup mGroup = (MGroup)model;
            for (int i = 0; i < this.Rows.Count; i++)
            {
                if ((string)this.Rows[i]["Group"] == mGroup.Group)
                {

                    this.Rows[i].Delete();

                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод вставки переданной модели MGroup в таблицу CGroup
        /// в случае уникальности свойства Group модели для таблицы CGroup
        /// </summary>
        /// <param name="model">Вставляемая в CGroup модель</param>
        /// <returns>Результат вставки</returns>
        public bool Insert(Model model)
        {
            MGroup mGroup = (MGroup)model;

            try
            {

                DataRow newRow = this.NewRow();
                newRow["Group"] = mGroup.Group;
                newRow["Semestr"] = mGroup.Semester;
                newRow["Specialty"] = mGroup.Specialty;
                newRow["Shift"] = mGroup.Shift;
                newRow["Students"] = mGroup.Students;
                newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
                newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
                newRow["Weekends"] = mGroup.Weekends;
                this.Rows.Add(newRow);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Обновление свойств строки в таблице CGroup из переданной модели MGroup
        /// Поиск изменяемой строки CGroup осуществляется по полю "Group"
        /// </summary>
        /// <param name="model">Модель по которой нужно обновить записи в таблице</param>
        /// <returns>Успешность выполнения операции</returns>
        public bool Update(Model model)
        {
            MGroup mGroup = (MGroup)model;

            for (int i = 0; i < this.Rows.Count; i++)
            {

                if (mGroup.Group == (string)this.Rows[i]["Group"])
                {
                    try
                    {
                        DataRow newRow = this.Rows[i];
                        newRow["Semestr"] = mGroup.Semester;
                        newRow["Specialty"] = mGroup.Specialty;
                        newRow["Shift"] = mGroup.Shift;
                        newRow["Students"] = mGroup.Students;
                        newRow["MinNumberOfClass"] = mGroup.MinNumberOfClass;
                        newRow["MaxNumberOfClass"] = mGroup.MaxNumberOfClass;
                        newRow["Weekends"] = mGroup.Weekends;
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